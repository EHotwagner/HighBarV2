// Auto-generated BAR unit data: CorBuildings/LandDefenceOffence
namespace BarData.Units

open BarData

module CorBuildings_LandDefenceOffence =

    let corbhmth =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORBHMTH.DDS"
            LuaKey.String "buildtime", LuaValue.Number 59600.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "80 80 80"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "dead"
            LuaKey.String "energycost", LuaValue.Number 35000.0
            LuaKey.String "energymake", LuaValue.Number 450.0
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 8300.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 3100.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/CORBHMTH.s3o"
            LuaKey.String "script", LuaValue.String "Units/corbhmth.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 650.0
            LuaKey.String "yardmap", LuaValue.String "h cbyybsgybc bsbssbbssb ysbsbssbby gbsssbsssy sbsbsssbsb bsbsssbsbs ysssbsssbg ybbssbsbsy bssbbssbsb cbygsbyybc"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 8.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corbhmth_aoplane.dds"
                    LuaKey.String "cvbuildable", LuaValue.Bool true
                    LuaKey.String "geothermal", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "energy"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "80 80 80"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1917.0
                            LuaKey.String "object", LuaValue.String "Units/corbhmth_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 2250.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 767.0
                            LuaKey.String "object", LuaValue.String "Units/cor5X5C.s3o"
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
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "geothrm2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corbhmth_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 780.0
                            LuaKey.String "areaofeffect", LuaValue.Number 192.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-extraheavy"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "energypershot", LuaValue.Number 150.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 99.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.8
                            LuaKey.String "name", LuaValue.String "Heavy g2g barrage plasma battery"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1650.0
                            LuaKey.String "reloadtime", LuaValue.Number 4.166
                            LuaKey.String "soundhit", LuaValue.String "xplonuk5"
                            LuaKey.String "soundhitvolume", LuaValue.Number 30.0
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "xplolrg5"
                            LuaKey.String "soundstartvolume", LuaValue.Number 20.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 620.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 450.0
                                    LuaKey.String "subs", LuaValue.Number 150.0
                                    LuaKey.String "vtol", LuaValue.Number 110.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORBHMTH_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORBHMTH_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORBHMTH_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let corbuzz =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 29096.0
            LuaKey.String "buildpic", LuaValue.String "CORBUZZ.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1400000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "80 160 80"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 800000.0
            LuaKey.String "explodeas", LuaValue.String "advancedFusionExplosion"
            LuaKey.String "firestate", LuaValue.Number 0.0
            LuaKey.String "footprintx", LuaValue.Number 8.0
            LuaKey.String "footprintz", LuaValue.Number 8.0
            LuaKey.String "health", LuaValue.Number 33500.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 13.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 68000.0
            LuaKey.String "objectname", LuaValue.String "Units/CORBUZZ.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORBUZZ.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "advancedFusionExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 11.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 11.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corbuzz_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_nolrpc_noendgamelrpc_"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "80 160 80"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 26000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 30000.0
                            LuaKey.String "object", LuaValue.String "Units/corbuzz_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "80 10 80"
                            LuaKey.String "damage", LuaValue.Number 12000.0
                            LuaKey.String "footprintx", LuaValue.Number 7.0
                            LuaKey.String "footprintz", LuaValue.Number 7.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 14000.0
                            LuaKey.String "object", LuaValue.String "Units/cor7X7A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-huge"
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
                            LuaKey.Int 1, LuaValue.String "servlrg4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servlrg4"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "rflrpc", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 750.0
                            LuaKey.String "areaofeffect", LuaValue.Number 157.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-huge"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 18000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.1
                            LuaKey.String "name", LuaValue.String "Rapid-fire long-range plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 6100.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.75
                            LuaKey.String "rgbcolor", LuaValue.String "1, 0.4, 0"
                            LuaKey.String "soundhit", LuaValue.String "rflrpcexplo"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 14.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1150.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 2000.0
                                    LuaKey.String "shields", LuaValue.Number 1000.0
                                    LuaKey.String "subs", LuaValue.Number 600.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "RFLRPC"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let cordoom =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "buildpic", LuaValue.String "CORDOOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 55200.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -17.0 0.0"
            LuaKey.String "collisionvolumescales", LuaValue.String "48.0 110.0 48.0"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "energycost", LuaValue.Number 37000.0
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 9400.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 3000.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/CORDOOM.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 80.0
            LuaKey.String "script", LuaValue.String "Units/CORDOOM.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 780.0
            LuaKey.String "sightemitheight", LuaValue.Number 80.0
            LuaKey.String "yardmap", LuaValue.String "yooy oooo oooo yooy"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cordoom_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.281730651855 -0.153618286133 3.57356262207"
                            LuaKey.String "collisionvolumescales", LuaValue.String "80.6815948486 91.7637634277 82.1471252441"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 5400.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1611.0
                            LuaKey.String "object", LuaValue.String "Units/cordoom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 2700.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 644.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3E.s3o"
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
                            LuaKey.Int 1, LuaValue.String "doom"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "doom"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "atadr", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "corethickness", LuaValue.Number 0.32
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 800.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-blue"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Long-range g2g tachyon accelerator"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 950.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.0
                            LuaKey.String "rgbcolor", LuaValue.String "0 0 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "annigun1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 5.5
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 999.0
                                    LuaKey.String "default", LuaValue.Number 4500.0
                                ]
                        ]
                    LuaKey.String "doomsday_green_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.25
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 50.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "High energy g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 0.0
                            LuaKey.String "range", LuaValue.Number 650.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.53333
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrhvy3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.6
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 247.0
                                    LuaKey.String "vtol", LuaValue.Number 65.0
                                ]
                        ]
                    LuaKey.String "doomsday_red_laser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "corethickness", LuaValue.Number 0.15
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 10.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "Light close-quarters g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 370.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.26667
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.1
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 40.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "ATADR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DOOMSDAY_GREEN_LASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DOOMSDAY_RED_LASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corerad =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 1060.0
            LuaKey.String "buildangle", LuaValue.Number 65536.0
            LuaKey.String "buildpic", LuaValue.String "CORERAD.DDS"
            LuaKey.String "buildtime", LuaValue.Number 12000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 7900.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 4450.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 800.0
            LuaKey.String "objectname", LuaValue.String "Units/CORERAD.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORERAD.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 380.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corerad_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.683853149414 -1.83105470342e-07 -1.83734893799"
                            LuaKey.String "collisionvolumescales", LuaValue.String "54.6322937012 35.8339996338 48.325302124"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1560.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 370.0
                            LuaKey.String "object", LuaValue.String "Units/corerad_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 780.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 150.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cor_erad", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 48.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.23333
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-tiny-aa"
                            LuaKey.String "firestarter", LuaValue.Number 20.0
                            LuaKey.String "flighttime", LuaValue.Number 2.3
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Long-range rapid-fire g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "projectiles", LuaValue.Number 1.0
                            LuaKey.String "proximitypriority", LuaValue.Number -0.5
                            LuaKey.String "range", LuaValue.Number 1125.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.6
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 8.0
                            LuaKey.String "smokesize", LuaValue.Number 5.2
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 540.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 100000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 38000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 300.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "COR_ERAD"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let corexp =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 32768.0
            LuaKey.String "buildpic", LuaValue.String "COREXP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2900.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -10 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "40 45 40"
            LuaKey.String "collisionvolumetype", LuaValue.String "BOX"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1900.0
            LuaKey.String "energyupkeep", LuaValue.Number 3.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "extractsmetal", LuaValue.Number 0.001
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 1440.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 20.0
            LuaKey.String "metalcost", LuaValue.Number 240.0
            LuaKey.String "metalstorage", LuaValue.Number 75.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/COREXP.s3o"
            LuaKey.String "onoffable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/COREXP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "h cbbbbbbc bssssosb bosbbssb bsbbbbsb bsbbbbsb bssbbsob bsossssb cbbbbbbc"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corexp_aoplane.dds"
                    LuaKey.String "cvbuildable", LuaValue.Bool true
                    LuaKey.String "metal_extractor", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "metal"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 0.0 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "40 45 40"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 780.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 122.0
                            LuaKey.String "object", LuaValue.String "Units/corexp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 390.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 49.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "mexrun2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "mexoff2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "mexrun2"
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
                            LuaKey.Int 1, LuaValue.String "servmed2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "mexon2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "hllt_bottom", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.12
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 15.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Light close-quarters g2g laser turret"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 435.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.46667
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 112.5
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HLLT_BOTTOM"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corflak =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 1000.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORFLAK.DDS"
            LuaKey.String "buildtime", LuaValue.Number 20100.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 34 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 14000.0
            LuaKey.String "explodeas", LuaValue.String "smallBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 1840.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 850.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORFLAK.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORFLAK.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 525.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corflak_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "37.281829834 27.9406890869 36.1777038574"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 993.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 515.0
                            LuaKey.String "object", LuaValue.String "Units/corflak_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 497.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 206.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-flak"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armflak_gun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 1000.0
                            LuaKey.String "areaofeffect", LuaValue.Number 172.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "flaktrailaa"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 192.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:flak"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "mygravity", LuaValue.Number 0.01
                            LuaKey.String "name", LuaValue.String "Heavy g2a flak cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 775.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.53333
                            LuaKey.String "soundhit", LuaValue.String "flakhit2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "flakfire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 9.0
                            LuaKey.String "stages", LuaValue.Number 0.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 250.0
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
                            LuaKey.String "def", LuaValue.String "ARMFLAK_GUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let corfmd =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "buildpic", LuaValue.String "CORFMD.DDS"
            LuaKey.String "buildtime", LuaValue.Number 60000.0
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -19 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "48 78 48"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 40000.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 3300.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1500.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "objectname", LuaValue.String "Units/CORFMD.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/corfmd.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 195.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corfmd_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "antinuke"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -1.36962890629e-05 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "48.0 37.2831726074 48.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1968.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 980.0
                            LuaKey.String "object", LuaValue.String "Units/corfmd_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 984.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 392.0
                            LuaKey.String "object", LuaValue.String "Units/cor5X5D.s3o"
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
                            LuaKey.Int 1, LuaValue.String "loadwtr1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "loadwtr1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "fmd_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 420.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "antimissiletrail"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "coverage", LuaValue.Number 2000.0
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
                            LuaKey.String "def", LuaValue.String "FMD_ROCKET"
                        ]
                ]
        ]

    let corhllt =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 32768.0
            LuaKey.String "buildpic", LuaValue.String "CORHLLT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4900.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 6 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 90 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 1750.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "mass", LuaValue.Number 10200.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 195.0
            LuaKey.String "objectname", LuaValue.String "Units/CORHLLT.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORHLLT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 475.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corhllt_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 6 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 90 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 900.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 6.5
                            LuaKey.String "metal", LuaValue.Number 120.0
                            LuaKey.String "object", LuaValue.String "Units/corhllt_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 450.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 1.0
                            LuaKey.String "metal", LuaValue.Number 48.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "lltok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hlltselect"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "hllt_bottom", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.12
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 15.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Close-quarters light g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.46667
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 112.5
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                        ]
                    LuaKey.String "hllt_top", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.12
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
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Close-quarters light g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 490.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.46667
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 112.5
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HLLT_TOP"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "HLLT_BOTTOM"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corhlt =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "buildpic", LuaValue.String "CORHLT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 11400.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -8 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "38 90 38"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 4700.0
            LuaKey.String "energystorage", LuaValue.Number 200.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 2750.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 480.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/CORHLT.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORHLT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corhlt_aoplane.dds"
                    LuaKey.String "legacyname", LuaValue.String "Gaat Gun"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "38 95 38"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 1485.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 292.0
                            LuaKey.String "object", LuaValue.String "Units/corhlt_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 743.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 117.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "twractv3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twractv3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cor_laserh1", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 14.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 50.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "High energy g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 620.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Lasrmas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.7
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 392.0
                                    LuaKey.String "default", LuaValue.Number 261.0
                                    LuaKey.String "vtol", LuaValue.Number 35.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "COR_LASERH1"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corint =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 32700.0
            LuaKey.String "buildpic", LuaValue.String "CORINT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 93300.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 -20"
            LuaKey.String "collisionvolumescales", LuaValue.String "72 105 72"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 67000.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 4700.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 13.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 4600.0
            LuaKey.String "objectname", LuaValue.String "Units/CORINT.s3o"
            LuaKey.String "script", LuaValue.String "Units/corint.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 273.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 7.5
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 7.5
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corint_aoplane.dds"
                    LuaKey.String "canareaattack", LuaValue.Number 1.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_nolrpc_"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 0.0987820556641 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "86.25 91.6069641113 74.6947021484"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2760.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2813.0
                            LuaKey.String "object", LuaValue.String "Units/corint_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1380.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1125.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-huge"
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
                            LuaKey.Int 1, LuaValue.String "servlrg4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servlrg4"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "lrpc", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 335.0
                            LuaKey.String "areaofeffect", LuaValue.Number 157.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-huge"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 136.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 6000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 6.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.1
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Long-range plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 4950.0
                            LuaKey.String "reloadtime", LuaValue.Number 16.0
                            LuaKey.String "soundhit", LuaValue.String "lrpcexplo"
                            LuaKey.String "soundhitvolume", LuaValue.Number 42.0
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot"
                            LuaKey.String "soundstartvolume", LuaValue.Number 28.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1150.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 2000.0
                                    LuaKey.String "shields", LuaValue.Number 1000.0
                                    LuaKey.String "subs", LuaValue.Number 600.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "LRPC"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let corjuno =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "CORJUNO.DDS"
            LuaKey.String "buildtime", LuaValue.Number 27700.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "50 88 50"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 16000.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 2500.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 660.0
            LuaKey.String "objectname", LuaValue.String "Units/CORJUNO.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORJUNO.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 494.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.4
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.4
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corjuno_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "1.02378845215 -0.244132250977 6.86585998535"
                            LuaKey.String "collisionvolumescales", LuaValue.String "65.8518981934 75.545135498 65.7558898926"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1350.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 388.0
                            LuaKey.String "object", LuaValue.String "Units/corjuno_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 675.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 192.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:juno_sphere_emit"
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
                            LuaKey.Int 1, LuaValue.String "drone1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "drone1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "juno_pulse", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 1400.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrail-juno"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 1400.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "energypershot", LuaValue.Number 12000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:juno-explo"
                            LuaKey.String "flighttime", LuaValue.Number 400.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 200.0
                            LuaKey.String "model", LuaValue.String "epulse.s3o"
                            LuaKey.String "name", LuaValue.String "Anti radar/minefield/jammer magnetic impulse rocket"
                            LuaKey.String "range", LuaValue.Number 32000.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeperiod", LuaValue.Number 8.0
                            LuaKey.String "smokesize", LuaValue.Number 14.0
                            LuaKey.String "smoketime", LuaValue.Number 45.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "junohit2"
                            LuaKey.String "soundstart", LuaValue.String "junofir2"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 75.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 5500.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 75.0
                            LuaKey.String "weapontimer", LuaValue.Number 4.0
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "junotype", LuaValue.String "base"
                                    LuaKey.String "nofire", LuaValue.Bool true
                                    LuaKey.String "shield_aoe_penetration", LuaValue.Bool true
                                    LuaKey.String "stockpilelimit", LuaValue.Number 20.0
                                    LuaKey.String "water_splash", LuaValue.Number 0.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "mines", LuaValue.Number 1.0
                                ]
                        ]
                    LuaKey.String "juno_pulse_ghost", LuaValue.Table [
                            LuaKey.String "comment", LuaValue.String "Juno rework needs this to avoid loops. Just having this on 1 juno like this, is enough."
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1.0
                                    LuaKey.String "mines", LuaValue.Number 1.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "JUNO_PULSE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corllt =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 32000.0
            LuaKey.String "buildpic", LuaValue.String "CORLLT.DDS"
            LuaKey.String "buildtime", LuaValue.Number 2500.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -29 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 72 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 700.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 650.0
            LuaKey.String "mass", LuaValue.Number 5100.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 90.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/CORLLT.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORLLT.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 494.0
            LuaKey.String "yardmap", LuaValue.String "oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corllt_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32 72 32"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 351.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 55.0
                            LuaKey.String "object", LuaValue.String "Units/corllt_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 176.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 22.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "lltok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "lltselect"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cor_lightlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.12
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 20.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.0
                            LuaKey.String "name", LuaValue.String "Light g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 435.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.46667
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrfir3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 112.5
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                    LuaKey.String "vtol", LuaValue.Number 5.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "COR_LIGHTLASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let cormadsam =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 850.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORMADSAM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5240.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1 5 -2"
            LuaKey.String "collisionvolumescales", LuaValue.String "45 54 45"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 6100.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 2800.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 315.0
            LuaKey.String "objectname", LuaValue.String "Units/CORMADSAM.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORMADSAM.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 375.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cormadsam_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "45 54 45"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 10.0
                            LuaKey.String "metal", LuaValue.Number 233.0
                            LuaKey.String "object", LuaValue.String "Units/cormadsam_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 750.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "metal", LuaValue.Number 100.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "madsam_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
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
                            LuaKey.String "firestarter", LuaValue.Number 72.0
                            LuaKey.String "flighttime", LuaValue.Number 2.5
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Advanced g2a rapid missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 840.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "smokecolor", LuaValue.Number 1.0
                            LuaKey.String "smokeperiod", LuaValue.Number 7.0
                            LuaKey.String "smokesize", LuaValue.Number 4.2
                            LuaKey.String "smoketime", LuaValue.Number 10.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
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
                                    LuaKey.String "vtol", LuaValue.Number 76.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR"
                            LuaKey.String "def", LuaValue.String "MADSAM_MISSILE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let cormaw =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORMAW.DDS"
            LuaKey.String "buildtime", LuaValue.Number 4420.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.33
            LuaKey.String "decoyfor", LuaValue.String "cordrag"
            LuaKey.String "energycost", LuaValue.Number 1550.0
            LuaKey.String "explodeas", LuaValue.String "flamethrower"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "health", LuaValue.Number 1610.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000000000.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 290.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/CORMAW.s3o"
            LuaKey.String "radardistancejam", LuaValue.Number 8.0
            LuaKey.String "script", LuaValue.String "Units/cormaw.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "flamethrowerSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 422.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "ffff"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cormaw_aoplane.dds"
                    LuaKey.String "decoyfor", LuaValue.String "cormaw"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "neutral_when_closed", LuaValue.Bool true
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "autoreclaimable", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 0.0149960864258 0.116882324219"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32.042388916 19.5953521729 32.6287231445"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 600.0
                            LuaKey.String "featuredead", LuaValue.String "ROCKTEETH"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 177.0
                            LuaKey.String "object", LuaValue.String "Units/cordrag.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "rockteeth", LuaValue.Table [
                            LuaKey.String "animating", LuaValue.Number 0.0
                            LuaKey.String "animtrans", LuaValue.Number 0.0
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 500.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2.0
                            LuaKey.String "object", LuaValue.String "Units/cor1X1A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "shadtrans", LuaValue.Number 1.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:flamestreamxm"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
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
                            LuaKey.Int 1, LuaValue.String "servmed2"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servmed2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "dmaw", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 16.0
                            LuaKey.String "burstrate", LuaValue.Number 0.05
                            LuaKey.String "cegtag", LuaValue.String "burnflame-anim"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.82 0.03   0.65 0.4 0.35 0.030   0.44 0.25 0.20 0.028   0.033 0.018 0.012 0.03   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblack"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flamegfxtime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.68
                            LuaKey.String "name", LuaValue.String "Pop-up anti-swarm AoE flamethrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 410.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.1
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 0.75
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 5.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "texture1", LuaValue.String "flame"
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 33.0
                                    LuaKey.String "default", LuaValue.Number 22.0
                                    LuaKey.String "subs", LuaValue.Number 5.5
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DMAW"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let cormexp =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 2048.0
            LuaKey.String "buildpic", LuaValue.String "CORMEXP.DDS"
            LuaKey.String "buildtime", LuaValue.Number 32500.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "75 44 75"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "decoyfor", LuaValue.String "cormoho"
            LuaKey.String "energycost", LuaValue.Number 12000.0
            LuaKey.String "energyupkeep", LuaValue.Number 20.0
            LuaKey.String "explodeas", LuaValue.String "hugeBuildingexplosiongeneric"
            LuaKey.String "extractsmetal", LuaValue.Number 0.004
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 7800.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 20.0
            LuaKey.String "metalcost", LuaValue.Number 2400.0
            LuaKey.String "metalstorage", LuaValue.Number 600.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/CORMEXP.s3o"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/CORMEXP.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "hugeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 676.0
            LuaKey.String "yardmap", LuaValue.String "h oooooooo osssssso osssssso ossoosso ossoosso osssssso osssssso oooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 7.6
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 7.6
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cormoho_aoplane.dds"
                    LuaKey.String "cvbuildable", LuaValue.Bool true
                    LuaKey.String "metal_extractor", LuaValue.Number 4.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "metal"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 0.0263531005859 -0.0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.8415527344 30.0151062012 74.3409423828"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1200.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1442.0
                            LuaKey.String "object", LuaValue.String "Units/cormexp_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "damage", LuaValue.Number 600.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 577.0
                            LuaKey.String "object", LuaValue.String "Units/cor5X5A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "mohorun2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "mohooff2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "mohorun2"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "ok", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twractv3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "mohoon2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cormexp_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 5.0
                            LuaKey.String "burstrate", LuaValue.Number 0.3
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 128.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 1.3
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy g2g/g2a barrage missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 650.0
                            LuaKey.String "reloadtime", LuaValue.Number 5.9
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "startvelocity", LuaValue.Number 450.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 750.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "overrange_distance", LuaValue.Number 748.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 260.0
                                    LuaKey.String "vtol", LuaValue.Number 45.0
                                ]
                        ]
                    LuaKey.String "corsumo_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "corethickness", LuaValue.Number 0.18
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 50.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "High energy g2g laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 650.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.53333
                            LuaKey.String "rgbcolor", LuaValue.String "0 1 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrhvy3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.4
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 215.0
                                    LuaKey.String "vtol", LuaValue.Number 50.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORSUMO_WEAPON"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORMEXP_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corpun =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool false
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORPUN.DDS"
            LuaKey.String "buildtime", LuaValue.Number 17400.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -13 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "52 60 52"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 13500.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 3250.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 12.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1300.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/CORPUN.s3o"
            LuaKey.String "script", LuaValue.String "Units/armguard.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.7
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.7
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corpun_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.184280395508 -6.88419337158 0.0344696044922"
                            LuaKey.String "collisionvolumescales", LuaValue.String "49.7204589844 16.4592132568 48.6775512695"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1764.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 936.0
                            LuaKey.String "object", LuaValue.String "Units/corpun_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 882.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 373.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4B.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "plasma", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 75.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-medium"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Long-range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1245.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.16667
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_priority", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 350.0
                                    LuaKey.String "lboats", LuaValue.Number 350.0
                                    LuaKey.String "subs", LuaValue.Number 90.0
                                    LuaKey.String "vtol", LuaValue.Number 95.0
                                ]
                        ]
                    LuaKey.String "plasma_high", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 75.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-medium"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.4
                            LuaKey.String "mygravity", LuaValue.Number 0.289
                            LuaKey.String "name", LuaValue.String "Long-range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1245.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.16667
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_backup", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 350.0
                                    LuaKey.String "lboats", LuaValue.Number 350.0
                                    LuaKey.String "subs", LuaValue.Number 90.0
                                    LuaKey.String "vtol", LuaValue.Number 95.0
                                ]
                        ]
                    LuaKey.String "smart_trajectory_dummy", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 75.0
                            LuaKey.String "areaofeffect", LuaValue.Number 120.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-medium"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Long-range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 1245.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.16667
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_trajectory_checker", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "PLASMA"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 230.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "PLASMA_HIGH"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "smart_trajectory_dummy"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 230.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let corrl =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 700.0
            LuaKey.String "buildpic", LuaValue.String "CORRL.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1750.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cantbetransported", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 5 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 70 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 850.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 335.0
            LuaKey.String "mass", LuaValue.Number 5100.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 80.0
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORRL.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORRL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corrl_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-0.808319091797 0.000184020996095 2.23503112793"
                            LuaKey.String "collisionvolumescales", LuaValue.String "30.2288513184 52.705368042 33.0822753906"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 180.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 49.0
                            LuaKey.String "object", LuaValue.String "Units/corrl_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 90.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 20.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3D.s3o"
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
                            LuaKey.Int 1, LuaValue.String "kbcormov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbcorsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corrl_missile", LuaValue.Table [
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
                            LuaKey.String "flighttime", LuaValue.Number 1.9
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Light g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 765.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.7
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 6.0
                            LuaKey.String "smokesize", LuaValue.Number 4.8
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rockhvy2"
                            LuaKey.String "startvelocity", LuaValue.Number 400.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 63000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 750.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 115.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOWEAPON LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "CORRL_MISSILE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let corscreamer =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "airsightdistance", LuaValue.Number 2400.0
            LuaKey.String "buildpic", LuaValue.String "CORSCREAMER.DDS"
            LuaKey.String "buildtime", LuaValue.Number 28000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "63 57 63"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 32000.0
            LuaKey.String "explodeas", LuaValue.String "largeBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 1670.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1650.0
            LuaKey.String "objectname", LuaValue.String "Units/CORSCREAMER.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORSCREAMER.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "largeBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 6.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corscreamer_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "aa"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "63 57 63"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 942.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1145.0
                            LuaKey.String "object", LuaValue.String "Units/corscreamer_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 471.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 458.0
                            LuaKey.String "object", LuaValue.String "Units/cor4X4A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "activate", LuaValue.String "targon2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "deactivate", LuaValue.String "targoff2"
                    LuaKey.String "underattack", LuaValue.String "warning1"
                    LuaKey.String "working", LuaValue.String "targsel2"
                    LuaKey.String "count", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "count6"
                            LuaKey.Int 2, LuaValue.String "count5"
                            LuaKey.Int 3, LuaValue.String "count4"
                            LuaKey.Int 4, LuaValue.String "count3"
                            LuaKey.Int 5, LuaValue.String "count2"
                            LuaKey.Int 6, LuaValue.String "count1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "targsel2"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cor_advsam", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 425.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailaa-large"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 425.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.75
                            LuaKey.String "energypershot", LuaValue.Number 1800.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-aa"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "flighttime", LuaValue.Number 2.2
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "corscreamermissile.s3o"
                            LuaKey.String "name", LuaValue.String "Long-range heavy g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 2400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.8
                            LuaKey.String "smokecolor", LuaValue.Number 0.9
                            LuaKey.String "smokeperiod", LuaValue.Number 3.0
                            LuaKey.String "smokesize", LuaValue.Number 11.0
                            LuaKey.String "smoketime", LuaValue.Number 24.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "impact"
                            LuaKey.String "soundhitvolume", LuaValue.Number 8.0
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "aarocket"
                            LuaKey.String "soundstartvolume", LuaValue.Number 8.0
                            LuaKey.String "sprayangle", LuaValue.Number 10000.0
                            LuaKey.String "startvelocity", LuaValue.Number 1400.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 14.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaaflak"
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 0.55
                            LuaKey.String "turnrate", LuaValue.Number 99000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 1000.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1850.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "stockpilelimit", LuaValue.Number 5.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 750.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR LIGHTAIRSCOUT"
                            LuaKey.String "def", LuaValue.String "COR_ADVSAM"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let corsilo =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORSILO.DDS"
            LuaKey.String "buildtime", LuaValue.Number 181000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 18 -2"
            LuaKey.String "collisionvolumescales", LuaValue.String "90 38 84"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 82000.0
            LuaKey.String "explodeas", LuaValue.String "nukeBuilding"
            LuaKey.String "footprintx", LuaValue.Number 7.0
            LuaKey.String "footprintz", LuaValue.Number 7.0
            LuaKey.String "health", LuaValue.Number 6200.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 7700.0
            LuaKey.String "objectname", LuaValue.String "Units/CORSILO.s3o"
            LuaKey.String "radardistance", LuaValue.Number 50.0
            LuaKey.String "script", LuaValue.String "Units/CORSILO.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "nukeBuildingSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooooooooooooooooooooooooooooooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 10.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 10.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corsilo_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "nuke"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.0 -0.0182740600586 2.87522888184"
                            LuaKey.String "collisionvolumescales", LuaValue.String "75.0 23.7250518799 77.7504577637"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 3336.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 4672.0
                            LuaKey.String "object", LuaValue.String "Units/corsilo_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1668.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1869.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "crblmssl", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 1920.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "NUKETRAIL"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 1920.0
                            LuaKey.String "craterboost", LuaValue.Number 2.4
                            LuaKey.String "cratermult", LuaValue.Number 1.2
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.45
                            LuaKey.String "energypershot", LuaValue.Number 187500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:newnukecor"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 400.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.1
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 1500.0
                            LuaKey.String "model", LuaValue.String "crblmssl.s3o"
                            LuaKey.String "name", LuaValue.String "Intercontinental thermonuclear ballistic missile"
                            LuaKey.String "range", LuaValue.Number 72000.0
                            LuaKey.String "reloadtime", LuaValue.Number 30.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.85
                            LuaKey.String "smokeperiod", LuaValue.Number 10.0
                            LuaKey.String "smokesize", LuaValue.Number 28.0
                            LuaKey.String "smoketime", LuaValue.Number 130.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "nukecor"
                            LuaKey.String "soundhitwet", LuaValue.String "nukewater"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 56.0
                            LuaKey.String "soundstart", LuaValue.String "nukelaunch"
                            LuaKey.String "soundstartvolume", LuaValue.Number 20.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 180.0
                            LuaKey.String "targetable", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "railguntrail"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 5500.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 100.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.5
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1600.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "place_target_on_ground", LuaValue.String "true"
                                    LuaKey.String "shield_aoe_penetration", LuaValue.Bool true
                                    LuaKey.String "stockpilelimit", LuaValue.Number 10.0
                                    LuaKey.String "nuclear", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 2500.0
                                    LuaKey.String "default", LuaValue.Number 11500.0
                                ]
                        ]
                    LuaKey.String "nuclear_launch", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 0.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
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
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CRBLMSSL"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "NUCLEAR_LAUNCH"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let cortoast =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool false
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORTOAST.DDS"
            LuaKey.String "buildtime", LuaValue.Number 25700.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 30 15"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.25
            LuaKey.String "energycost", LuaValue.Number 17000.0
            LuaKey.String "explodeas", LuaValue.String "mediumBuildingExplosionGeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 4250.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 2500.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/CORTOAST.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORTOAST.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "mediumBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 416.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "oooo oooo oooo oooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 5.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cortoast_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "60 30 60"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 2304.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 1507.0
                            LuaKey.String "object", LuaValue.String "Units/cortoast_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 576.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 241.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
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
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
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
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "twrturn3"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cortoast_gun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 450.0
                            LuaKey.String "areaofeffect", LuaValue.Number 164.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Pop-up long-range heavy g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.2
                            LuaKey.String "range", LuaValue.Number 1390.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.1
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_priority", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 420.0
                                    LuaKey.String "hvyboats", LuaValue.Number 420.0
                                    LuaKey.String "lboats", LuaValue.Number 420.0
                                    LuaKey.String "subs", LuaValue.Number 90.0
                                    LuaKey.String "vtol", LuaValue.Number 90.0
                                ]
                        ]
                    LuaKey.String "cortoast_gun_high", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 450.0
                            LuaKey.String "areaofeffect", LuaValue.Number 164.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Pop-up long-range heavy g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.2
                            LuaKey.String "range", LuaValue.Number 1390.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.1
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_backup", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 420.0
                                    LuaKey.String "hvyboats", LuaValue.Number 420.0
                                    LuaKey.String "lboats", LuaValue.Number 420.0
                                    LuaKey.String "subs", LuaValue.Number 90.0
                                    LuaKey.String "vtol", LuaValue.Number 90.0
                                ]
                        ]
                    LuaKey.String "smart_trajectory_dummy", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 450.0
                            LuaKey.String "areaofeffect", LuaValue.Number 164.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-heavy"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.4
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Pop-up long-range heavy g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.2
                            LuaKey.String "range", LuaValue.Number 1390.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.1
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_trajectory_checker", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "CORTOAST_GUN"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 230.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "CORTOAST_GUN_HIGH"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "smart_trajectory_dummy"
                            LuaKey.String "maindir", LuaValue.String "0 1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 230.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let cortron =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORTRON.DDS"
            LuaKey.String "buildtime", LuaValue.Number 59000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "59 47 59"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 14000.0
            LuaKey.String "explodeas", LuaValue.String "nukeBuilding"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 3550.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1200.0
            LuaKey.String "objectname", LuaValue.String "Units/CORTRON.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORTRON.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "nukeBuildingSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "yardmap", LuaValue.String "oooooooooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 7.5
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 7.5
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/cortron_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "restrictions_inclusion", LuaValue.String "_notacnukes_"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-3.71137237549 -0.216808312988 -0.0546798706055"
                            LuaKey.String "collisionvolumescales", LuaValue.String "54.9480133057 48.063583374 52.6346282959"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1920.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 445.0
                            LuaKey.String "object", LuaValue.String "Units/cortron_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 960.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 178.0
                            LuaKey.String "object", LuaValue.String "Units/cor3X3A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servroc1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "cortron_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 380.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "cruisemissiletrail-tacnuke"
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 512.0
                            LuaKey.String "craterboost", LuaValue.Number 1.6
                            LuaKey.String "cratermult", LuaValue.Number 0.7
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "energypershot", LuaValue.Number 17437.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:newnuketac"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "flighttime", LuaValue.Number 400.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.1
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 550.0
                            LuaKey.String "model", LuaValue.String "cortronmissile.s3o"
                            LuaKey.String "name", LuaValue.String "Long range tactical g2g nuclear warheads"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 2250.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeperiod", LuaValue.Number 9.0
                            LuaKey.String "smokesize", LuaValue.Number 14.0
                            LuaKey.String "smoketime", LuaValue.Number 60.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundstart", LuaValue.String "mismed1"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 75.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 10000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 150.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1200.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "shield_aoe_penetration", LuaValue.Bool true
                                    LuaKey.String "water_splash_ceg", LuaValue.String "splash-gigantic"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 10.0
                                    LuaKey.String "nuclear", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 750.0
                                    LuaKey.String "default", LuaValue.Number 4000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTLAND"
                            LuaKey.String "def", LuaValue.String "CORTRON_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corvipe =
        LuaValue.Table [
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "buildpic", LuaValue.String "CORVIPE.DDS"
            LuaKey.String "buildtime", LuaValue.Number 15000.0
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.5
            LuaKey.String "energycost", LuaValue.Number 14000.0
            LuaKey.String "explodeas", LuaValue.String "smallBuildingexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 3000.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 730.0
            LuaKey.String "nochasecategory", LuaValue.String "MOBILE"
            LuaKey.String "objectname", LuaValue.String "Units/CORVIPE.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORVIPE.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "smallBuildingExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 546.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "yardmap", LuaValue.String "ooooooooo"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 4.7
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 4.7
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corvipe_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandDefenceOffence"
                    LuaKey.String "techlevel", LuaValue.Number 2.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-2.7282333374 -4.31274414048e-05 -3.87004852295"
                            LuaKey.String "collisionvolumescales", LuaValue.String "42.4275054932 38.4097137451 38.8498077393"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1631.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 380.0
                            LuaKey.String "object", LuaValue.String "Units/corvipe_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 408.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 61.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
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
                            LuaKey.Int 1, LuaValue.String "servmed1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "servmed1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "vipersabot", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrailviper"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 1.05
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile3fast.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy g2g sabot rocket launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 730.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.8
                            LuaKey.String "smokeperiod", LuaValue.Number 10.0
                            LuaKey.String "smokesize", LuaValue.Number 10.0
                            LuaKey.String "smoketime", LuaValue.Number 33.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "SabotHit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "SabotFire"
                            LuaKey.String "startvelocity", LuaValue.Number 570.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.2
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "railguntrail"
                            LuaKey.String "tolerance", LuaValue.Number 8000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 400.0
                            LuaKey.String "weapontimer", LuaValue.Number 0.1
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "overrange_distance", LuaValue.Number 840.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 825.0
                                    LuaKey.String "hvyboats", LuaValue.Number 577.5
                                    LuaKey.String "subs", LuaValue.Number 5.0
                                    LuaKey.String "vtol", LuaValue.Number 26.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "VIPERSABOT"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "corbhmth", corbhmth
            "corbuzz", corbuzz
            "cordoom", cordoom
            "corerad", corerad
            "corexp", corexp
            "corflak", corflak
            "corfmd", corfmd
            "corhllt", corhllt
            "corhlt", corhlt
            "corint", corint
            "corjuno", corjuno
            "corllt", corllt
            "cormadsam", cormadsam
            "cormaw", cormaw
            "cormexp", cormexp
            "corpun", corpun
            "corrl", corrl
            "corscreamer", corscreamer
            "corsilo", corsilo
            "cortoast", cortoast
            "cortron", cortron
            "corvipe", corvipe
        ]
