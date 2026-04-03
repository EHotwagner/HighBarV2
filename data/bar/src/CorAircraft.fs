// Auto-generated BAR unit data: CorAircraft
namespace BarData.Units

open BarData

module CorAircraft =

    let corbw =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORBW.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2070.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 78.0
            LuaKey.String "energycost", LuaValue.Number 1300.0
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
            LuaKey.String "objectname", LuaValue.String "Units/CORBW.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORBW.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speed", LuaValue.Number 280.5
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 1100.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "usesmoothmesh", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "crashable", LuaValue.Number 0.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
                    LuaKey.String "unitgroup", LuaValue.String "emp"
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
                    LuaKey.String "bladewing_lyzer", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Number 0.5
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.12
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "duration", LuaValue.Number 0.01
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.6
                            LuaKey.String "name", LuaValue.String "Light EMP laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 220.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "hackshot"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.3
                            LuaKey.String "thickness", LuaValue.Number 1.4
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 600.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "BLADEWING_LYZER"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 90.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                ]
        ]

    let corca =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "builddistance", LuaValue.Number 136.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCA.DDS"
            LuaKey.String "buildtime", LuaValue.Number 8360.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 75.0
            LuaKey.String "energycost", LuaValue.Number 3200.0
            LuaKey.String "energymake", LuaValue.Number 5.0
            LuaKey.String "energystorage", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "smallexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 161.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.06
            LuaKey.String "maxdec", LuaValue.Number 0.4275
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 115.0
            LuaKey.String "objectname", LuaValue.String "Units/CORCA.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/CORCA.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speed", LuaValue.Number 201.0
            LuaKey.String "terraformspeed", LuaValue.Number 225.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 240.0
            LuaKey.String "workertime", LuaValue.Number 65.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corsolar"
                    LuaKey.Int 2, LuaValue.String "coradvsol"
                    LuaKey.Int 3, LuaValue.String "corwin"
                    LuaKey.Int 4, LuaValue.String "corgeo"
                    LuaKey.Int 5, LuaValue.String "cormstor"
                    LuaKey.Int 6, LuaValue.String "corestor"
                    LuaKey.Int 7, LuaValue.String "cormex"
                    LuaKey.Int 8, LuaValue.String "corexp"
                    LuaKey.Int 9, LuaValue.String "cormakr"
                    LuaKey.Int 10, LuaValue.String "coraap"
                    LuaKey.Int 11, LuaValue.String "corlab"
                    LuaKey.Int 12, LuaValue.String "corvp"
                    LuaKey.Int 13, LuaValue.String "corap"
                    LuaKey.Int 14, LuaValue.String "corhp"
                    LuaKey.Int 15, LuaValue.String "cornanotc"
                    LuaKey.Int 16, LuaValue.String "coreyes"
                    LuaKey.Int 17, LuaValue.String "corrad"
                    LuaKey.Int 18, LuaValue.String "cordrag"
                    LuaKey.Int 19, LuaValue.String "cormaw"
                    LuaKey.Int 20, LuaValue.String "corllt"
                    LuaKey.Int 21, LuaValue.String "corhllt"
                    LuaKey.Int 22, LuaValue.String "corhlt"
                    LuaKey.Int 23, LuaValue.String "corpun"
                    LuaKey.Int 24, LuaValue.String "corrl"
                    LuaKey.Int 25, LuaValue.String "cormadsam"
                    LuaKey.Int 26, LuaValue.String "corerad"
                    LuaKey.Int 27, LuaValue.String "cordl"
                    LuaKey.Int 28, LuaValue.String "corjamt"
                    LuaKey.Int 29, LuaValue.String "corjuno"
                    LuaKey.Int 30, LuaValue.String "corsy"
                    LuaKey.Int 31, LuaValue.String "coruwgeo"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Mr Bob, Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "repair", LuaValue.String "repair2"
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
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
        ]

    let cordrone =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORBW.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1500.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 40.0
            LuaKey.String "energycost", LuaValue.Number 750.0
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "health", LuaValue.Number 675.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.2
            LuaKey.String "maxdec", LuaValue.Number 0.45
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 30.0
            LuaKey.String "nochasecategory", LuaValue.String "COMMANDER VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORDRONE.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORDRONE.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "speed", LuaValue.Number 315.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 900.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "usesmoothmesh", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "drone", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "nohealthbars", LuaValue.Number 1.0
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
                    LuaKey.String "unitgroup", LuaValue.String "emp"
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
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "corethickness", LuaValue.Number 0.15
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-yellow"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "HeatRay"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 360.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.35
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.2
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 60.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HEAT_RAY"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 90.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let cordroneold =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORBW.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1040.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 78.0
            LuaKey.String "energycost", LuaValue.Number 650.0
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "health", LuaValue.Number 166.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.25
            LuaKey.String "maxdec", LuaValue.Number 0.55
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 29.0
            LuaKey.String "nochasecategory", LuaValue.String "COMMANDER VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORDRONEOLD.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORBW.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "speed", LuaValue.Number 280.5
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 1100.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "usesmoothmesh", LuaValue.Number 0.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "drone", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
                    LuaKey.String "unitgroup", LuaValue.String "emp"
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
                            LuaKey.String "beamtime", LuaValue.Number 0.25
                            LuaKey.String "corethickness", LuaValue.Number 0.15
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-yellow"
                            LuaKey.String "firestarter", LuaValue.Number 30.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.0
                            LuaKey.String "name", LuaValue.String "HeatRay"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 360.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.8
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.2
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 80.0
                                    LuaKey.String "vtol", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "semiauto", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.03
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "falloffrate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Rapid-fire a2g machine guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerexpaccweight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "minigun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 3.0
                            LuaKey.String "sprayangle", LuaValue.Number 1000.0
                            LuaKey.String "thickness", LuaValue.Number 0.6
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 16.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HEAT_RAY"
                            LuaKey.String "maindir", LuaValue.String "0 0 1"
                            LuaKey.String "maxangledif", LuaValue.Number 90.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corfink =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORFINK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2400.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "LIGHTAIRSCOUT"
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 110.0
            LuaKey.String "energycost", LuaValue.Number 1450.0
            LuaKey.String "explodeas", LuaValue.String "tinyExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 100.0
            LuaKey.String "maxacc", LuaValue.Number 0.1825
            LuaKey.String "maxaileron", LuaValue.Number 0.0144
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "maxdec", LuaValue.Number 0.0125
            LuaKey.String "maxelevator", LuaValue.Number 0.01065
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00615
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 51.0
            LuaKey.String "objectname", LuaValue.String "Units/CORFINK.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1120.0
            LuaKey.String "script", LuaValue.String "Units/CORFINK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "tinyExplosionGenericSelfd"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 835.0
            LuaKey.String "speed", LuaValue.Number 360.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06125
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06315
            LuaKey.String "wingdrag", LuaValue.Number 0.06
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "crashable", LuaValue.Number 0.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "selectable_as_combat_unit", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
                    LuaKey.String "unitgroup", LuaValue.String "util"
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

    let corhvytrans =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "corhvytrans.DDS"
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
            LuaKey.String "objectname", LuaValue.String "Units/corhvytrans.s3o"
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/corhvytrans.cob"
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
                    LuaKey.String "crashable", LuaValue.Number 0.0
                    LuaKey.String "model_author", LuaValue.String "Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
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
        ]

    let corshad =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORSHAD.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5050.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool true
            LuaKey.String "cruisealtitude", LuaValue.Number 165.0
            LuaKey.String "energycost", LuaValue.Number 4600.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 680.0
            LuaKey.String "maxacc", LuaValue.Number 0.0575
            LuaKey.String "maxaileron", LuaValue.Number 0.01421
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "maxdec", LuaValue.Number 0.055
            LuaKey.String "maxelevator", LuaValue.Number 0.01046
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00596
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 150.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORSHAD.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORSHAD.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speed", LuaValue.Number 234.0
            LuaKey.String "speedtofront", LuaValue.Number 0.06183
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06296
            LuaKey.String "wingdrag", LuaValue.Number 0.145
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
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
                            LuaKey.Int 1, LuaValue.String "vtolcrmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vtolcrac"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corbomb", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 168.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 5.0
                            LuaKey.String "burstrate", LuaValue.Number 0.26667
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 168.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.3
                            LuaKey.String "model", LuaValue.String "airbomb.s3o"
                            LuaKey.String "name", LuaValue.String "Medium a2g incinerating warheads"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1280.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "soundhit", LuaValue.String "bombssml1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "weapontype", LuaValue.String "AircraftBomb"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 112.0
                                    LuaKey.String "subs", LuaValue.Number 35.0
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

    let corvalk =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORVALK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4120.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 100.0
            LuaKey.String "energycost", LuaValue.Number 1450.0
            LuaKey.String "explodeas", LuaValue.String "mediumexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 280.0
            LuaKey.String "loadingradius", LuaValue.Number 300.0
            LuaKey.String "maxacc", LuaValue.Number 0.09
            LuaKey.String "maxdec", LuaValue.Number 0.75
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 74.0
            LuaKey.String "objectname", LuaValue.String "Units/CORVALK.s3o"
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/CORVALK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speed", LuaValue.Number 198.0
            LuaKey.String "transportcapacity", LuaValue.Number 1.0
            LuaKey.String "transportmass", LuaValue.Number 750.0
            LuaKey.String "transportsize", LuaValue.Number 3.0
            LuaKey.String "transportunloadmethod", LuaValue.Number 0.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 360.0
            LuaKey.String "turnrate", LuaValue.Number 550.0
            LuaKey.String "verticalspeed", LuaValue.Number 3.75
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "crashable", LuaValue.Number 0.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
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
        ]

    let corveng =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 950.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "CORVENG.DDS"
            LuaKey.String "buildtime", LuaValue.Number 3330.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 125.0
            LuaKey.String "energycost", LuaValue.Number 2800.0
            LuaKey.String "explodeas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 156.0
            LuaKey.String "maxacc", LuaValue.Number 0.1825
            LuaKey.String "maxaileron", LuaValue.Number 0.0144
            LuaKey.String "maxbank", LuaValue.Number 0.8
            LuaKey.String "maxdec", LuaValue.Number 0.065
            LuaKey.String "maxelevator", LuaValue.Number 0.01065
            LuaKey.String "maxpitch", LuaValue.Number 0.625
            LuaKey.String "maxrudder", LuaValue.Number 0.00615
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 73.0
            LuaKey.String "nochasecategory", LuaValue.String "NOTAIR"
            LuaKey.String "objectname", LuaValue.String "Units/CORVENG.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORVENG.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallExplosionGenericAir"
            LuaKey.String "sightdistance", LuaValue.Number 430.0
            LuaKey.String "speed", LuaValue.Number 297.60001
            LuaKey.String "speedtofront", LuaValue.Number 0.063
            LuaKey.String "turnradius", LuaValue.Number 64.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.06315
            LuaKey.String "wingdrag", LuaValue.Number 0.165
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "attacksafetydistance", LuaValue.Number 300.0
                    LuaKey.String "fighter", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorAircraft"
                    LuaKey.String "unitgroup", LuaValue.String "aa"
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
                    LuaKey.String "corvtol_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailfighter"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-air"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 1.2
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Light guided a2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 680.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "smokecolor", LuaValue.Number 0.55
                            LuaKey.String "smokeperiod", LuaValue.Number 4.0
                            LuaKey.String "smokesize", LuaValue.Number 1.8
                            LuaKey.String "smoketime", LuaValue.Number 8.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "Rocklit3"
                            LuaKey.String "startvelocity", LuaValue.Number 450.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrail"
                            LuaKey.String "tolerance", LuaValue.Number 12000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 20000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 400.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 850.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 4.0
                                    LuaKey.String "default", LuaValue.Number 12.0
                                    LuaKey.String "vtol", LuaValue.Number 125.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "CORVTOL_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "corbw", corbw
            "corca", corca
            "cordrone", cordrone
            "cordroneold", cordroneold
            "corfink", corfink
            "corhvytrans", corhvytrans
            "corshad", corshad
            "corvalk", corvalk
            "corveng", corveng
        ]
