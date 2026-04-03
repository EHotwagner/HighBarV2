// Auto-generated BAR unit data: Legion/Labs
namespace BarData.Units

open BarData

module Legion_Labs =

    let legaap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 28000.0
            LuaKey.String "metalcost", LuaValue.Number 2900.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGAAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 31050.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "142 50 142"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 3900.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGAAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGAAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 305.5
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo ooooooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "legaca"
                    LuaKey.Int 2, LuaValue.String "legstronghold"
                    LuaKey.Int 3, LuaValue.String "legmineb"
                    LuaKey.Int 4, LuaValue.String "legatorpbomber"
                    LuaKey.Int 5, LuaValue.String "legafigdef"
                    LuaKey.Int 6, LuaValue.String "legwhisper"
                    LuaKey.Int 7, LuaValue.String "legfort"
                    LuaKey.Int 8, LuaValue.String "legphoenix"
                    LuaKey.Int 9, LuaValue.String "legvenator"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legaap_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_noair_"
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "Protar/Ghoulish"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "142 50 142"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2112.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1936.0
                            LuaKey.String "object", LuaValue.String "Units/legaap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1056.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 968.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                            LuaKey.Int 2, LuaValue.String "custom:radarpulse_t1_slow"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pairactv"
                        ]
                ]
        ]

    let legadvshipyard =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "legadvshipyard.DDS"
            LuaKey.String "buildtime", LuaValue.Number 23550.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 10 -2"
            LuaKey.String "collisionvolumescales", LuaValue.String "186 78 183"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 10000.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 5900.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 2800.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "objectname", LuaValue.String "Units/legadvshipyard.s3o"
            LuaKey.String "script", LuaValue.String "Units/legadvshipyard.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 301.60001
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "waterline", LuaValue.Number 19.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew weeeeeeeeeew"
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"leganavyconsub\",\r\n\t\t\t\"leganavyengineer\",\r\n\t\t\t\"leganavycruiser\",\r\n\t\t\t\"leganavyheavysub\",\r\n\t\t\t\"leganavybattlesub\",\r\n\t\t\t\"leganavyaaship\",\r\n\t\t\t\"leganavyradjamship\",\r\n\t\t\t\"leganavyantinukecarrier\",\r\n\t\t\t\"leganavybattleship\",\r\n\t\t\t\"leganavyartyship\",\r\n\t\t\t\"leganavymissileship\",\r\n\t\t\t\"leganavyflagship\",\r\n\t\t\t\"leganavyantiswarm\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -13 -3"
                            LuaKey.String "collisionvolumescales", LuaValue.String "192 61 180"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2650.0
                            LuaKey.String "footprintx", LuaValue.Number 12.0
                            LuaKey.String "footprintz", LuaValue.Number 12.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2174.0
                            LuaKey.String "object", LuaValue.String "Units/legadvshipyard_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pshpactv"
                        ]
                ]
        ]

    let legalab =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "energycost", LuaValue.Number 16000.0
            LuaKey.String "metalcost", LuaValue.Number 2600.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGALAB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 25200.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "140 52 140"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "health", LuaValue.Number 4500.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGALAB.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGALAB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 288.60001
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo ooooooooo oooeeeooo oooeeeooo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo ooeeeeeoo"
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legack\",\r\n\t\t\t\"legaceb\",\r\n\t\t\t\"legstr\",\r\n\t\t\t\"legamph\",\r\n\t\t\t\"legshot\",\r\n\t\t\t\"leginc\",\r\n\t\t\t\"legsrail\",\r\n\t\t\t\"legbart\",\r\n\t\t\t\"leginfestor\",\r\n\t\t\t\"leghrk\",\r\n\t\t\t\"legadvaabot\",\r\n\t\t\t\"legsnapper\",\r\n\t\t\t\"legaradk\",\r\n\t\t\t\"legaspy\",\r\n\t\t\t\"legajamk\",\r\n\t\t\t\"legdecom\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legalab_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "model_author", LuaValue.String "Protar/Ghoulish"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "140 52 140"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2443.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1743.0
                            LuaKey.String "object", LuaValue.String "Units/legalab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1222.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 872.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "plabactv"
                        ]
                ]
        ]

    let legamphlab =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 5600.0
            LuaKey.String "metalcost", LuaValue.Number 1200.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "legamphlab.DDS"
            LuaKey.String "buildtime", LuaValue.Number 11400.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "98 60 91"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 160.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 2800.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "minwaterdepth", LuaValue.Number 25.0
            LuaKey.String "objectname", LuaValue.String "Units/legamphlab.s3o"
            LuaKey.String "script", LuaValue.String "Units/legamphlab.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 240.0
            LuaKey.String "terraformspeed", LuaValue.Number 750.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "legotter"
                    LuaKey.Int 2, LuaValue.String "legamphtank"
                    LuaKey.Int 3, LuaValue.String "legfloat"
                    LuaKey.Int 4, LuaValue.String "legamph"
                    LuaKey.Int 5, LuaValue.String "legaabot"
                    LuaKey.Int 6, LuaValue.String "legadvaabot"
                    LuaKey.Int 7, LuaValue.String "legdecom"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legamphlab_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies, Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 1.5
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 44 89"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 5.0
                            LuaKey.String "metal", LuaValue.Number 800.0
                            LuaKey.String "object", LuaValue.String "Units/legamphlab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pvehactv"
                        ]
                ]
        ]

    let legap =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 1100.0
            LuaKey.String "metalcost", LuaValue.Number 430.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGAP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 6380.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "96 45 96"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "health", LuaValue.Number 1780.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGAP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 510.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "script", LuaValue.String "Units/LEGAP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oooooo oooooo oooooo oooooo oooooo oooooo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "legca"
                    LuaKey.Int 2, LuaValue.String "legfig"
                    LuaKey.Int 3, LuaValue.String "legkam"
                    LuaKey.Int 4, LuaValue.String "legcib"
                    LuaKey.Int 5, LuaValue.String "legmos"
                    LuaKey.Int 6, LuaValue.String "leglts"
                    LuaKey.Int 7, LuaValue.String "legatrans"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legap_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_noair_"
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "Protar/Ghoulish"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 45 96"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1155.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 540.0
                            LuaKey.String "object", LuaValue.String "Units/legap_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 578.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 216.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:radarpulse_t1_slow"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "unitready"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "airplantselect"
                        ]
                ]
        ]

    let legavp =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "energycost", LuaValue.Number 16000.0
            LuaKey.String "metalcost", LuaValue.Number 2500.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGAVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 27750.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 5"
            LuaKey.String "collisionvolumescales", LuaValue.String "144 70 144"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 9.0
            LuaKey.String "footprintz", LuaValue.Number 9.0
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "health", LuaValue.Number 5100.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGAVP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGAVP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 286.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "h\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oo oo oo oo oo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        oo oo oe ee ee ee eo oo oo\r\n        "
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legacv\",\r\n\t\t\t\"legmrv\",\r\n\t\t\t\"legaskirmtank\",\r\n\t\t\t\"legfloat\",\r\n\t\t\t\"legaheattank\",\r\n\t\t\t\"legmed\",\r\n\t\t\t\"legamcluster\",\r\n\t\t\t\"legvcarry\",\r\n\t\t\t\"legavroc\",\r\n\t\t\t\"leginf\",\r\n\t\t\t\"legvflak\",\r\n\t\t\t\"legavantinuke\",\r\n\t\t\t\"legavjam\",\r\n\t\t\t\"legavrad\",\r\n\t\t\t\"legafcv\"\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool false
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legavp_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 12.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 0.01
                    LuaKey.String "unitgroup", LuaValue.String "buildert2"
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 5"
                            LuaKey.String "collisionvolumescales", LuaValue.String "144 70 144"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2777.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1721.0
                            LuaKey.String "object", LuaValue.String "Units/legavp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 1389.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 860.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pvehactv"
                        ]
                ]
        ]

    let legfhp =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 2000.0
            LuaKey.String "metalcost", LuaValue.Number 670.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGFHP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 8700.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "96 35 96"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 3750.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "minwaterdepth", LuaValue.Number 5.0
            LuaKey.String "objectname", LuaValue.String "Units/legfhp.s3o"
            LuaKey.String "script", LuaValue.String "Units/legfhp.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 312.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "waterline", LuaValue.Number 4.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "weeeew weeeew weeeew weeeew weeeew weeeew"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "legch"
                    LuaKey.Int 2, LuaValue.String "legsh"
                    LuaKey.Int 3, LuaValue.String "legner"
                    LuaKey.Int 4, LuaValue.String "legah"
                    LuaKey.Int 5, LuaValue.String "legmh"
                    LuaKey.Int 6, LuaValue.String "legcar"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "Protar, ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 1.5
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 35 96"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2014.0
                            LuaKey.String "footprintx", LuaValue.Number 8.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 715.0
                            LuaKey.String "object", LuaValue.String "Units/legfhp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "hoverok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hoversl2"
                        ]
                ]
        ]

    let leggant =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 62000.0
            LuaKey.String "metalcost", LuaValue.Number 8400.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGGANT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 67300.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "196 105 196"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 17800.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGGANT.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGGANT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 1800.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legeheatraymech\",\r\n\t\t\t\"legeallterrainmech\",\r\n\t\t\t\"legjav\",\r\n\t\t\t\"legelrpcmech\",\r\n\t\t\t\"legehovertank\",\r\n\t\t\t\"legerailtank\",\r\n\t\t\t\"legeshotgunmech\",\r\n\t\t\t\"legkeres\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leggant_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "model_author", LuaValue.String "Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "190 100 190"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5101.0
                            LuaKey.String "object", LuaValue.String "Units/leggant_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4800.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2040.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:GantWhiteLight"
                            LuaKey.Int 2, LuaValue.String "custom:YellowLight"
                            LuaKey.Int 3, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "gantok2"
                    LuaKey.String "build", LuaValue.String "gantok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "gantok2"
                    LuaKey.String "repair", LuaValue.String "lathelrg"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "gantok1"
                    LuaKey.String "working", LuaValue.String "build"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "gantsel1"
                        ]
                ]
        ]

    let leggantuw =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 62000.0
            LuaKey.String "metalcost", LuaValue.Number 8400.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGGANTUW.DDS"
            LuaKey.String "buildtime", LuaValue.Number 67300.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "196 105 196"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 17800.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGGANT.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGGANT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 1800.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legeheatraymech\",\r\n\t\t\t\"legjav\",\r\n\t\t\t\"legehovertank\",\r\n            \"legfloat\",\r\n            \"legamph\",\r\n            \"leganavybattleship\"\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leggant_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "model_author", LuaValue.String "Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "190 100 190"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5101.0
                            LuaKey.String "object", LuaValue.String "Units/leggant_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4800.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2040.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:GantWhiteLight"
                            LuaKey.Int 2, LuaValue.String "custom:YellowLight"
                            LuaKey.Int 3, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "gantok2"
                    LuaKey.String "build", LuaValue.String "gantok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "gantok2"
                    LuaKey.String "repair", LuaValue.String "lathelrg"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "gantok1"
                    LuaKey.String "working", LuaValue.String "build"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "gantsel1"
                        ]
                ]
        ]

    let leghalab =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 62000.0
            LuaKey.String "metalcost", LuaValue.Number 4900.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGGANT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 67300.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "196 105 196"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 17800.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGGANT.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGGANT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 1200.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "leghack"
                    LuaKey.Int 2, LuaValue.String "leginc"
                    LuaKey.Int 3, LuaValue.String "legsrail"
                    LuaKey.Int 4, LuaValue.String "legajamk"
                    LuaKey.Int 5, LuaValue.String "legdecom"
                    LuaKey.Int 6, LuaValue.String "legadvaabot"
                    LuaKey.Int 7, LuaValue.String "legjav"
                    LuaKey.Int 8, LuaValue.String "legshot"
                    LuaKey.Int 9, LuaValue.String "legamph"
                    LuaKey.Int 10, LuaValue.String "legaspy"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leggant_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "model_author", LuaValue.String "Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "190 100 190"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5101.0
                            LuaKey.String "object", LuaValue.String "Units/leggant_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4800.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2040.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:GantWhiteLight"
                            LuaKey.Int 2, LuaValue.String "custom:YellowLight"
                            LuaKey.Int 3, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "gantok2"
                    LuaKey.String "build", LuaValue.String "gantok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "gantok2"
                    LuaKey.String "repair", LuaValue.String "lathelrg"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "gantok1"
                    LuaKey.String "working", LuaValue.String "build"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "gantsel1"
                        ]
                ]
        ]

    let leghavp =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 46000.0
            LuaKey.String "metalcost", LuaValue.Number 4900.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGHAVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 67300.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "196 105 196"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 1400.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 12.0
            LuaKey.String "footprintz", LuaValue.Number 12.0
            LuaKey.String "health", LuaValue.Number 17800.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGHAVP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGHAVP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "terraformspeed", LuaValue.Number 3000.0
            LuaKey.String "workertime", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooo oooooooooooo oooooooooooo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo ooeeeeeeeeoo yoeeeeeeeeoy"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "leghacv"
                    LuaKey.Int 2, LuaValue.String "legaheattank"
                    LuaKey.Int 3, LuaValue.String "legmed"
                    LuaKey.Int 4, LuaValue.String "legavroc"
                    LuaKey.Int 5, LuaValue.String "leginf"
                    LuaKey.Int 6, LuaValue.String "legvflak"
                    LuaKey.Int 7, LuaValue.String "legavantinuke"
                    LuaKey.Int 8, LuaValue.String "legavjam"
                    LuaKey.Int 9, LuaValue.String "legmrv"
                    LuaKey.Int 10, LuaValue.String "legehovertank"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legamphlab_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 15.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "buildert3"
                    LuaKey.String "model_author", LuaValue.String "Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 12 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "190 100 190"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 9600.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 5101.0
                            LuaKey.String "object", LuaValue.String "Units/leghavp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 4800.0
                            LuaKey.String "footprintx", LuaValue.Number 9.0
                            LuaKey.String "footprintz", LuaValue.Number 9.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2040.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pvehactv"
                        ]
                ]
        ]

    let leghp =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 2000.0
            LuaKey.String "metalcost", LuaValue.Number 670.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGHP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 8700.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "96 35 96"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 3750.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 200.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGHP.s3o"
            LuaKey.String "script", LuaValue.String "Units/LEGHP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 312.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo oeeeeo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "legch"
                    LuaKey.Int 2, LuaValue.String "legsh"
                    LuaKey.Int 3, LuaValue.String "legner"
                    LuaKey.Int 4, LuaValue.String "legah"
                    LuaKey.Int 5, LuaValue.String "legmh"
                    LuaKey.Int 6, LuaValue.String "legcar"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leghp_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "techlevel", LuaValue.Number 1.5
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 35 96"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2014.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 662.0
                            LuaKey.String "object", LuaValue.String "Units/leghp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 12 96"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1007.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 265.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "hoverok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hoversl2"
                        ]
                ]
        ]

    let leglab =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 1024.0
            LuaKey.String "energycost", LuaValue.Number 1050.0
            LuaKey.String "metalcost", LuaValue.Number 470.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGLAB.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "100 45 100"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 2900.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGLAB.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGLAB.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 290.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oooooo oooooo oeeeeo oeeeeo oeeeeo oeeeeo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "legck"
                    LuaKey.Int 2, LuaValue.String "legrezbot"
                    LuaKey.Int 3, LuaValue.String "leggob"
                    LuaKey.Int 4, LuaValue.String "leglob"
                    LuaKey.Int 5, LuaValue.String "legcen"
                    LuaKey.Int 6, LuaValue.String "legbal"
                    LuaKey.Int 7, LuaValue.String "legkark"
                    LuaKey.Int 8, LuaValue.String "legaabot"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/leglab_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandFactories"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "88 28 88"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1560.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 442.0
                            LuaKey.String "object", LuaValue.String "Units/leglab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 780.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 177.0
                            LuaKey.String "object", LuaValue.String "Units/cor6X6B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "unitready"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "labselect"
                        ]
                ]
        ]

    let legsplab =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "legsplab.DDS"
            LuaKey.String "buildtime", LuaValue.Number 11800.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "category", LuaValue.String "SURFACE UNDERWATER"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 5500.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 2200.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1400.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "objectname", LuaValue.String "Units/legsplab.s3o"
            LuaKey.String "script", LuaValue.String "Units/legsplab.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 169.0
            LuaKey.String "sonardistance", LuaValue.Number 800.0
            LuaKey.String "terraformspeed", LuaValue.Number 1000.0
            LuaKey.String "waterline", LuaValue.Number 0.0
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "yardmap", LuaValue.String "wwwwww weeeew weeeew weeeew weeeew wwwwww"
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legspcon\",\r\n\t\t\t\"legspsurfacegunship\",\r\n\t\t\t\"legspcarrier\",\r\n\t\t\t\"legspbomber\",\r\n\t\t\t\"legsptorpgunship\",\r\n\t\t\t\"legspfighter\",\r\n\t\t\t\"legspradarsonarplane\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "airfactory", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "ZephyrSkies"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_noair_"
                    LuaKey.String "techlevel", LuaValue.Number 1.5
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "2.5 0.0 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "117.5 41.25 112.5"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1200.0
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 930.0
                            LuaKey.String "object", LuaValue.String "Units/legsplab_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "seaplok2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "seaplsl2"
                        ]
                ]
        ]

    let legsy =
        LuaValue.Table [
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "legsy.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5100.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "96 42 96"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 950.0
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 4300.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 450.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "minwaterdepth", LuaValue.Number 30.0
            LuaKey.String "objectname", LuaValue.String "Units/legsy.s3o"
            LuaKey.String "script", LuaValue.String "Units/legsy.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 340.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "waterline", LuaValue.Number 1.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "oyyyyo oeeeeo oeeeeo oeeeeo oeeeeo oyyyyo"
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "legnavyconship"
                    LuaKey.Int 2, LuaValue.String "legnavyrezsub"
                    LuaKey.Int 3, LuaValue.String "legnavyscout"
                    LuaKey.Int 4, LuaValue.String "legnavyaaship"
                    LuaKey.Int 5, LuaValue.String "legnavyfrigate"
                    LuaKey.Int 6, LuaValue.String "legnavydestro"
                    LuaKey.Int 7, LuaValue.String "legnavysub"
                    LuaKey.Int 8, LuaValue.String "legnavyartyship"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "103 42 103"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1794.0
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 400.0
                            LuaKey.String "object", LuaValue.String "Units/legsy_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "untdone"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "pshpactv"
                        ]
                ]
        ]

    let legvp =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 2048.0
            LuaKey.String "energycost", LuaValue.Number 1650.0
            LuaKey.String "metalcost", LuaValue.Number 570.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGVP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5700.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 19 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "101 53 106"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energystorage", LuaValue.Number 100.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "levelground", LuaValue.Bool true
            LuaKey.String "health", LuaValue.Number 3000.0
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 100.0
            LuaKey.String "objectname", LuaValue.String "Units/LEGVP.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/LEGVP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingexplosiongenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 279.0
            LuaKey.String "terraformspeed", LuaValue.Number 500.0
            LuaKey.String "workertime", LuaValue.Number 150.0
            LuaKey.String "yardmap", LuaValue.String "h\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oo oo oo oo oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    oe ee ee ee oo oo\r\n    "
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "legscout"
                    LuaKey.Int 2, LuaValue.String "legcv"
                    LuaKey.Int 3, LuaValue.String "legotter"
                    LuaKey.Int 4, LuaValue.String "leghades"
                    LuaKey.Int 5, LuaValue.String "leghelios"
                    LuaKey.Int 6, LuaValue.String "leggat"
                    LuaKey.Int 7, LuaValue.String "legbar"
                    LuaKey.Int 8, LuaValue.String "legrail"
                    LuaKey.Int 9, LuaValue.String "legmlv"
                    LuaKey.Int 10, LuaValue.String "legamphtank"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/legvp_aoplane.dds"
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "model_author", LuaValue.String "Protar/Ghoulish"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "Legion/Labs"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -13 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "101 40 106"
                            LuaKey.String "collisionvolumetype", LuaValue.String "BOX"
                            LuaKey.String "damage", LuaValue.Number 1590.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 470.0
                            LuaKey.String "object", LuaValue.String "Units/legvp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 795.0
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 188.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:WhiteLight"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "unitcomplete", LuaValue.String "unitready"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "vehplantselect"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "legaap", legaap
            "legadvshipyard", legadvshipyard
            "legalab", legalab
            "legamphlab", legamphlab
            "legap", legap
            "legavp", legavp
            "legfhp", legfhp
            "leggant", leggant
            "leggantuw", leggantuw
            "leghalab", leghalab
            "leghavp", leghavp
            "leghp", leghp
            "leglab", leglab
            "legsplab", legsplab
            "legsy", legsy
            "legvp", legvp
        ]
