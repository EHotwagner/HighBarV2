// Auto-generated BAR unit data: Legion/Other/Commanders
namespace BarData.Units

open BarData

module Legion_Other_Commanders =

    let legcomecon =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "builddistance", LuaValue.Number 300.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOMECON.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 150.0
            LuaKey.String "energystorage", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4999.0
            LuaKey.String "health", LuaValue.Number 3350.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 24.99
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 5.0
            LuaKey.String "metalstorage", LuaValue.Number 1500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGCOM.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legcom.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 500.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsolar"
                    LuaKey.Int 2, LuaValue.String "armwin"
                    LuaKey.Int 3, LuaValue.String "armmstor"
                    LuaKey.Int 4, LuaValue.String "armestor"
                    LuaKey.Int 5, LuaValue.String "legmex"
                    LuaKey.Int 6, LuaValue.String "armmakr"
                    LuaKey.Int 7, LuaValue.String "leglab"
                    LuaKey.Int 8, LuaValue.String "legvp"
                    LuaKey.Int 9, LuaValue.String "armap"
                    LuaKey.Int 10, LuaValue.String "armeyes"
                    LuaKey.Int 11, LuaValue.String "armrad"
                    LuaKey.Int 12, LuaValue.String "armdrag"
                    LuaKey.Int 13, LuaValue.String "armllt"
                    LuaKey.Int 14, LuaValue.String "armrl"
                    LuaKey.Int 15, LuaValue.String "armdl"
                    LuaKey.Int 16, LuaValue.String "armtide"
                    LuaKey.Int 17, LuaValue.String "armuwms"
                    LuaKey.Int 18, LuaValue.String "armuwes"
                    LuaKey.Int 20, LuaValue.String "armfmkr"
                    LuaKey.Int 21, LuaValue.String "armsy"
                    LuaKey.Int 22, LuaValue.String "armfdrag"
                    LuaKey.Int 23, LuaValue.String "armtl"
                    LuaKey.Int 24, LuaValue.String "armfrt"
                    LuaKey.Int 25, LuaValue.String "armfrad"
                    LuaKey.Int 26, LuaValue.String "armhp"
                    LuaKey.Int 27, LuaValue.String "armfhp"
                    LuaKey.Int 28, LuaValue.String "armadvsol"
                    LuaKey.Int 29, LuaValue.String "legmext15"
                    LuaKey.Int 30, LuaValue.String "armnanotc"
                    LuaKey.Int 31, LuaValue.String "armferret"
                    LuaKey.Int 32, LuaValue.String "armgeo"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
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
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
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
                    LuaKey.String "corlevlr_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 144.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.8
                            LuaKey.String "name", LuaValue.String "RiotCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 280.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.4
                            LuaKey.String "soundhit", LuaValue.String "corlevlrhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "corlevlr"
                            LuaKey.String "soundhitvolume", LuaValue.Number 11.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 13.0
                            LuaKey.String "separation", LuaValue.Number 2.0
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "sizeDecay", LuaValue.Number 0.08
                            LuaKey.String "stages", LuaValue.Number 12.0
                            LuaKey.String "alphaDecay", LuaValue.Number 0.1
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 550.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 190.0
                                    LuaKey.String "subs", LuaValue.Number 70.0
                                    LuaKey.String "vtol", LuaValue.Number 27.0
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
                            LuaKey.String "model", LuaValue.String "cortorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Level1TorpedoLauncher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
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
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 200.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.25
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "airbomb.s3o"
                            LuaKey.String "name", LuaValue.String "EMP Grenade"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "EMGPULS1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 0.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10000.0
                                ]
                        ]
                    LuaKey.String "ferret_missile", LuaValue.Table [
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
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Pop-up rapid-fire g2a missile launcher"
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
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORLEVLR_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legcomoff =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 10.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "builddistance", LuaValue.Number 200.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOMOFF.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 25.0
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4999.0
            LuaKey.String "health", LuaValue.Number 3350.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 42.498
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 2.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGCOMOFF.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legcomoff.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 300.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsolar"
                    LuaKey.Int 2, LuaValue.String "armwin"
                    LuaKey.Int 3, LuaValue.String "armmstor"
                    LuaKey.Int 4, LuaValue.String "armestor"
                    LuaKey.Int 5, LuaValue.String "legmex"
                    LuaKey.Int 6, LuaValue.String "armmakr"
                    LuaKey.Int 7, LuaValue.String "leglab"
                    LuaKey.Int 8, LuaValue.String "legvp"
                    LuaKey.Int 9, LuaValue.String "armap"
                    LuaKey.Int 10, LuaValue.String "armeyes"
                    LuaKey.Int 11, LuaValue.String "armrad"
                    LuaKey.Int 12, LuaValue.String "armdrag"
                    LuaKey.Int 13, LuaValue.String "armllt"
                    LuaKey.Int 14, LuaValue.String "armrl"
                    LuaKey.Int 15, LuaValue.String "armdl"
                    LuaKey.Int 16, LuaValue.String "armtide"
                    LuaKey.Int 17, LuaValue.String "armuwms"
                    LuaKey.Int 18, LuaValue.String "armuwes"
                    LuaKey.Int 20, LuaValue.String "armfmkr"
                    LuaKey.Int 21, LuaValue.String "armsy"
                    LuaKey.Int 22, LuaValue.String "armfdrag"
                    LuaKey.Int 23, LuaValue.String "armtl"
                    LuaKey.Int 24, LuaValue.String "armfrt"
                    LuaKey.Int 25, LuaValue.String "armfrad"
                    LuaKey.Int 26, LuaValue.String "armhp"
                    LuaKey.Int 27, LuaValue.String "armfhp"
                    LuaKey.Int 28, LuaValue.String "leggob"
                    LuaKey.Int 29, LuaValue.String "corjamt"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
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
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
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
                            LuaKey.String "burstrate", LuaValue.Number 0.0675
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
                            LuaKey.String "name", LuaValue.String "Rapid-fire a2g machine guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "minigun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "sprayangle", LuaValue.Number 1200.0
                            LuaKey.String "thickness", LuaValue.Number 0.91
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 13.0
                                    LuaKey.String "default", LuaValue.Number 26.0
                                    LuaKey.String "vtol", LuaValue.Number 26.0
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
                            LuaKey.String "model", LuaValue.String "cortorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Level1TorpedoLauncher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
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
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 200.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.25
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "airbomb.s3o"
                            LuaKey.String "name", LuaValue.String "EMP Grenade"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "EMGPULS1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 0.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10000.0
                                ]
                        ]
                    LuaKey.String "ferret_missile", LuaValue.Table [
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
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Pop-up rapid-fire g2a missile launcher"
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
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let legcomt2com =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.12
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 15.0
            LuaKey.String "maxdec", LuaValue.Number 0.6
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "builddistance", LuaValue.Number 200.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOMT2COM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 4 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "36 67 36"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 25.0
            LuaKey.String "energystorage", LuaValue.Number 500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 10000.0
            LuaKey.String "health", LuaValue.Number 6700.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 30.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 2.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGCOMT2COM.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legcomt2com.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 800.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 400.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsolar"
                    LuaKey.Int 2, LuaValue.String "armwin"
                    LuaKey.Int 3, LuaValue.String "armmstor"
                    LuaKey.Int 4, LuaValue.String "armestor"
                    LuaKey.Int 5, LuaValue.String "legmex"
                    LuaKey.Int 6, LuaValue.String "armmakr"
                    LuaKey.Int 7, LuaValue.String "leglab"
                    LuaKey.Int 8, LuaValue.String "legvp"
                    LuaKey.Int 9, LuaValue.String "armap"
                    LuaKey.Int 10, LuaValue.String "armeyes"
                    LuaKey.Int 11, LuaValue.String "armrad"
                    LuaKey.Int 12, LuaValue.String "armdrag"
                    LuaKey.Int 13, LuaValue.String "armllt"
                    LuaKey.Int 14, LuaValue.String "armrl"
                    LuaKey.Int 15, LuaValue.String "armdl"
                    LuaKey.Int 16, LuaValue.String "armtide"
                    LuaKey.Int 17, LuaValue.String "armuwms"
                    LuaKey.Int 18, LuaValue.String "armuwes"
                    LuaKey.Int 20, LuaValue.String "armfmkr"
                    LuaKey.Int 21, LuaValue.String "armsy"
                    LuaKey.Int 22, LuaValue.String "armfdrag"
                    LuaKey.Int 23, LuaValue.String "armtl"
                    LuaKey.Int 24, LuaValue.String "armfrt"
                    LuaKey.Int 25, LuaValue.String "armfrad"
                    LuaKey.Int 26, LuaValue.String "armhp"
                    LuaKey.Int 27, LuaValue.String "armfhp"
                    LuaKey.Int 28, LuaValue.String "leggob"
                    LuaKey.Int 29, LuaValue.String "corjamt"
                    LuaKey.Int 30, LuaValue.String "legmg"
                    LuaKey.Int 31, LuaValue.String "armferret"
                    LuaKey.Int 32, LuaValue.String "armnanotc"
                    LuaKey.Int 33, LuaValue.String "legmext15"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
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
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
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
                            LuaKey.String "burstrate", LuaValue.Number 0.033
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
                            LuaKey.String "name", LuaValue.String "Rapid-fire a2g machine guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.2
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "minigun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "sprayangle", LuaValue.Number 1200.0
                            LuaKey.String "thickness", LuaValue.Number 0.91
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 10.0
                                    LuaKey.String "default", LuaValue.Number 20.0
                                    LuaKey.String "vtol", LuaValue.Number 20.0
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
                            LuaKey.String "model", LuaValue.String "cortorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Level1TorpedoLauncher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
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
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 200.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.25
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "airbomb.s3o"
                            LuaKey.String "name", LuaValue.String "EMP Grenade"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "EMGPULS1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 0.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10000.0
                                ]
                        ]
                    LuaKey.String "ferret_missile", LuaValue.Table [
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
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Pop-up rapid-fire g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
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
                    LuaKey.String "adv_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 90.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-simple"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-small-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "flighttime", LuaValue.Number 3.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cormissile2.s3o"
                            LuaKey.String "name", LuaValue.String "Parabolic trajectory g2g multi-rocket launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.25
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 7.0
                            LuaKey.String "smoketime", LuaValue.Number 21.0
                            LuaKey.String "smokesize", LuaValue.Number 6.5
                            LuaKey.String "smokecolor", LuaValue.Number 0.5
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "rockhit3"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "rocksalvo"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "startvelocity", LuaValue.Number 80.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.2
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "trajectoryheight", LuaValue.Number 1.0
                            LuaKey.String "turnrate", LuaValue.Number 2000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 70.0
                            LuaKey.String "weapontimer", LuaValue.Number 6.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 450.0
                            LuaKey.String "wobble", LuaValue.Number 2500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
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
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ADV_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let legcomt2def =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 10.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "builddistance", LuaValue.Number 300.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOMT2DEF.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 150.0
            LuaKey.String "energystorage", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4999.0
            LuaKey.String "health", LuaValue.Number 4450.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 5.0
            LuaKey.String "metalstorage", LuaValue.Number 1500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGCOM.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legcom.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 500.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsolar"
                    LuaKey.Int 2, LuaValue.String "armwin"
                    LuaKey.Int 3, LuaValue.String "armmstor"
                    LuaKey.Int 4, LuaValue.String "armestor"
                    LuaKey.Int 5, LuaValue.String "legmex"
                    LuaKey.Int 6, LuaValue.String "armmakr"
                    LuaKey.Int 7, LuaValue.String "leglab"
                    LuaKey.Int 8, LuaValue.String "legvp"
                    LuaKey.Int 9, LuaValue.String "armap"
                    LuaKey.Int 10, LuaValue.String "armeyes"
                    LuaKey.Int 11, LuaValue.String "armrad"
                    LuaKey.Int 12, LuaValue.String "armdrag"
                    LuaKey.Int 13, LuaValue.String "armllt"
                    LuaKey.Int 14, LuaValue.String "armrl"
                    LuaKey.Int 15, LuaValue.String "armdl"
                    LuaKey.Int 16, LuaValue.String "armtide"
                    LuaKey.Int 17, LuaValue.String "armuwms"
                    LuaKey.Int 18, LuaValue.String "armuwes"
                    LuaKey.Int 20, LuaValue.String "armfmkr"
                    LuaKey.Int 21, LuaValue.String "armsy"
                    LuaKey.Int 22, LuaValue.String "armfdrag"
                    LuaKey.Int 23, LuaValue.String "armtl"
                    LuaKey.Int 24, LuaValue.String "armfrt"
                    LuaKey.Int 25, LuaValue.String "armfrad"
                    LuaKey.Int 26, LuaValue.String "armhp"
                    LuaKey.Int 27, LuaValue.String "armfhp"
                    LuaKey.Int 28, LuaValue.String "legmg"
                    LuaKey.Int 29, LuaValue.String "armclaw"
                    LuaKey.Int 30, LuaValue.String "armferret"
                    LuaKey.Int 31, LuaValue.String "legmext15"
                    LuaKey.Int 32, LuaValue.String "corjamt"
                    LuaKey.Int 33, LuaValue.String "armguard"
                    LuaKey.Int 34, LuaValue.String "armcir"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 1900.0
                    LuaKey.String "shield_radius", LuaValue.Number 150.0
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
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
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
                    LuaKey.String "corlevlr_weapon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 144.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "impulsefactor", LuaValue.Number 1.8
                            LuaKey.String "name", LuaValue.String "RiotCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 315.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.8
                            LuaKey.String "soundhit", LuaValue.String "corlevlrhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "corlevlr"
                            LuaKey.String "soundhitvolume", LuaValue.Number 11.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 13.0
                            LuaKey.String "separation", LuaValue.Number 2.0
                            LuaKey.String "nogap", LuaValue.Bool false
                            LuaKey.String "sizeDecay", LuaValue.Number 0.08
                            LuaKey.String "stages", LuaValue.Number 12.0
                            LuaKey.String "alphaDecay", LuaValue.Number 0.1
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 550.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 190.0
                                    LuaKey.String "subs", LuaValue.Number 70.0
                                    LuaKey.String "vtol", LuaValue.Number 27.0
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
                            LuaKey.String "model", LuaValue.String "cortorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Level1TorpedoLauncher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
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
                    LuaKey.String "ferret_missile", LuaValue.Table [
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
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Pop-up rapid-fire g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
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
                    LuaKey.String "empgrenade", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 200.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.25
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.001
                            LuaKey.String "model", LuaValue.String "airbomb.s3o"
                            LuaKey.String "name", LuaValue.String "EMP Grenade"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "EMGPULS1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 240.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10000.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 150.0
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
                                    LuaKey.String "force", LuaValue.Number 1.5
                                    LuaKey.String "intercepttype", LuaValue.Number 1.0
                                    LuaKey.String "power", LuaValue.Number 1900.0
                                    LuaKey.String "powerregen", LuaValue.Number 50.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 100.0
                                    LuaKey.String "radius", LuaValue.Number 150.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 300.0
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
                            LuaKey.String "def", LuaValue.String "CORLEVLR_WEAPON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "TORPEDO"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMPGRENADE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let legcomt2off =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 10.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 26000.0
            LuaKey.String "metalcost", LuaValue.Number 2700.0
            LuaKey.String "builddistance", LuaValue.Number 300.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "LEGCOMT2OFF.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 150.0
            LuaKey.String "energystorage", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4999.0
            LuaKey.String "health", LuaValue.Number 4450.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 47.499
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 5.0
            LuaKey.String "metalstorage", LuaValue.Number 1500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/LEGCOMOFF.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "radardistancejam", LuaValue.Number 100.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/legcomoff.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderexplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1148.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 500.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "armsolar"
                    LuaKey.Int 2, LuaValue.String "armwin"
                    LuaKey.Int 3, LuaValue.String "armmstor"
                    LuaKey.Int 4, LuaValue.String "armestor"
                    LuaKey.Int 5, LuaValue.String "legmex"
                    LuaKey.Int 6, LuaValue.String "armmakr"
                    LuaKey.Int 7, LuaValue.String "leglab"
                    LuaKey.Int 8, LuaValue.String "legvp"
                    LuaKey.Int 9, LuaValue.String "armap"
                    LuaKey.Int 10, LuaValue.String "armeyes"
                    LuaKey.Int 11, LuaValue.String "armrad"
                    LuaKey.Int 12, LuaValue.String "armdrag"
                    LuaKey.Int 13, LuaValue.String "armllt"
                    LuaKey.Int 14, LuaValue.String "armrl"
                    LuaKey.Int 15, LuaValue.String "armdl"
                    LuaKey.Int 16, LuaValue.String "armtide"
                    LuaKey.Int 17, LuaValue.String "armuwms"
                    LuaKey.Int 18, LuaValue.String "armuwes"
                    LuaKey.Int 20, LuaValue.String "armfmkr"
                    LuaKey.Int 21, LuaValue.String "armsy"
                    LuaKey.Int 22, LuaValue.String "armfdrag"
                    LuaKey.Int 23, LuaValue.String "armtl"
                    LuaKey.Int 24, LuaValue.String "armfrt"
                    LuaKey.Int 25, LuaValue.String "armfrad"
                    LuaKey.Int 26, LuaValue.String "armhp"
                    LuaKey.Int 27, LuaValue.String "armfhp"
                    LuaKey.Int 28, LuaValue.String "leggob"
                    LuaKey.Int 29, LuaValue.String "corjamt"
                    LuaKey.Int 30, LuaValue.String "armmine1"
                    LuaKey.Int 31, LuaValue.String "armatlas"
                    LuaKey.Int 32, LuaValue.String "armpeep"
                    LuaKey.Int 33, LuaValue.String "legmg"
                    LuaKey.Int 34, LuaValue.String "armferret"
                    LuaKey.Int 35, LuaValue.String "legbal"
                    LuaKey.Int 36, LuaValue.String "leggat"
                    LuaKey.Int 37, LuaValue.String "armnanotc"
                    LuaKey.Int 38, LuaValue.String "legmext15"
                    LuaKey.Int 39, LuaValue.String "armadvsol"
                    LuaKey.Int 40, LuaValue.String "armgeo"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "paratrooper", LuaValue.Bool true
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
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
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
                            LuaKey.String "burstrate", LuaValue.Number 0.0675
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
                            LuaKey.String "name", LuaValue.String "Rapid-fire a2g machine guns"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "ownerExpAccWeight", LuaValue.Number 4.0
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.95 0.4"
                            LuaKey.String "soundhit", LuaValue.String "bimpact3"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "minigun3"
                            LuaKey.String "soundstartvolume", LuaValue.Number 4.5
                            LuaKey.String "sprayangle", LuaValue.Number 1200.0
                            LuaKey.String "thickness", LuaValue.Number 0.91
                            LuaKey.String "tolerance", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 950.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 13.0
                                    LuaKey.String "default", LuaValue.Number 26.0
                                    LuaKey.String "vtol", LuaValue.Number 26.0
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
                            LuaKey.String "model", LuaValue.String "cortorpedo.s3o"
                            LuaKey.String "name", LuaValue.String "Level1TorpedoLauncher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
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
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 200.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.25
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "airbomb.s3o"
                            LuaKey.String "name", LuaValue.String "EMP Grenade"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "EMGPULS1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "bombrel"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 0.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 10000.0
                                ]
                        ]
                    LuaKey.String "ferret_missile", LuaValue.Table [
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
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Pop-up rapid-fire g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
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
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTAIR GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "FERRET_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "legcomecon", legcomecon
            "legcomoff", legcomoff
            "legcomt2com", legcomt2com
            "legcomt2def", legcomt2def
            "legcomt2off", legcomt2off
        ]
