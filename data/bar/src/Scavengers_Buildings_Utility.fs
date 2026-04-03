// Auto-generated BAR unit data: Scavengers/Buildings/Utility
namespace BarData.Units

open BarData

module Scavengers_Buildings_Utility =

    let armgatet3 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 2048.0
            LuaKey.String "buildpic", LuaValue.String "ARMGATET3.DDS"
            LuaKey.String "buildtime", LuaValue.Number 220000.0
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "NOWEAPON"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 3"
            LuaKey.String "collisionvolumescales", LuaValue.String "91 85 91"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 216000.0
            LuaKey.String "energystorage", LuaValue.Number 4000.0
            LuaKey.String "exemptcategory", LuaValue.String "WEAPON"
            LuaKey.String "explodeas", LuaValue.String "fusionExplosion"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 10250.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 12000.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "objectname", LuaValue.String "Units/ARMGATET3.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMGATET3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "fusionExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 350.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/armgate_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Beherith/Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "shield_color_mult", LuaValue.Number 25.0
                    LuaKey.String "shield_power", LuaValue.Number 24700.0
                    LuaKey.String "shield_radius", LuaValue.Number 710.0
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandUtil"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 3"
                            LuaKey.String "collisionvolumescales", LuaValue.String "91 67 91"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 7500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 7500.0
                            LuaKey.String "object", LuaValue.String "Units/armgatet3_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 3750.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 3200.0
                            LuaKey.String "object", LuaValue.String "Units/arm4X4A.s3o"
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
                            LuaKey.Int 1, LuaValue.String "drone1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "drone1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 710.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "energyupkeep", LuaValue.Number 0.0
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 999.0
                                    LuaKey.String "power", LuaValue.Number 49400.0
                                    LuaKey.String "powerregen", LuaValue.Number 520.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 1968.0
                                    LuaKey.String "radius", LuaValue.Number 710.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 15438.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool true
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.17
                                        ]
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corgatet3 =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "buildangle", LuaValue.Number 4096.0
            LuaKey.String "buildpic", LuaValue.String "CORGATET3.DDS"
            LuaKey.String "buildtime", LuaValue.Number 275000.0
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "canattack", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "NOWEAPON"
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "96 143 96"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 275000.0
            LuaKey.String "energystorage", LuaValue.Number 5000.0
            LuaKey.String "exemptcategory", LuaValue.String "WEAPON"
            LuaKey.String "explodeas", LuaValue.String "customfusionexplo"
            LuaKey.String "footprintx", LuaValue.Number 6.0
            LuaKey.String "footprintz", LuaValue.Number 6.0
            LuaKey.String "health", LuaValue.Number 12500.0
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "maxslope", LuaValue.Number 10.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 16000.0
            LuaKey.String "noautofire", LuaValue.Bool true
            LuaKey.String "objectname", LuaValue.String "Units/CORGATET3.s3o"
            LuaKey.String "script", LuaValue.String "Units/CORGATET3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "advancedFusionExplosionSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 350.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "buildinggrounddecaldecayspeed", LuaValue.Number 30.0
                    LuaKey.String "buildinggrounddecalsizex", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecalsizey", LuaValue.Number 9.0
                    LuaKey.String "buildinggrounddecaltype", LuaValue.String "decals/corgate_aoplane.dds"
                    LuaKey.String "model_author", LuaValue.String "Mr Bob/Protar"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "shield_color_mult", LuaValue.Number 25.0
                    LuaKey.String "shield_power", LuaValue.Number 66500.0
                    LuaKey.String "shield_radius", LuaValue.Number 825.0
                    LuaKey.String "subfolder", LuaValue.String "CorBuildings/LandUtil"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "util"
                    LuaKey.String "usebuildinggrounddecal", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -4 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "96 115 96"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 8500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 6.0
                            LuaKey.String "footprintz", LuaValue.Number 6.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 10000.0
                            LuaKey.String "object", LuaValue.String "Units/corgatet3_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 4250.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 4000.0
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
                            LuaKey.Int 1, LuaValue.String "drone1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "drone1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 825.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "energyupkeep", LuaValue.Number 0.0
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 951.0
                                    LuaKey.String "power", LuaValue.Number 66500.0
                                    LuaKey.String "powerregen", LuaValue.Number 650.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 2812.5
                                    LuaKey.String "radius", LuaValue.Number 825.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 20900.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool true
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.17
                                        ]
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let scavbeacon_t1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 10.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 5000.0
            LuaKey.String "metalcost", LuaValue.Number 500.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/SCAVBEACON.DDS"
            LuaKey.String "buildtime", LuaValue.Number 5000.0
            LuaKey.String "category", LuaValue.String "CANBEUW"
            LuaKey.String "canmove", LuaValue.Bool false
            LuaKey.String "canSelfDestruct", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "32 32 32"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "energystorage", LuaValue.Number 20000.0
            LuaKey.String "metalstorage", LuaValue.Number 2000.0
            LuaKey.String "energymake", LuaValue.Number 200.0
            LuaKey.String "metalmake", LuaValue.Number 2.0
            LuaKey.String "explodeas", LuaValue.String "advmetalmaker"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 0.0
            LuaKey.String "footprintz", LuaValue.Number 0.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "health", LuaValue.Number 5000.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/scavbeacon_t1.s3o"
            LuaKey.String "script", LuaValue.String "scavs/scavbeacon.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "transportByEnemy", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "scavengerbeacon"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String ""
            LuaKey.String "reclaimable", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "Scavengers"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paratrooper", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:PurpleLight"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 1.0
                            LuaKey.String "cameraShake", LuaValue.Number 350.0
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 1200.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Armageddon Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.75
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Lasrmas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 83.25
                                    LuaKey.String "default", LuaValue.Number 250.0
                                    LuaKey.String "vtol", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                        ]
                ]
        ]

    let scavbeacon_t2 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 10.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 25000.0
            LuaKey.String "metalcost", LuaValue.Number 2500.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/SCAVBEACON.DDS"
            LuaKey.String "buildtime", LuaValue.Number 25000.0
            LuaKey.String "category", LuaValue.String "CANBEUW"
            LuaKey.String "canmove", LuaValue.Bool false
            LuaKey.String "canSelfDestruct", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "48 48 48"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "energystorage", LuaValue.Number 60000.0
            LuaKey.String "metalstorage", LuaValue.Number 6000.0
            LuaKey.String "energymake", LuaValue.Number 400.0
            LuaKey.String "metalmake", LuaValue.Number 4.0
            LuaKey.String "explodeas", LuaValue.String "advmetalmaker"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 0.0
            LuaKey.String "footprintz", LuaValue.Number 0.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "health", LuaValue.Number 25000.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/scavbeacon_t2.s3o"
            LuaKey.String "script", LuaValue.String "scavs/scavbeacon.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "transportByEnemy", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "scavengerbeacon"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String ""
            LuaKey.String "reclaimable", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "Scavengers"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paratrooper", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:PurpleLight"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 1.0
                            LuaKey.String "cameraShake", LuaValue.Number 350.0
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 1200.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Armageddon Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.75
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrhvy3"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 250.0
                                    LuaKey.String "default", LuaValue.Number 750.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                        ]
                ]
        ]

    let scavbeacon_t3 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 10.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 50000.0
            LuaKey.String "metalcost", LuaValue.Number 5000.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/SCAVBEACON.DDS"
            LuaKey.String "buildtime", LuaValue.Number 50000.0
            LuaKey.String "category", LuaValue.String "CANBEUW"
            LuaKey.String "canmove", LuaValue.Bool false
            LuaKey.String "canSelfDestruct", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "64 64 64"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "energystorage", LuaValue.Number 100000.0
            LuaKey.String "metalstorage", LuaValue.Number 10000.0
            LuaKey.String "energymake", LuaValue.Number 800.0
            LuaKey.String "metalmake", LuaValue.Number 8.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 0.0
            LuaKey.String "footprintz", LuaValue.Number 0.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "health", LuaValue.Number 50000.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/scavbeacon_t3.s3o"
            LuaKey.String "script", LuaValue.String "scavs/scavbeacon.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "transportByEnemy", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "scavengerbeacon"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String ""
            LuaKey.String "reclaimable", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "Scavengers"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paratrooper", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:PurpleLight"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 1.0
                            LuaKey.String "cameraShake", LuaValue.Number 350.0
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 1200.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Armageddon Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.75
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray2xl"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 750.0
                                    LuaKey.String "default", LuaValue.Number 2500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                        ]
                ]
        ]

    let scavbeacon_t4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 10.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "energycost", LuaValue.Number 100000.0
            LuaKey.String "metalcost", LuaValue.Number 10000.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/SCAVBEACON.DDS"
            LuaKey.String "buildtime", LuaValue.Number 100000.0
            LuaKey.String "category", LuaValue.String "CANBEUW"
            LuaKey.String "canmove", LuaValue.Bool false
            LuaKey.String "canSelfDestruct", LuaValue.Bool false
            LuaKey.String "capturable", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "85 85 85"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "energystorage", LuaValue.Number 200000.0
            LuaKey.String "metalstorage", LuaValue.Number 20000.0
            LuaKey.String "energymake", LuaValue.Number 1600.0
            LuaKey.String "metalmake", LuaValue.Number 16.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 0.0
            LuaKey.String "footprintz", LuaValue.Number 0.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "health", LuaValue.Number 100000.0
            LuaKey.String "speed", LuaValue.Number 0.0
            LuaKey.String "noautofire", LuaValue.Bool false
            LuaKey.String "objectname", LuaValue.String "scavs/scavbeacon_t4.s3o"
            LuaKey.String "script", LuaValue.String "scavs/scavbeacon.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 4.0
            LuaKey.String "selfdestructcountdown", LuaValue.Number 1.0
            LuaKey.String "sightdistance", LuaValue.Number 750.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "transportByEnemy", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 0.0
            LuaKey.String "unitname", LuaValue.String "scavengerbeacon"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "yardmap", LuaValue.String ""
            LuaKey.String "reclaimable", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "Scavengers"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paratrooper", LuaValue.Bool true
                ]
            LuaKey.String "featuredefs", LuaValue.Table []
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:PurpleLight"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 1.0
                            LuaKey.String "cameraShake", LuaValue.Number 350.0
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 1200.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Armageddon Heat Ray"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.75
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray2xl"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 8.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1800.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 4125.0
                                    LuaKey.String "default", LuaValue.Number 12500.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "WEAPON"
                        ]
                ]
        ]

    let scavsafeareabeacon =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "maxdec", LuaValue.Number 0.0
            LuaKey.String "buildangle", LuaValue.Number 8192.0
            LuaKey.String "energycost", LuaValue.Number 100000.0
            LuaKey.String "metalcost", LuaValue.Number 10000.0
            LuaKey.String "buildpic", LuaValue.String "scavengers/scavsafeareabeacon.DDS"
            LuaKey.String "buildtime", LuaValue.Number 100000.0
            LuaKey.String "blocking", LuaValue.Bool false
            LuaKey.String "canrepeat", LuaValue.Bool false
            LuaKey.String "cloakcost", LuaValue.Number 10.0
            LuaKey.String "explodeas", LuaValue.String "scavcomexplosion"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "initcloaked", LuaValue.Bool true
            LuaKey.String "levelground", LuaValue.Bool false
            LuaKey.String "health", LuaValue.Number 2800.0
            LuaKey.String "maxslope", LuaValue.Number 24.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "mincloakdistance", LuaValue.Number 250.0
            LuaKey.String "objectname", LuaValue.String "scavs/scavsafeareabeacon.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMEYES.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "sightdistance", LuaValue.Number 1560.0
            LuaKey.String "stealth", LuaValue.Bool true
            LuaKey.String "waterline", LuaValue.Number 5.0
            LuaKey.String "yardmap", LuaValue.String ""
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Beherith"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "removestop", LuaValue.Bool true
                    LuaKey.String "removewait", LuaValue.Bool true
                    LuaKey.String "subfolder", LuaValue.String "ArmBuildings/LandUtil"
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
                            LuaKey.Int 1, LuaValue.String "servsml6"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "minesel1"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armgatet3", armgatet3
            "corgatet3", corgatet3
            "scavbeacon_t1", scavbeacon_t1
            "scavbeacon_t2", scavbeacon_t2
            "scavbeacon_t3", scavbeacon_t3
            "scavbeacon_t4", scavbeacon_t4
            "scavsafeareabeacon", scavsafeareabeacon
        ]
