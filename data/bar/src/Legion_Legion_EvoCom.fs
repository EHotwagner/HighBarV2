// Auto-generated BAR unit data: Legion/Legion EvoCom
namespace BarData.Units

open BarData

module Legion_Legion_EvoCom =

    let legcomlvl10 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 40.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 110000.0
            LuaKey.String "metalcost", LuaValue.Number 11000.0
            LuaKey.String "builddistance", LuaValue.Number 600.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 264000.0
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 69 37"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 2000.0
            LuaKey.String "energystorage", LuaValue.Number 10000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "legcomlvl4"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 22000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 49.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 50.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legevocom3.s3o"
            LuaKey.String "pushresistant", LuaValue.Expr "Spring.GetModOptions().pushresistant"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 54.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "reclaimspeed", LuaValue.Number 5388.0
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legevocom3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 1796.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legmoho\",\r\n\t\t\t\"legfus\",\r\n\t\t\t\"legwin\",\r\n\t\t\t\"legadveconv\",\r\n\t\t\t\"legadvsol\",\r\n\t\t\t\"leggeo\",\r\n\t\t\t\"legtide\",\r\n\t\t\t\"legadvestore\",\r\n\t\t\t\"legamstor\",\r\n\t\t\t\"leganavaladvgeo\",\r\n\t\t\t\"leganavalmex\",\r\n            \"leganavaleconv\",\r\n\t\t\t\"legaheattank\",\r\n\t\t\t\"leginf\",\r\n\t\t\t\"legshot\",\r\n\t\t\t\"legmrv\",\r\n\t\t\t\"leginfestor\",\r\n\t\t\t\"legvflak\",\r\n\t\t\t\"legflak\",\r\n\t\t\t\"leganavaltorpturret\",\r\n\t\t\t\"legmed\",\r\n            \"legdtr\",\r\n\t\t\t\"legvcarry\",\r\n\t\t\t\"legmg\",\r\n\t\t\t\"legjuno\",\r\n\t\t\t\"legctl\",\r\n\t\t\t\"leganavalaaturret\",\r\n            \"legbastion\",\r\n\t\t\t\"legeyes\",\r\n\t\t\t\"legavrad\",\r\n\t\t\t\"legavjam\",\r\n\t\t\t\"legdrag\",\r\n\t\t\t\"legarad\",\r\n\t\t\t\"legfrad\",\r\n            \"legstronghold\",\r\n            \"legforti\",\r\n\t\t\t\"legfdrag\",\r\n\t\t\t\"leglab\",\r\n\t\t\t\"legvp\",\r\n\t\t\t\"legap\",\r\n\t\t\t\"legsy\",\r\n\t\t\t\"leghp\",\r\n\t\t\t\"legfhp\",\r\n            \"legavantinuke\",\r\n            \"legkeres\",\r\n\t\t\t\"legeshotgunmech\",\r\n\t\t\t\"legnanotc\",\r\n\t\t\t\"legnanotcplat\",\r\n\t\t\t\"legdeflector\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "legmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 10.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "workertimeboost", LuaValue.Number 6.0
                    LuaKey.String "wtboostunittype", LuaValue.String "MOBILE"
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.25
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE BOTCANNON"
                    LuaKey.String "parentsinheritxp", LuaValue.String "MOBILEBUILT DRONE BOTCANNON"
                    LuaKey.String "respawn_announcement", LuaValue.String "A Commander Effigy was sacrificed."
                    LuaKey.String "effigy", LuaValue.String "comeffigylvl5"
                    LuaKey.String "minimum_respawn_stun", LuaValue.Number 5.0
                    LuaKey.String "distance_stun_multiplier", LuaValue.Number 1.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 5.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 44000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 3500.0
                            LuaKey.String "object", LuaValue.String "Units/legcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1750.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 100.0
                            LuaKey.String "areaofeffect", LuaValue.Number 110.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.15
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-t2"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.8
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.3
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "cannon3"
                            LuaKey.String "sprayangle", LuaValue.Number 500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                    LuaKey.String "vtol", LuaValue.Number 250.0
                                ]
                        ]
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.15
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "MK-X Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 425.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 400.0
                                    LuaKey.String "subs", LuaValue.Number 200.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.12
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Railgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 950.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.74 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 26.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                ]
                        ]
                    LuaKey.String "botcannon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.2
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 9.0
                            LuaKey.String "burstrate", LuaValue.Number 0.025
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 5400.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:botrailspawn"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "LegionUnitCapsule.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "mygravity", LuaValue.Number 4.8
                            LuaKey.String "name", LuaValue.String "Long range bot cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "projectiles", LuaValue.Number 2.0
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "sprayangle", LuaValue.Number 2800.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk1xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "bounceSlip", LuaValue.Number 0.74
                            LuaKey.String "bouncerebound", LuaValue.Number 0.5
                            LuaKey.String "numbounce", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "babylegshot babylegheavydrone babylegdrone babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                                    LuaKey.String "spawns_expire", LuaValue.Number 25.0
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "spawns_mode", LuaValue.String "random"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 5.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                    LuaKey.String "shields", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "disintegrator"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT SHIP"
                            LuaKey.String "def", LuaValue.String "BOTCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSHIP"
                        ]
                ]
        ]

    let legcomlvl2 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 30000.0
            LuaKey.String "metalcost", LuaValue.Number 3000.0
            LuaKey.String "builddistance", LuaValue.Number 250.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 112500.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 2100.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "31 57 31"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 25.0
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4999.0
            LuaKey.String "health", LuaValue.Number 6000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 2.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legevocom1.s3o"
            LuaKey.String "pushresistant", LuaValue.Expr "Spring.GetModOptions().pushresistant"
            LuaKey.String "radardistance", LuaValue.Number 800.0
            LuaKey.String "radaremitheight", LuaValue.Number 44.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legevocom1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 500.0
            LuaKey.String "sonardistance", LuaValue.Number 500.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 350.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legsolar\",\r\n\t\t\t\"legwin\",\r\n\t\t\t\"legmstor\",\r\n\t\t\t\"legestor\",\r\n\t\t\t\"legmex\",\r\n\t\t\t\"legeconv\",\r\n\t\t\t\"leglab\",\r\n\t\t\t\"legvp\",\r\n\t\t\t\"legap\",\r\n\t\t\t\"legeyes\",\r\n\t\t\t\"legrad\",\r\n\t\t\t\"legdrag\",\r\n\t\t\t\"leglht\",\r\n\t\t\t\"legrl\",\r\n\t\t\t\"legctl\",\r\n\t\t\t\"legtide\",\r\n\t\t\t\"leguwmstore\",\r\n\t\t\t\"leguwestore\",\r\n\t\t\t\"legfeconv\",\r\n\t\t\t\"legsy\",\r\n\t\t\t\"legfdrag\",\r\n\t\t\t\"legtl\",\r\n\t\t\t\"legfrl\",\r\n\t\t\t\"legfrad\",\r\n\t\t\t\"leghp\",\r\n\t\t\t\"legfhp\",\r\n\t\t\t\"leggob\",\r\n\t\t\t\"leglob\",\r\n\t\t\t\"leghades\",\r\n\t\t\t\"leghelios\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 2.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "legcomlvl3"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 22000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "workertimeboost", LuaValue.Number 3.0
                    LuaKey.String "wtboostunittype", LuaValue.String "MOBILE"
                    LuaKey.String "effigy", LuaValue.String "comeffigylvl1"
                    LuaKey.String "minimum_respawn_stun", LuaValue.Number 5.0
                    LuaKey.String "distance_stun_multiplier", LuaValue.Number 1.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 5.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2000.0
                            LuaKey.String "object", LuaValue.String "Units/legcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1000.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.03
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun6"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 968.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "MK-II Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.6
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                    LuaKey.String "subs", LuaValue.Number 125.0
                                ]
                        ]
                    LuaKey.String "aa_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
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
                            LuaKey.String "model", LuaValue.String "legsmallrocket.s3o"
                            LuaKey.String "name", LuaValue.String "Anti Air Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 6.0
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smokesize", LuaValue.Number 4.6
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 1200.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 150.0
                                    LuaKey.String "commanders", LuaValue.Number 1.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "disintegrator"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "aa_missile"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legcomlvl3 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 40000.0
            LuaKey.String "metalcost", LuaValue.Number 4000.0
            LuaKey.String "builddistance", LuaValue.Number 175.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 150000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "34 63 34"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 75.0
            LuaKey.String "energystorage", LuaValue.Number 1500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 8000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 5.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legevocom1.s3o"
            LuaKey.String "pushresistant", LuaValue.Expr "Spring.GetModOptions().pushresistant"
            LuaKey.String "radardistance", LuaValue.Number 900.0
            LuaKey.String "radaremitheight", LuaValue.Number 49.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legevocom1.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "sonardistance", LuaValue.Number 550.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 400.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legmex\",\r\n\t\t\t\"legsolar\",\r\n\t\t\t\"legwin\",\r\n\t\t\t\"legadvsol\",\r\n\t\t\t\"legeconv\",\r\n\t\t\t\"legmext15\",\r\n\t\t\t\"leggeo\",\r\n\t\t\t\"legtide\",\r\n\t\t\t\"legestor\",\r\n\t\t\t\"legmstor\",\r\n\t\t\t\"leguwestore\",\r\n\t\t\t\"legfeconv\",\r\n\t\t\t\"leguwmstore\",\r\n\t\t\t\"leguwgeo\",\r\n\t\t\t\"leggat\",\r\n\t\t\t\"legbar\",\r\n\t\t\t\"legkark\",\r\n\t\t\t\"legcen\",\r\n\t\t\t\"leginfestor\",\r\n\t\t\t\"legrail\",\r\n\t\t\t\"legmg\",\r\n\t\t\t\"legtl\",\r\n\t\t\t\"leghive\",\r\n\t\t\t\"legdtr\",\r\n\t\t\t\"legrl\",\r\n\t\t\t\"legjuno\",\r\n\t\t\t\"legctl\",\r\n\t\t\t\"legfrl\",\r\n\t\t\t\"legeyes\",\r\n\t\t\t\"legavrad\",\r\n\t\t\t\"legavjam\",\r\n\t\t\t\"legdrag\",\r\n\t\t\t\"legrad\",\r\n\t\t\t\"legfrad\",\r\n            \"legstronghold\",\r\n\t\t\t\"legfdrag\",\r\n\t\t\t\"leglab\",\r\n\t\t\t\"legvp\",\r\n\t\t\t\"legap\",\r\n\t\t\t\"legsy\",\r\n\t\t\t\"leghp\",\r\n\t\t\t\"legfhp\",\r\n\t\t\t\"legnanotc\",\r\n\t\t\t\"legnanotcplat\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 3.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "workertimeboost", LuaValue.Number 3.0
                    LuaKey.String "wtboostunittype", LuaValue.String "MOBILE"
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "legcomlvl4"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 53000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.25
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE BOTCANNON"
                    LuaKey.String "parentsinheritxp", LuaValue.String "MOBILEBUILT DRONE BOTCANNON"
                    LuaKey.String "effigy", LuaValue.String "comeffigylvl2"
                    LuaKey.String "minimum_respawn_stun", LuaValue.Number 5.0
                    LuaKey.String "distance_stun_multiplier", LuaValue.Number 1.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 5.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2750.0
                            LuaKey.String "object", LuaValue.String "Units/legcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1375.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.035
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun6"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 968.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 921.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 30.0
                                ]
                        ]
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "MK-III Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 425.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                    LuaKey.String "subs", LuaValue.Number 125.0
                                ]
                        ]
                    LuaKey.String "aa_missile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
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
                            LuaKey.String "model", LuaValue.String "legsmallrocket.s3o"
                            LuaKey.String "name", LuaValue.String "Anti Air Missile Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.2
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 6.0
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smokesize", LuaValue.Number 4.6
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "packohit"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "packolau"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 1.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa3"
                            LuaKey.String "tolerance", LuaValue.Number 9950.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 68000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 1200.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 150.0
                                    LuaKey.String "commanders", LuaValue.Number 1.0
                                ]
                        ]
                    LuaKey.String "botcannon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.2
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 900.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:botrailspawn"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "LegionUnitCapsule.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "mygravity", LuaValue.Number 4.8
                            LuaKey.String "name", LuaValue.String "Long range bot cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "sprayangle", LuaValue.Number 2800.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 13.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk1xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "bounceSlip", LuaValue.Number 0.74
                            LuaKey.String "bouncerebound", LuaValue.Number 0.5
                            LuaKey.String "numbounce", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleggob babyleglob babyleglob babyleglob babyleglob babyleglob"
                                    LuaKey.String "spawns_expire", LuaValue.Number 25.0
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "spawns_mode", LuaValue.String "random"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 3.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                    LuaKey.String "shields", LuaValue.Number 250.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "disintegrator"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "aa_missile"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT SHIP"
                            LuaKey.String "def", LuaValue.String "BOTCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSHIP"
                        ]
                ]
        ]

    let legcomlvl4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 10.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 50000.0
            LuaKey.String "metalcost", LuaValue.Number 5000.0
            LuaKey.String "builddistance", LuaValue.Number 350.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 187500.0
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 69 37"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 125.0
            LuaKey.String "energystorage", LuaValue.Number 2000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 10000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 9.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legevocom2.s3o"
            LuaKey.String "pushresistant", LuaValue.Expr "Spring.GetModOptions().pushresistant"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 54.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legevocom2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 500.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t \"legmex\",\r\n\t\t\t \"legsolar\",\r\n\t\t\t \"legwin\",\r\n\t\t\t \"legadvsol\",\r\n\t\t\t \"legeconv\",\r\n\t\t\t \"legmext15\",\r\n\t\t\t \"leggeo\",\r\n\t\t\t \"legtide\",\r\n\t\t\t \"legestor\",\r\n\t\t\t \"legmstor\",\r\n\t\t\t \"leguwestore\",\r\n\t\t\t \"legfeconv\",\r\n\t\t\t \"leguwmstore\",\r\n\t\t\t \"leguwgeo\",\r\n\t\t\t \"leggat\",\r\n\t\t\t \"legbart\",\r\n\t\t\t \"legshot\",\r\n\t\t\t \"legstr\",\r\n\t\t\t \"leginfestor\",\r\n\t\t\t \"legvflak\",\r\n\t\t\t \"legflak\",\r\n\t\t\t \"leganavaltorpturret\",\r\n\t\t\t \"legmed\",\r\n        \t \"legdtr\",\r\n\t\t\t \"legvcarry\",\r\n\t\t\t \"legmg\",\r\n\t\t\t \"legjuno\",\r\n\t\t\t \"legctl\",\r\n\t\t\t \"leganavalaaturret\",\r\n\t\t\t \"legeyes\",\r\n\t\t\t \"legavrad\",\r\n\t\t\t \"legavjam\",\r\n\t\t\t \"legdrag\",\r\n\t\t\t \"legarad\",\r\n\t\t\t \"legfrad\",\r\n        \t \"legstronghold\",\r\n        \t \"legforti\",\r\n\t\t\t \"legfdrag\",\r\n\t\t\t \"leglab\",\r\n\t\t\t \"legvp\",\r\n\t\t\t \"legap\",\r\n\t\t\t \"legsy\",\r\n\t\t\t \"leghp\",\r\n\t\t\t \"legfhp\",\r\n\t\t\t \"legavantinuke\",\r\n\t\t\t \"legnanotc\",\r\n\t\t\t \"legnanotcplat\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 4.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "workertimeboost", LuaValue.Number 3.0
                    LuaKey.String "wtboostunittype", LuaValue.String "MOBILE"
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "legcomlvl5"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 105000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.25
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE BOTCANNON"
                    LuaKey.String "parentsinheritxp", LuaValue.String "MOBILEBUILT DRONE BOTCANNON"
                    LuaKey.String "effigy", LuaValue.String "comeffigylvl2"
                    LuaKey.String "minimum_respawn_stun", LuaValue.Number 5.0
                    LuaKey.String "distance_stun_multiplier", LuaValue.Number 1.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 5.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 3500.0
                            LuaKey.String "object", LuaValue.String "Units/legcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 1750.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.04
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun6heavy"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 968.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 999.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 40.0
                                ]
                        ]
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "MK-IV Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 200.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                    LuaKey.String "subs", LuaValue.Number 125.0
                                ]
                        ]
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Railgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.7
                            LuaKey.String "rgbcolor", LuaValue.String "0.74 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 26.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                ]
                        ]
                    LuaKey.String "botcannon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.2
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 1200.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:botrailspawn"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "LegionUnitCapsule.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "mygravity", LuaValue.Number 4.8
                            LuaKey.String "name", LuaValue.String "Long range bot cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "sprayangle", LuaValue.Number 2800.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 12.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk1xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "bounceSlip", LuaValue.Number 0.74
                            LuaKey.String "bouncerebound", LuaValue.Number 0.5
                            LuaKey.String "numbounce", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "babylegdrone babyleggob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                                    LuaKey.String "spawns_expire", LuaValue.Number 25.0
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "spawns_mode", LuaValue.String "random"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 3.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                    LuaKey.String "shields", LuaValue.Number 250.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "disintegrator"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT SHIP"
                            LuaKey.String "def", LuaValue.String "BOTCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSHIP"
                        ]
                ]
        ]

    let legcomlvl5 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 15.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 60000.0
            LuaKey.String "metalcost", LuaValue.Number 6000.0
            LuaKey.String "builddistance", LuaValue.Number 400.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 187500.0
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 69 37"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 200.0
            LuaKey.String "energystorage", LuaValue.Number 3000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "legcomlvl4"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 12000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 39.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 14.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legevocom2.s3o"
            LuaKey.String "pushresistant", LuaValue.Expr "Spring.GetModOptions().pushresistant"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 54.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "reclaimspeed", LuaValue.Number 1995.0
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legevocom2.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 665.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legmoho\",\r\n\t\t\t\"legadvsol\",\r\n\t\t\t\"legwin\",\r\n\t\t\t\"legfus\",\r\n\t\t\t\"legadveconv\",\r\n\t\t\t\"legsolar\",\r\n\t\t\t\"leggeo\",\r\n\t\t\t\"legtide\",\r\n\t\t\t\"legadvestore\",\r\n\t\t\t\"legamstor\",\r\n\t\t\t\"leganavaladvgeo\",\r\n\t\t\t\"leganavalmex\",\r\n        \t\"leganavaleconv\",\r\n\t\t\t\"legaheattank\",\r\n\t\t\t\"leginf\",\r\n\t\t\t\"legshot\",\r\n\t\t\t\"legstr\",\r\n\t\t\t\"leginfestor\",\r\n\t\t\t\"legvflak\",\r\n\t\t\t\"legflak\",\r\n\t\t\t\"leganavaltorpturret\",\r\n\t\t\t\"legmed\",\r\n        \t\"legdtr\",\r\n\t\t\t\"legvcarry\",\r\n\t\t\t\"legmg\",\r\n\t\t\t\"legjuno\",\r\n\t\t\t\"legctl\",\r\n\t\t\t\"leganavalaaturret\",\r\n\t\t\t\"legeyes\",\r\n\t\t\t\"legavrad\",\r\n\t\t\t\"legavjam\",\r\n\t\t\t\"legdrag\",\r\n\t\t\t\"legarad\",\r\n\t\t\t\"legfrad\",\r\n        \t\"legstronghold\",\r\n        \t\"legforti\",\r\n\t\t\t\"legfdrag\",\r\n\t\t\t\"leglab\",\r\n\t\t\t\"legvp\",\r\n\t\t\t\"legap\",\r\n\t\t\t\"legsy\",\r\n\t\t\t\"leghp\",\r\n\t\t\t\"legfhp\",\r\n\t\t\t\"legavantinuke\",\r\n\t\t\t\"legnanotc\",\r\n\t\t\t\"legnanotcplat\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "legmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 5.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "workertimeboost", LuaValue.Number 4.0
                    LuaKey.String "wtboostunittype", LuaValue.String "MOBILE"
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "legcomlvl6"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 260000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.25
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE BOTCANNON"
                    LuaKey.String "parentsinheritxp", LuaValue.String "MOBILEBUILT DRONE BOTCANNON"
                    LuaKey.String "effigy", LuaValue.String "comeffigylvl3"
                    LuaKey.String "minimum_respawn_stun", LuaValue.Number 5.0
                    LuaKey.String "distance_stun_multiplier", LuaValue.Number 1.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 5.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 24000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 3500.0
                            LuaKey.String "object", LuaValue.String "Units/legcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1750.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 7.0
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.066
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.04
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulseboost", LuaValue.Number 0.4
                            LuaKey.String "impulsefactor", LuaValue.Number 1.5
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Machine Gun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "mgun6heavy"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "sprayangle", LuaValue.Number 968.0
                            LuaKey.String "texture1", LuaValue.String "shot"
                            LuaKey.String "texture2", LuaValue.String "empty"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 999.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 50.0
                                ]
                        ]
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "MK-V Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 425.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                    LuaKey.String "subs", LuaValue.Number 125.0
                                ]
                        ]
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Railgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 620.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.7
                            LuaKey.String "rgbcolor", LuaValue.String "0.74 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 26.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "botcannon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.2
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 1800.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:botrailspawn"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "LegionUnitCapsule.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "mygravity", LuaValue.Number 4.8
                            LuaKey.String "name", LuaValue.String "Long range bot cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "sprayangle", LuaValue.Number 2800.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 11.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk1xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "bounceSlip", LuaValue.Number 0.74
                            LuaKey.String "bouncerebound", LuaValue.Number 0.5
                            LuaKey.String "numbounce", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "babylegshot babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                                    LuaKey.String "spawns_expire", LuaValue.Number 25.0
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "spawns_mode", LuaValue.String "random"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 4.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                    LuaKey.String "shields", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "disintegrator"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT SHIP"
                            LuaKey.String "def", LuaValue.String "BOTCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSHIP"
                        ]
                ]
        ]

    let legcomlvl6 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 15.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 70000.0
            LuaKey.String "metalcost", LuaValue.Number 7000.0
            LuaKey.String "builddistance", LuaValue.Number 400.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 187500.0
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 69 37"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 325.0
            LuaKey.String "energystorage", LuaValue.Number 4000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "legcomlvl4"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 14000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 41.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 20.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legevocom3.s3o"
            LuaKey.String "pushresistant", LuaValue.Expr "Spring.GetModOptions().pushresistant"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 54.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "reclaimspeed", LuaValue.Number 2433.0
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legevocom3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 811.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legmoho\",\r\n\t\t\t\"legfus\",\r\n\t\t\t\"legwin\",\r\n\t\t\t\"legadveconv\",\r\n\t\t\t\"legadvsol\",\r\n\t\t\t\"leggeo\",\r\n\t\t\t\"legtide\",\r\n\t\t\t\"legadvestore\",\r\n\t\t\t\"legamstor\",\r\n\t\t\t\"leganavaladvgeo\",\r\n\t\t\t\"leganavalmex\",\r\n            \"leganavaleconv\",\r\n\t\t\t\"legaheattank\",\r\n\t\t\t\"leginf\",\r\n\t\t\t\"legshot\",\r\n\t\t\t\"legmrv\",\r\n\t\t\t\"leginfestor\",\r\n\t\t\t\"legvflak\",\r\n\t\t\t\"legflak\",\r\n\t\t\t\"leganavaltorpturret\",\r\n\t\t\t\"legmed\",\r\n            \"legdtr\",\r\n\t\t\t\"legvcarry\",\r\n\t\t\t\"legmg\",\r\n\t\t\t\"legjuno\",\r\n\t\t\t\"legctl\",\r\n\t\t\t\"leganavalaaturret\",\r\n            \"legbastion\",\r\n\t\t\t\"legeyes\",\r\n\t\t\t\"legavrad\",\r\n\t\t\t\"legavjam\",\r\n\t\t\t\"legdrag\",\r\n\t\t\t\"legarad\",\r\n\t\t\t\"legfrad\",\r\n            \"legstronghold\",\r\n            \"legforti\",\r\n\t\t\t\"legfdrag\",\r\n\t\t\t\"leglab\",\r\n\t\t\t\"legvp\",\r\n\t\t\t\"legap\",\r\n\t\t\t\"legsy\",\r\n\t\t\t\"leghp\",\r\n\t\t\t\"legfhp\",\r\n            \"legavantinuke\",\r\n            \"legkeres\",\r\n\t\t\t\"legnanotc\",\r\n\t\t\t\"legnanotcplat\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "legmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 6.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "workertimeboost", LuaValue.Number 4.0
                    LuaKey.String "wtboostunittype", LuaValue.String "MOBILE"
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "legcomlvl7"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 390000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.25
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE BOTCANNON"
                    LuaKey.String "parentsinheritxp", LuaValue.String "MOBILEBUILT DRONE BOTCANNON"
                    LuaKey.String "effigy", LuaValue.String "comeffigylvl3"
                    LuaKey.String "minimum_respawn_stun", LuaValue.Number 5.0
                    LuaKey.String "distance_stun_multiplier", LuaValue.Number 1.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 5.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 28000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 3500.0
                            LuaKey.String "object", LuaValue.String "Units/legcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1750.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 100.0
                            LuaKey.String "areaofeffect", LuaValue.Number 90.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-t2"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.8
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 425.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.35
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "cannon3"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 360.0
                                    LuaKey.String "vtol", LuaValue.Number 200.0
                                ]
                        ]
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "MK-VI Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 425.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                    LuaKey.String "subs", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.15
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Railgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 730.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.7
                            LuaKey.String "rgbcolor", LuaValue.String "0.74 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 26.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "botcannon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.2
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 7.0
                            LuaKey.String "burstrate", LuaValue.Number 0.05
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 2100.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:botrailspawn"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "LegionUnitCapsule.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "mygravity", LuaValue.Number 4.8
                            LuaKey.String "name", LuaValue.String "Long range bot cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "sprayangle", LuaValue.Number 2800.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk1xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "bounceSlip", LuaValue.Number 0.74
                            LuaKey.String "bouncerebound", LuaValue.Number 0.5
                            LuaKey.String "numbounce", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "babylegshot babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                                    LuaKey.String "spawns_expire", LuaValue.Number 25.0
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "spawns_mode", LuaValue.String "random"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 4.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                    LuaKey.String "shields", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "disintegrator"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT SHIP"
                            LuaKey.String "def", LuaValue.String "BOTCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSHIP"
                        ]
                ]
        ]

    let legcomlvl7 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 20.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 80000.0
            LuaKey.String "metalcost", LuaValue.Number 8000.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 192000.0
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 69 37"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 525.0
            LuaKey.String "energystorage", LuaValue.Number 5000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "legcomlvl4"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 16000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 43.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 27.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legevocom3.s3o"
            LuaKey.String "pushresistant", LuaValue.Expr "Spring.GetModOptions().pushresistant"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 54.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "reclaimspeed", LuaValue.Number 2967.0
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legevocom3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 989.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legmoho\",\r\n\t\t\t\"legfus\",\r\n\t\t\t\"legwin\",\r\n\t\t\t\"legadveconv\",\r\n\t\t\t\"legadvsol\",\r\n\t\t\t\"leggeo\",\r\n\t\t\t\"legtide\",\r\n\t\t\t\"legadvestore\",\r\n\t\t\t\"legamstor\",\r\n\t\t\t\"leganavaladvgeo\",\r\n\t\t\t\"leganavalmex\",\r\n            \"leganavaleconv\",\r\n\t\t\t\"legaheattank\",\r\n\t\t\t\"leginf\",\r\n\t\t\t\"legshot\",\r\n\t\t\t\"legmrv\",\r\n\t\t\t\"leginfestor\",\r\n\t\t\t\"legvflak\",\r\n\t\t\t\"legflak\",\r\n\t\t\t\"leganavaltorpturret\",\r\n\t\t\t\"legmed\",\r\n            \"legdtr\",\r\n\t\t\t\"legvcarry\",\r\n\t\t\t\"legmg\",\r\n\t\t\t\"legjuno\",\r\n\t\t\t\"legctl\",\r\n\t\t\t\"leganavalaaturret\",\r\n            \"legbastion\",\r\n\t\t\t\"legeyes\",\r\n\t\t\t\"legavrad\",\r\n\t\t\t\"legavjam\",\r\n\t\t\t\"legdrag\",\r\n\t\t\t\"legarad\",\r\n\t\t\t\"legfrad\",\r\n            \"legstronghold\",\r\n            \"legforti\",\r\n\t\t\t\"legfdrag\",\r\n\t\t\t\"leglab\",\r\n\t\t\t\"legvp\",\r\n\t\t\t\"legap\",\r\n\t\t\t\"legsy\",\r\n\t\t\t\"leghp\",\r\n\t\t\t\"legfhp\",\r\n            \"legavantinuke\",\r\n            \"legkeres\",\r\n\t\t\t\"legnanotc\",\r\n\t\t\t\"legnanotcplat\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "legmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 7.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "workertimeboost", LuaValue.Number 5.0
                    LuaKey.String "wtboostunittype", LuaValue.String "MOBILE"
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "legcomlvl8"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 520000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.25
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE BOTCANNON"
                    LuaKey.String "parentsinheritxp", LuaValue.String "MOBILEBUILT DRONE BOTCANNON"
                    LuaKey.String "effigy", LuaValue.String "comeffigylvl4"
                    LuaKey.String "minimum_respawn_stun", LuaValue.Number 5.0
                    LuaKey.String "distance_stun_multiplier", LuaValue.Number 1.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 5.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 32000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 3500.0
                            LuaKey.String "object", LuaValue.String "Units/legcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1750.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 100.0
                            LuaKey.String "areaofeffect", LuaValue.Number 90.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-t2"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.8
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 425.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.3
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "cannon3"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 400.0
                                    LuaKey.String "vtol", LuaValue.Number 225.0
                                ]
                        ]
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "MK-VII Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 425.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                    LuaKey.String "subs", LuaValue.Number 150.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.12
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Railgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 730.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.6
                            LuaKey.String "rgbcolor", LuaValue.String "0.74 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 26.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 250.0
                                ]
                        ]
                    LuaKey.String "botcannon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.2
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 8.0
                            LuaKey.String "burstrate", LuaValue.Number 0.05
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 2400.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:botrailspawn"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "LegionUnitCapsule.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "mygravity", LuaValue.Number 4.8
                            LuaKey.String "name", LuaValue.String "Long range bot cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "sprayangle", LuaValue.Number 2800.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk1xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "bounceSlip", LuaValue.Number 0.74
                            LuaKey.String "bouncerebound", LuaValue.Number 0.5
                            LuaKey.String "numbounce", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "babylegshot babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                                    LuaKey.String "spawns_expire", LuaValue.Number 25.0
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "spawns_mode", LuaValue.String "random"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 4.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                    LuaKey.String "shields", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "disintegrator"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT SHIP"
                            LuaKey.String "def", LuaValue.String "BOTCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSHIP"
                        ]
                ]
        ]

    let legcomlvl8 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 25.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 90000.0
            LuaKey.String "metalcost", LuaValue.Number 9000.0
            LuaKey.String "builddistance", LuaValue.Number 500.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 216000.0
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 69 37"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 850.0
            LuaKey.String "energystorage", LuaValue.Number 6500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "legcomlvl4"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 18000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 45.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 34.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legevocom3.s3o"
            LuaKey.String "pushresistant", LuaValue.Expr "Spring.GetModOptions().pushresistant"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 54.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "reclaimspeed", LuaValue.Number 3621.0
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legevocom3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 1207.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legmoho\",\r\n\t\t\t\"legfus\",\r\n\t\t\t\"legwin\",\r\n\t\t\t\"legadveconv\",\r\n\t\t\t\"legadvsol\",\r\n\t\t\t\"leggeo\",\r\n\t\t\t\"legtide\",\r\n\t\t\t\"legadvestore\",\r\n\t\t\t\"legamstor\",\r\n\t\t\t\"leganavaladvgeo\",\r\n\t\t\t\"leganavalmex\",\r\n            \"leganavaleconv\",\r\n\t\t\t\"legaheattank\",\r\n\t\t\t\"leginf\",\r\n\t\t\t\"legshot\",\r\n\t\t\t\"legmrv\",\r\n\t\t\t\"leginfestor\",\r\n\t\t\t\"legvflak\",\r\n\t\t\t\"legflak\",\r\n\t\t\t\"leganavaltorpturret\",\r\n\t\t\t\"legmed\",\r\n            \"legdtr\",\r\n\t\t\t\"legvcarry\",\r\n\t\t\t\"legmg\",\r\n\t\t\t\"legjuno\",\r\n\t\t\t\"legctl\",\r\n\t\t\t\"leganavalaaturret\",\r\n            \"legbastion\",\r\n\t\t\t\"legeyes\",\r\n\t\t\t\"legavrad\",\r\n\t\t\t\"legavjam\",\r\n\t\t\t\"legdrag\",\r\n\t\t\t\"legarad\",\r\n\t\t\t\"legfrad\",\r\n            \"legstronghold\",\r\n            \"legforti\",\r\n\t\t\t\"legfdrag\",\r\n\t\t\t\"leglab\",\r\n\t\t\t\"legvp\",\r\n\t\t\t\"legap\",\r\n\t\t\t\"legsy\",\r\n\t\t\t\"leghp\",\r\n\t\t\t\"legfhp\",\r\n            \"legavantinuke\",\r\n            \"legkeres\",\r\n\t\t\t\"legnanotc\",\r\n\t\t\t\"legnanotcplat\",\r\n\t\t\t\"legdeflector\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "legmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 8.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "workertimeboost", LuaValue.Number 5.0
                    LuaKey.String "wtboostunittype", LuaValue.String "MOBILE"
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "legcomlvl9"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 660000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.25
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE BOTCANNON"
                    LuaKey.String "parentsinheritxp", LuaValue.String "MOBILEBUILT DRONE BOTCANNON"
                    LuaKey.String "effigy", LuaValue.String "comeffigylvl4"
                    LuaKey.String "minimum_respawn_stun", LuaValue.Number 5.0
                    LuaKey.String "distance_stun_multiplier", LuaValue.Number 1.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 5.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 36000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 3500.0
                            LuaKey.String "object", LuaValue.String "Units/legcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1750.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 100.0
                            LuaKey.String "areaofeffect", LuaValue.Number 100.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-t2"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.8
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "cannon3"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 475.0
                                    LuaKey.String "vtol", LuaValue.Number 235.0
                                ]
                        ]
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "MK-VIII Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 425.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 350.0
                                    LuaKey.String "subs", LuaValue.Number 175.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.12
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Railgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.4
                            LuaKey.String "rgbcolor", LuaValue.String "0.74 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 26.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                ]
                        ]
                    LuaKey.String "botcannon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.2
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 5.0
                            LuaKey.String "burstrate", LuaValue.Number 0.025
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 3000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:botrailspawn"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "LegionUnitCapsule.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "mygravity", LuaValue.Number 4.8
                            LuaKey.String "name", LuaValue.String "Long range bot cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "projectiles", LuaValue.Number 2.0
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "sprayangle", LuaValue.Number 2800.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk1xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "bounceSlip", LuaValue.Number 0.74
                            LuaKey.String "bouncerebound", LuaValue.Number 0.5
                            LuaKey.String "numbounce", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "babylegshot babylegdrone babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                                    LuaKey.String "spawns_expire", LuaValue.Number 25.0
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "spawns_mode", LuaValue.String "random"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 5.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                    LuaKey.String "shields", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "disintegrator"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT SHIP"
                            LuaKey.String "def", LuaValue.String "BOTCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSHIP"
                        ]
                ]
        ]

    let legcomlvl9 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 30.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 100000.0
            LuaKey.String "metalcost", LuaValue.Number 10000.0
            LuaKey.String "builddistance", LuaValue.Number 600.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 240000.0
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "37 69 37"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 1375.0
            LuaKey.String "energystorage", LuaValue.Number 8000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "legcomlvl4"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 20000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 47.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 42.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/legevocom3.s3o"
            LuaKey.String "pushresistant", LuaValue.Expr "Spring.GetModOptions().pushresistant"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 54.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "reclaimspeed", LuaValue.Number 4416.0
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legevocom3.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 1472.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"legmoho\",\r\n\t\t\t\"legfus\",\r\n\t\t\t\"legwin\",\r\n\t\t\t\"legadveconv\",\r\n\t\t\t\"legadvsol\",\r\n\t\t\t\"leggeo\",\r\n\t\t\t\"legtide\",\r\n\t\t\t\"legadvestore\",\r\n\t\t\t\"legamstor\",\r\n\t\t\t\"leganavaladvgeo\",\r\n\t\t\t\"leganavalmex\",\r\n            \"leganavaleconv\",\r\n\t\t\t\"legaheattank\",\r\n\t\t\t\"leginf\",\r\n\t\t\t\"legshot\",\r\n\t\t\t\"legmrv\",\r\n\t\t\t\"leginfestor\",\r\n\t\t\t\"legvflak\",\r\n\t\t\t\"legflak\",\r\n\t\t\t\"leganavaltorpturret\",\r\n\t\t\t\"legmed\",\r\n            \"legdtr\",\r\n\t\t\t\"legvcarry\",\r\n\t\t\t\"legmg\",\r\n\t\t\t\"legjuno\",\r\n\t\t\t\"legctl\",\r\n\t\t\t\"leganavalaaturret\",\r\n            \"legbastion\",\r\n\t\t\t\"legeyes\",\r\n\t\t\t\"legavrad\",\r\n\t\t\t\"legavjam\",\r\n\t\t\t\"legdrag\",\r\n\t\t\t\"legarad\",\r\n\t\t\t\"legfrad\",\r\n            \"legstronghold\",\r\n            \"legforti\",\r\n\t\t\t\"legfdrag\",\r\n\t\t\t\"leglab\",\r\n\t\t\t\"legvp\",\r\n\t\t\t\"legap\",\r\n\t\t\t\"legsy\",\r\n\t\t\t\"leghp\",\r\n\t\t\t\"legfhp\",\r\n            \"legavantinuke\",\r\n            \"legkeres\",\r\n\t\t\t\"legeshotgunmech\",\r\n\t\t\t\"legnanotc\",\r\n\t\t\t\"legnanotcplat\",\r\n\t\t\t\"legdeflector\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "legmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 9.0
                    LuaKey.String "model_author", LuaValue.String "Tharsis"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/leg_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "workertimeboost", LuaValue.Number 6.0
                    LuaKey.String "wtboostunittype", LuaValue.String "MOBILE"
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "legcomlvl10"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 800000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.25
                    LuaKey.String "childreninheritxp", LuaValue.String "DRONE BOTCANNON"
                    LuaKey.String "parentsinheritxp", LuaValue.String "MOBILEBUILT DRONE BOTCANNON"
                    LuaKey.String "effigy", LuaValue.String "comeffigylvl5"
                    LuaKey.String "minimum_respawn_stun", LuaValue.Number 5.0
                    LuaKey.String "distance_stun_multiplier", LuaValue.Number 1.0
                    LuaKey.String "fall_damage_multiplier", LuaValue.Number 5.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "47 10 47"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 40000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 3500.0
                            LuaKey.String "object", LuaValue.String "Units/legcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1750.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:com_sea_laser_bubbles"
                            LuaKey.Int 2, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 3, LuaValue.String "custom:footstep-medium"
                            LuaKey.Int 4, LuaValue.String "custom:barrelshot-tiny"
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath1"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture1"
                    LuaKey.String "cloak", LuaValue.String "kloak1"
                    LuaKey.String "repair", LuaValue.String "repair1"
                    LuaKey.String "uncloak", LuaValue.String "kloak1un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "armcomsel"
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
                            LuaKey.Int 1, LuaValue.String "armcom1"
                            LuaKey.Int 2, LuaValue.String "armcom2"
                            LuaKey.Int 3, LuaValue.String "armcom3"
                            LuaKey.Int 4, LuaValue.String "armcom4"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "armcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armmg_weapon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 100.0
                            LuaKey.String "areaofeffect", LuaValue.Number 110.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 2.0
                            LuaKey.String "burstrate", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-t2"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.8
                            LuaKey.String "name", LuaValue.String "Rapid-Fire Plasma Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "cannon3"
                            LuaKey.String "sprayangle", LuaValue.Number 500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 500.0
                                    LuaKey.String "vtol", LuaValue.Number 250.0
                                ]
                        ]
                    LuaKey.String "torpedo", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 75.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.15
                            LuaKey.String "cegtag", LuaValue.String "torpedotrail-tiny"
                            LuaKey.String "collidefriendly", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.55
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-uw"
                            LuaKey.String "flighttime", LuaValue.Number 1.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "legtorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "MK-IX Torpedo Launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 230.0
                            LuaKey.String "tracks", LuaValue.Bool false
                            LuaKey.String "turnrate", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 50.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 425.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 350.0
                                    LuaKey.String "subs", LuaValue.Number 175.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "avoidground", LuaValue.Bool false
                            LuaKey.String "bouncerebound", LuaValue.Number 0.0
                            LuaKey.String "cegtag", LuaValue.String "dgunprojectile"
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.15
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 500.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:expldgun"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "name", LuaValue.String "Disintegrator"
                            LuaKey.String "noexplode", LuaValue.Bool true
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 250.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "soundhit", LuaValue.String "xplomas2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "railgunt2", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 4.0
                            LuaKey.String "burstrate", LuaValue.Number 0.12
                            LuaKey.String "cegtag", LuaValue.String "railgun"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.12
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.85
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:plasmahit-sparkonly"
                            LuaKey.String "fallOffRate", LuaValue.Number 0.2
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.0
                            LuaKey.String "intensity", LuaValue.Number 0.8
                            LuaKey.String "minintensity", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "Railgun"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 870.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.2
                            LuaKey.String "rgbcolor", LuaValue.String "0.74 0.64 0.94"
                            LuaKey.String "soundhit", LuaValue.String "mavgun3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lancefire"
                            LuaKey.String "soundstartvolume", LuaValue.Number 26.0
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 3000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 400.0
                                ]
                        ]
                    LuaKey.String "botcannon", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 0.2
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burst", LuaValue.Number 7.0
                            LuaKey.String "burstrate", LuaValue.Number 0.025
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 116.0
                            LuaKey.String "craterboost", LuaValue.Number 0.1
                            LuaKey.String "cratermult", LuaValue.Number 0.1
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 4200.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:botrailspawn"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 8.0
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "leadbonus", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "LegionUnitCapsule.s3o"
                            LuaKey.String "movingaccuracy", LuaValue.Number 600.0
                            LuaKey.String "mygravity", LuaValue.Number 4.8
                            LuaKey.String "name", LuaValue.String "Long range bot cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "projectiles", LuaValue.Number 2.0
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.9
                            LuaKey.String "sprayangle", LuaValue.Number 2800.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "soundhit", LuaValue.String "xplonuk1xs"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "lrpcshot3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 50.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "waterbounce", LuaValue.Bool true
                            LuaKey.String "bounceSlip", LuaValue.Number 0.74
                            LuaKey.String "bouncerebound", LuaValue.Number 0.5
                            LuaKey.String "numbounce", LuaValue.Number 10.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spawns_name", LuaValue.String "babylegshot babylegheavydrone babylegdrone babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob babyleglob"
                                    LuaKey.String "spawns_expire", LuaValue.Number 25.0
                                    LuaKey.String "spawns_surface", LuaValue.String "LAND"
                                    LuaKey.String "spawns_mode", LuaValue.String "random"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 5.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                    LuaKey.String "shields", LuaValue.Number 250.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMMG_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "disintegrator"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "RAILGUNT2"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT SHIP"
                            LuaKey.String "def", LuaValue.String "BOTCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSHIP"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "legcomlvl10", legcomlvl10
            "legcomlvl2", legcomlvl2
            "legcomlvl3", legcomlvl3
            "legcomlvl4", legcomlvl4
            "legcomlvl5", legcomlvl5
            "legcomlvl6", legcomlvl6
            "legcomlvl7", legcomlvl7
            "legcomlvl8", legcomlvl8
            "legcomlvl9", legcomlvl9
        ]
