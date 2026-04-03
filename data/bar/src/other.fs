// Auto-generated BAR unit data: other
namespace BarData.Units

open BarData

module other =

    let armrespawn =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 4.5
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 1.0
            LuaKey.String "builddistance", LuaValue.Expr "range"
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMNANOTCPLAT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 20000.0
            LuaKey.String "canassist", LuaValue.Bool true
            LuaKey.String "canfight", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "31 50 31"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 20000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 50000000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "objectname", LuaValue.String "Units/ARMRESPAWN.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMNANOT2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "sightdistance", LuaValue.Expr "range"
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "turnrate", LuaValue.Number 1.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "workertime", LuaValue.Expr "Spring.GetModOptions().commanderbuildersbuildpower"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armnanotc_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/SeaUtil"
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
                            LuaKey.Int 1, LuaValue.String "varmmove"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "varmsel"
                        ]
                ]
        ]

    let armsat =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.05
            LuaKey.String "airhoverfactor", LuaValue.Number 0.4
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.01
            LuaKey.String "energycost", LuaValue.Number 40000.0
            LuaKey.String "metalcost", LuaValue.Number 4000.0
            LuaKey.String "buildpic", LuaValue.String "ARMAWAC.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12800.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 2700.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.05
            LuaKey.String "maxaileron", LuaValue.Number 0.01
            LuaKey.String "maxbank", LuaValue.Number 0.15
            LuaKey.String "health", LuaValue.Number 780.0
            LuaKey.String "maxelevator", LuaValue.Number 0.004
            LuaKey.String "maxpitch", LuaValue.Number 0.1
            LuaKey.String "maxrudder", LuaValue.Number 0.003
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMSAT.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/ARMSAT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 300.0
            LuaKey.String "sonardistance", LuaValue.Number 0.0
            LuaKey.String "speedtofront", LuaValue.Number 0.04
            LuaKey.String "turnradius", LuaValue.Number 200.0
            LuaKey.String "turnrate", LuaValue.Number 80.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.05
            LuaKey.String "wingdrag", LuaValue.Number 0.1
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "other"
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
                            LuaKey.Int 1, LuaValue.String "vtolarmv"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "aaradsel"
                        ]
                ]
        ]

    let chip =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/chip.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "12 1.7 12"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 25.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "chip.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "chip.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let correspawn =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 4.5
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 1.0
            LuaKey.String "builddistance", LuaValue.Expr "range"
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORNANOTCPLAT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 20000.0
            LuaKey.String "canassist", LuaValue.Bool true
            LuaKey.String "canfight", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "31 50 31"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 20000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 50000000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "objectname", LuaValue.String "Units/CORRESPAWN.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORNANOT2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "sightdistance", LuaValue.Expr "range"
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "turnrate", LuaValue.Number 1.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "workertime", LuaValue.Expr "Spring.GetModOptions().commanderbuildersbuildpower"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cornanotc_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/SeaUtil"
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
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
                            LuaKey.Int 1, LuaValue.String "vcormove"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vcorsel"
                        ]
                ]
        ]

    let corsat =
        LuaValue.Table [
            LuaKey.String "acceleration", LuaValue.Number 0.05
            LuaKey.String "airhoverfactor", LuaValue.Number 0.4
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.01
            LuaKey.String "energycost", LuaValue.Number 40000.0
            LuaKey.String "metalcost", LuaValue.Number 4000.0
            LuaKey.String "buildpic", LuaValue.String "CORAWAC.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12800.0
            LuaKey.String "canfly", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collide", LuaValue.Bool false
            LuaKey.String "cruisealtitude", LuaValue.Number 2700.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "hoverattack", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.05
            LuaKey.String "maxaileron", LuaValue.Number 0.01
            LuaKey.String "maxbank", LuaValue.Number 0.15
            LuaKey.String "health", LuaValue.Number 780.0
            LuaKey.String "maxelevator", LuaValue.Number 0.004
            LuaKey.String "maxpitch", LuaValue.Number 0.1
            LuaKey.String "maxrudder", LuaValue.Number 0.003
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/corsat.s3o"
            LuaKey.String "radardistance", LuaValue.Number 580.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/corsat.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 350.0
            LuaKey.String "sonardistance", LuaValue.Number 0.0
            LuaKey.String "speedtofront", LuaValue.Number 0.04
            LuaKey.String "turnradius", LuaValue.Number 200.0
            LuaKey.String "turnrate", LuaValue.Number 80.0
            LuaKey.String "usesmoothmesh", LuaValue.Bool true
            LuaKey.String "wingangle", LuaValue.Number 0.05
            LuaKey.String "wingdrag", LuaValue.Number 0.1
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "other"
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
                            LuaKey.Int 1, LuaValue.String "aaradsel"
                        ]
                ]
        ]

    let dbg_sphere =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.207
            LuaKey.String "autoheal", LuaValue.Number 15.0
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "energycost", LuaValue.Number 3400.0
            LuaKey.String "metalcost", LuaValue.Number 175.0
            LuaKey.String "buildpic", LuaValue.String "ARMSPID.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5090.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 15 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 940.0
            LuaKey.String "speed", LuaValue.Number 71.55
            LuaKey.String "maxwaterdepth", LuaValue.Number 16.0
            LuaKey.String "movementclass", LuaValue.String "TBOT3"
            LuaKey.String "mygravity", LuaValue.Number 10000.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "dbg_sphere.s3o"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "strafetoattack", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.749
            LuaKey.String "turnrate", LuaValue.Number 1290.29993
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let dbg_sphere_fullmetal =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.207
            LuaKey.String "autoheal", LuaValue.Number 15.0
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "energycost", LuaValue.Number 3400.0
            LuaKey.String "metalcost", LuaValue.Number 175.0
            LuaKey.String "buildpic", LuaValue.String "ARMSPID.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5090.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 15 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 940.0
            LuaKey.String "speed", LuaValue.Number 71.55
            LuaKey.String "maxwaterdepth", LuaValue.Number 16.0
            LuaKey.String "movementclass", LuaValue.String "TBOT3"
            LuaKey.String "mygravity", LuaValue.Number 10000.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "dbg_sphere_fullmetal.s3o"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "strafetoattack", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.749
            LuaKey.String "turnrate", LuaValue.Number 1290.29993
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "normaltex", LuaValue.String "unittextures/blank_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let dice =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/dice.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "14 14 14"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 50.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "dice.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "dice.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let freefusion =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "energycost", LuaValue.Number 50.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "buildpic", LuaValue.String "FREEFUSION.DDS"
            LuaKey.String "buildtime", LuaValue.Number 800.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 850.0
            LuaKey.String "energystorage", LuaValue.Number 150.0
            LuaKey.String "explodeas", LuaValue.String "fusionExplosion"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 560.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/freefusion.s3o"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "fusionExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 250.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "damage", LuaValue.Number 2500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 30.0
                            LuaKey.String "object", LuaValue.String "Units/freefusion_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "faction", LuaValue.String "none"
                                ]
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1350.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 5.0
                            LuaKey.String "metal", LuaValue.Number 10.0
                            LuaKey.String "object", LuaValue.String "Units/arm5X5A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
        ]

    let legnanotcbase =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 4.5
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 1.0
            LuaKey.String "builddistance", LuaValue.Expr "range"
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "legnanotc.DDS"
            LuaKey.String "buildtime", LuaValue.Number 20000.0
            LuaKey.String "canassist", LuaValue.Bool true
            LuaKey.String "canfight", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canreclaim", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "canstop", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "31 50 31"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "floater", LuaValue.Bool true
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "mass", LuaValue.Number 700.0
            LuaKey.String "health", LuaValue.Number 20000.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 50000000.0
            LuaKey.String "minwaterdepth", LuaValue.Number 12.0
            LuaKey.String "movementclass", LuaValue.String "NANO"
            LuaKey.String "objectname", LuaValue.String "Units/legnanotcbase.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGNANOTCTEMP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "sightdistance", LuaValue.Expr "range"
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "turnrate", LuaValue.Number 1.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "workertime", LuaValue.Expr "Spring.GetModOptions().commanderbuildersbuildpower"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legnanotcbase_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/SeaUtil"
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
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
                            LuaKey.Int 1, LuaValue.String "vcormove"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vcorsel"
                        ]
                ]
        ]

    let meteor =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 1.0
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "other/meteor.dds"
            LuaKey.String "buildtime", LuaValue.Number 1.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "56 11 56"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String ""
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 165.75
            LuaKey.String "health", LuaValue.Number 2.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "meteor.s3o"
            LuaKey.String "radardistance", LuaValue.Number 900.0
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructas", LuaValue.String ""
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "meteor"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "workertime", LuaValue.Number 0.0
            LuaKey.String "yardmap", LuaValue.String "oo oo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table []
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 450.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "meteortrail"
                            LuaKey.String "collidefriendly", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 450.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.75
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-meteor"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 100.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Asteroid"
                            LuaKey.String "range", LuaValue.Number 29999.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "smoketrail", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk4"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 0.5
                            LuaKey.String "stages", LuaValue.Number 0.0
                            LuaKey.String "startvelocity", LuaValue.Number 2000.0
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 120.0
                            LuaKey.String "weapontimer", LuaValue.Number 10.0
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "wobble", LuaValue.Number 0.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "raptor", LuaValue.Number 0.001
                                    LuaKey.String "commanders", LuaValue.Number 10.0
                                    LuaKey.String "default", LuaValue.Number 700.0
                                    LuaKey.String "tinyraptor", LuaValue.Number 0.001
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                        ]
                ]
        ]

    let mission_command_tower =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 16384.0
            LuaKey.String "energycost", LuaValue.Number 100000.0
            LuaKey.String "metalcost", LuaValue.Number 10000.0
            LuaKey.String "buildpic", LuaValue.String "MISSION_COMMAND_TOWER.DDS"
            LuaKey.String "buildtime", LuaValue.Number 100000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "energymake", LuaValue.Number 250.0
            LuaKey.String "energyupkeep", LuaValue.Number 0.0
            LuaKey.String "explodeas", LuaValue.String "fusionExplosion"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 11100.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Units/mission_command_tower.s3o"
            LuaKey.String "script", LuaValue.String "mission_command_tower.cob"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "fusionExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 100.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo oooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/mission_command_tower_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 11.25
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 11.25
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "geothrm1"
                        ]
                ]
        ]

    let nuketest =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.8
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 25000.0
            LuaKey.String "metalcost", LuaValue.Number 400.0
            LuaKey.String "builddistance", LuaValue.Number 90.0
            LuaKey.String "buildpic", LuaValue.String "other/nuketest.dds"
            LuaKey.String "buildtime", LuaValue.Number 10500.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 165.75
            LuaKey.String "health", LuaValue.Number 5900.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/cube.s3o"
            LuaKey.String "radardistance", LuaValue.Number 900.0
            LuaKey.String "script", LuaValue.String "scavs/droppod.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructas", LuaValue.String "custom:newnuke"
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "nukedroppod"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "yy yy"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "isairbase", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:dirt"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "nuketest", LuaValue.Table [
                            LuaKey.String "alwaysvisible", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 1280.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "NUKETRAIL"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 1280.0
                            LuaKey.String "craterboost", LuaValue.Number 2.4
                            LuaKey.String "cratermult", LuaValue.Number 1.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:newnuke"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "crblmssl.s3o"
                            LuaKey.String "name", LuaValue.String "Newest Nuke"
                            LuaKey.String "range", LuaValue.Number 29999.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "smoketrail", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "nukearm"
                            LuaKey.String "soundstart", LuaValue.String "aarocket"
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 1800.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "wobble", LuaValue.Number 50.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 2500.0
                                    LuaKey.String "default", LuaValue.Number 9500.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "nuclear", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "NUKETEST"
                        ]
                ]
        ]

    let nuketestcor =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.8
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 25000.0
            LuaKey.String "metalcost", LuaValue.Number 400.0
            LuaKey.String "builddistance", LuaValue.Number 90.0
            LuaKey.String "buildpic", LuaValue.String "other/nuketest.dds"
            LuaKey.String "buildtime", LuaValue.Number 10500.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 165.75
            LuaKey.String "health", LuaValue.Number 6200.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/cube.s3o"
            LuaKey.String "radardistance", LuaValue.Number 900.0
            LuaKey.String "script", LuaValue.String "scavs/droppod.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructas", LuaValue.String "custom:newnuke-cor"
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "nukedroppod"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "yy yy"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "isairbase", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:dirt"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "nuketestcor", LuaValue.Table [
                            LuaKey.String "alwaysvisible", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 1920.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "NUKETRAIL"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 1920.0
                            LuaKey.String "craterboost", LuaValue.Number 2.4
                            LuaKey.String "cratermult", LuaValue.Number 1.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:newnukecor"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "crblmssl.s3o"
                            LuaKey.String "name", LuaValue.String "Newest Nuke"
                            LuaKey.String "range", LuaValue.Number 29999.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "smoketrail", LuaValue.Number 1.0
                            LuaKey.String "soundhit", LuaValue.String "nukecor"
                            LuaKey.String "soundstart", LuaValue.String "aarocket"
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 1800.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "wobble", LuaValue.Number 50.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 2500.0
                                    LuaKey.String "default", LuaValue.Number 11500.0
                                ]
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "nuclear", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "NUKETESTCOR"
                        ]
                ]
        ]

    let nuketestorg =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 1.8
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 25000.0
            LuaKey.String "metalcost", LuaValue.Number 400.0
            LuaKey.String "builddistance", LuaValue.Number 90.0
            LuaKey.String "buildpic", LuaValue.String "other/nuketest.dds"
            LuaKey.String "buildtime", LuaValue.Number 10500.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 165.75
            LuaKey.String "health", LuaValue.Number 5900.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/cube.s3o"
            LuaKey.String "radardistance", LuaValue.Number 900.0
            LuaKey.String "script", LuaValue.String "scavs/droppod.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructas", LuaValue.String "custom:armnuke"
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "nukedroppod"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "yy yy"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "isairbase", LuaValue.Bool true
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
                            LuaKey.String "areaofeffect", LuaValue.Number 1280.0
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "NUKETRAIL"
                            LuaKey.String "collidefriendly", LuaValue.Number 0.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 1280.0
                            LuaKey.String "craterboost", LuaValue.Number 2.4
                            LuaKey.String "cratermult", LuaValue.Number 1.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:armnuke"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "scavs/cube.s3o"
                            LuaKey.String "name", LuaValue.String "Newest Nuke"
                            LuaKey.String "range", LuaValue.Number 29999.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundstart", LuaValue.String "misicbm1"
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "null"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turret", LuaValue.Number 1.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 1800.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "wobble", LuaValue.Number 50.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 2500.0
                                    LuaKey.String "default", LuaValue.Number 9500.0
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

    let pbr_cube =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.207
            LuaKey.String "autoheal", LuaValue.Number 15.0
            LuaKey.String "maxdec", LuaValue.Number 0.6486
            LuaKey.String "energycost", LuaValue.Number 3400.0
            LuaKey.String "metalcost", LuaValue.Number 175.0
            LuaKey.String "buildpic", LuaValue.String "ARMSPID.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5090.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 15 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 940.0
            LuaKey.String "speed", LuaValue.Number 71.55
            LuaKey.String "maxwaterdepth", LuaValue.Number 16.0
            LuaKey.String "movementclass", LuaValue.String "TBOT3"
            LuaKey.String "mygravity", LuaValue.Number 10000.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "pbr_cube.s3o"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "strafetoattack", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.749
            LuaKey.String "turnrate", LuaValue.Number 1290.29993
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let resourcecheat =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 1.0
            LuaKey.String "buildpic", LuaValue.String "other/resourcecheat.dds"
            LuaKey.String "buildtime", LuaValue.Number 312500.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "110 110 110"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.95
            LuaKey.String "energymake", LuaValue.Number 1000000.0
            LuaKey.String "energystorage", LuaValue.Number 1000000.0
            LuaKey.String "explodeas", LuaValue.String "customfusionexplo"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 7900.0
            LuaKey.String "maxslope", LuaValue.Number 13.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalmake", LuaValue.Number 1000000.0
            LuaKey.String "metalstorage", LuaValue.Number 1000000.0
            LuaKey.String "objectname", LuaValue.String "Units/ARMAFUS.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMAFUS.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "advancedFusionExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooooooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armafus_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "model_author", LuaValue.String "Cremuss"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "110 110 110"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 16290.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 40.0
                            LuaKey.String "metal", LuaValue.Number 6441.0
                            LuaKey.String "object", LuaValue.String "Units/armafus_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 8145.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2576.0
                            LuaKey.String "object", LuaValue.String "Units/arm4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "fusion1"
                        ]
                ]
        ]

    let volcano_projectile_unit =
        LuaValue.Table [
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "faction", LuaValue.String "NONE"
                    LuaKey.String "is_volcano_launcher", LuaValue.Number 1.0
                ]
            LuaKey.String "metalcost", LuaValue.Number 100.0
            LuaKey.String "energycost", LuaValue.Number 100.0
            LuaKey.String "buildtime", LuaValue.Number 1.0
            LuaKey.String "health", LuaValue.Number 1000000.0
            LuaKey.String "power", LuaValue.Number 1.0
            LuaKey.String "corpse", LuaValue.String ""
            LuaKey.String "leavetracks", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "movementclass", LuaValue.String "BOT3"
            LuaKey.String "speed", LuaValue.Number 0.0001
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canattackground", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "SURFACE"
            LuaKey.String "drawtype", LuaValue.Number 0.0
            LuaKey.String "selectable", LuaValue.Bool false
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "o"
            LuaKey.String "canstop", LuaValue.Bool false
            LuaKey.String "canpatrol", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "initcloaked", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 0.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 0.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "objectname", LuaValue.String "Units/CORTHUD.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORTHUD.cob"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "radardistance", LuaValue.Number 0.0
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "volcano_fireball", LuaValue.Table [
                            LuaKey.String "name", LuaValue.String "Volcano Fireball"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "model", LuaValue.String "Raptors/greyrock2.s3o"
                            LuaKey.String "cegtag", LuaValue.String "volcano_rock_trail"
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:volcano_rock_impact"
                            LuaKey.String "gravityaffected", LuaValue.Bool true
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.1
                            LuaKey.String "mygravity", LuaValue.Number 0.16
                            LuaKey.String "range", LuaValue.Number 32000.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.0
                            LuaKey.String "weaponvelocity", LuaValue.Number 780.0
                            LuaKey.String "impulsefactor", LuaValue.Number 3.0
                            LuaKey.String "impulseboost", LuaValue.Number 400.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 220.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "collideground", LuaValue.Bool true
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplolrg1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 75.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "VOLCANO_FIREBALL"
                            LuaKey.String "onlyTargetCategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let xmasball1_1 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "3.5 3.5 3.5"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 40.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball1_1.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball1_2 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "4 4 4"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 40.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball1_2.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball1_3 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "4.5 4.5 4.5"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 40.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball1_3.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball1_4 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "5 5 5"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 40.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball1_4.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball1_5 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "5.5 5.5 5.5"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 40.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball1_5.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball1_6 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "6 6 6"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 40.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball1_6.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball2_1 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball2.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "3.5 3.5 3.5"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 45.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball2_1.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball2_2 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball2.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "4 4 4"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 45.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball2_2.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball2_3 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball2.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "4.5 4.5 4.5"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 45.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball2_3.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball2_4 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball2.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "5 5 5"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 45.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball2_4.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball2_5 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball2.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "5.5 5.5 5.5"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 45.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball2_5.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let xmasball2_6 =
        LuaValue.Table [
            LuaKey.String "blocking", LuaValue.Bool true
            LuaKey.String "energycost", LuaValue.Number 1.0
            LuaKey.String "metalcost", LuaValue.Number 0.0
            LuaKey.String "buildpic", LuaValue.String "other/xmasball2.dds"
            LuaKey.String "buildtime", LuaValue.Number 255.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "OBJECT"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "6 6 6"
            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
            LuaKey.String "crushresistance", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "blank"
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 45.0
            LuaKey.String "health", LuaValue.Number 560000.0
            LuaKey.String "maxslope", LuaValue.Number 64.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "movementclass", LuaValue.String "SBOT2"
            LuaKey.String "objectname", LuaValue.String "xmasball2_6.s3o"
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "xmasball.lua"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "blank"
            LuaKey.String "sightdistance", LuaValue.Number 0.0
            LuaKey.String "sonarstealth", LuaValue.Bool true
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String "f"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Floris"
                    LuaKey.String "nohealthbars", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "other"
                    LuaKey.String "decoration", LuaValue.Number 1.0
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armrespawn", armrespawn
            "armsat", armsat
            "chip", chip
            "correspawn", correspawn
            "corsat", corsat
            "dbg_sphere", dbg_sphere
            "dbg_sphere_fullmetal", dbg_sphere_fullmetal
            "dice", dice
            "freefusion", freefusion
            "legnanotcbase", legnanotcbase
            "meteor", meteor
            "mission_command_tower", mission_command_tower
            "nuketest", nuketest
            "nuketestcor", nuketestcor
            "nuketestorg", nuketestorg
            "pbr_cube", pbr_cube
            "resourcecheat", resourcecheat
            "volcano_projectile_unit", volcano_projectile_unit
            "xmasball1_1", xmasball1_1
            "xmasball1_2", xmasball1_2
            "xmasball1_3", xmasball1_3
            "xmasball1_4", xmasball1_4
            "xmasball1_5", xmasball1_5
            "xmasball1_6", xmasball1_6
            "xmasball2_1", xmasball2_1
            "xmasball2_2", xmasball2_2
            "xmasball2_3", xmasball2_3
            "xmasball2_4", xmasball2_4
            "xmasball2_5", xmasball2_5
            "xmasball2_6", xmasball2_6
        ]
