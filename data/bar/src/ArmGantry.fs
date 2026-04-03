// Auto-generated BAR unit data: ArmGantry
namespace BarData.Units

open BarData

module ArmGantry =

    let armbanth =
        LuaValue.Table [
            LuaKey.String "airsightdistance", LuaValue.Number 1100.0
            LuaKey.String "buildpic", LuaValue.String "ARMBANTH.DDS"
            LuaKey.String "buildtime", LuaValue.Number 360000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "60 88 60"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 286000.0
            LuaKey.String "energymake", LuaValue.Number 150.0
            LuaKey.String "energystorage", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "bantha"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 69000.0
            LuaKey.String "mass", LuaValue.Number 13500.0
            LuaKey.String "maxacc", LuaValue.Number 0.11845
            LuaKey.String "maxdec", LuaValue.Number 0.7521
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 12.0
            LuaKey.String "metalcost", LuaValue.Number 13500.0
            LuaKey.String "movementclass", LuaValue.String "HABOT5"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMBANTH.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMBANTH.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "banthaSelfd"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 10.0
            LuaKey.String "sightdistance", LuaValue.Number 617.0
            LuaKey.String "speed", LuaValue.Number 45.6
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.089
            LuaKey.String "turnrate", LuaValue.Number 1214.40002
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "customrange", LuaValue.Number 465.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 1.0
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "66.5059539795 40 69.125361816406"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 21000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 8249.0
                            LuaKey.String "object", LuaValue.String "Units/armbanth_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 10500.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 3300.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3A.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large-impulse"
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
                            LuaKey.Int 1, LuaValue.String "krogok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "krogsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armbantha_fire", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 100.0
                            LuaKey.String "areaofeffect", LuaValue.Number 64.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Number 12.0
                            LuaKey.String "corethickness", LuaValue.Number 0.85
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.02
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 1.0
                            LuaKey.String "laserflaresize", LuaValue.Number 10.1
                            LuaKey.String "name", LuaValue.String "Close-quarters impulsion blaster"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 465.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.4
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 0.1"
                            LuaKey.String "size", LuaValue.Number 2.0
                            LuaKey.String "soundhit", LuaValue.String "xplosml3"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "banthie2"
                            LuaKey.String "soundstartvolume", LuaValue.Number 45.0
                            LuaKey.String "thickness", LuaValue.Number 3.3
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1072.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 730.0
                                ]
                        ]
                    LuaKey.String "bantha_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 96.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "castshadow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall-starburst"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy g2g/g2a guided starburst missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number -1.0
                            LuaKey.String "range", LuaValue.Number 860.0
                            LuaKey.String "reloadtime", LuaValue.Number 6.86667
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeperiod", LuaValue.Number 9.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smoketime", LuaValue.Number 36.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "rapidrocket3"
                            LuaKey.String "startvelocity", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 200.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 989.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 900.0
                                    LuaKey.String "subs", LuaValue.Number 500.0
                                ]
                        ]
                    LuaKey.String "banthfootstep", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "camerashake", LuaValue.Number 300.0
                            LuaKey.String "canattackground", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:footstep-large"
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "name", LuaValue.String "BanthStep"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 0.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.5
                            LuaKey.String "soundhit", LuaValue.String "banthstep"
                            LuaKey.String "soundhitvolume", LuaValue.Number 35.0
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "nodecal", LuaValue.Bool true
                                    LuaKey.String "noexplosionlight", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 0.0
                                ]
                        ]
                    LuaKey.String "tehlazerofdewm", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 14.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 1.05
                            LuaKey.String "corethickness", LuaValue.Number 0.3
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 1300.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-large-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 9.1
                            LuaKey.String "name", LuaValue.String "High-energy long-range g2g/g2a lazor of DEEEEEEWWWWWWMMMMMM"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 7.5
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.2 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "annigun1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.7
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1800.0
                                    LuaKey.String "default", LuaValue.Number 6000.0
                                    LuaKey.String "vtol", LuaValue.Number 3000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMBANTHA_FIRE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "TEHLAZEROFDEWM"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "BANTHA_ROCKET"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "BANTHFOOTSTEP"
                        ]
                ]
        ]

    let armlun =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "builder", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "ARMLUN.DDS"
            LuaKey.String "buildtime", LuaValue.Number 40000.0
            LuaKey.String "canattack", LuaValue.Bool true
            LuaKey.String "canguard", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canpatrol", LuaValue.Bool true
            LuaKey.String "canstop", LuaValue.Number 1.0
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "corpse", LuaValue.String "dead"
            LuaKey.String "energycost", LuaValue.Number 23000.0
            LuaKey.String "explodeas", LuaValue.String "largeexplosiongeneric"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 5300.0
            LuaKey.String "maxacc", LuaValue.Number 0.01788
            LuaKey.String "maxdec", LuaValue.Number 0.01788
            LuaKey.String "maxslope", LuaValue.Number 16.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 1150.0
            LuaKey.String "movementclass", LuaValue.String "HHOVER4"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMLUN.s3o"
            LuaKey.String "radardistance", LuaValue.Number 0.0
            LuaKey.String "script", LuaValue.String "Units/armlun.cob"
            LuaKey.String "selfdestructas", LuaValue.String "largeExplosionGenericSelfd"
            LuaKey.String "sightdistance", LuaValue.Number 620.0
            LuaKey.String "sonardistance", LuaValue.Number 550.0
            LuaKey.String "speed", LuaValue.Number 50.1
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.122
            LuaKey.String "turnrate", LuaValue.Number 250.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "damage", LuaValue.Number 7000.0
                            LuaKey.String "featuredead", LuaValue.String "heap"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 15.0
                            LuaKey.String "metal", LuaValue.Number 514.0
                            LuaKey.String "object", LuaValue.String "Units/armlun_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 3500.0
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 188.0
                            LuaKey.String "object", LuaValue.String "Units/arm4x4d.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-large"
                            LuaKey.Int 2, LuaValue.String "custom:waterwake-small-hover"
                            LuaKey.Int 3, LuaValue.String "custom:bowsplash-small-hover"
                            LuaKey.Int 4, LuaValue.String "custom:hover-wake-large"
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
                            LuaKey.Int 1, LuaValue.String "hovt2lasok"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "hovt2lassel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armlun_rocket", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailsmall"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 128.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "firestarter", LuaValue.Number 70.0
                            LuaKey.String "impulsefactor", LuaValue.Number 1.015
                            LuaKey.String "model", LuaValue.String "catapultmissile.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy g2g rocket launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 7.5
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitvolume", LuaValue.Number 8.0
                            LuaKey.String "soundhitwet", LuaValue.String "splsmed"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "soundstartvolume", LuaValue.Number 7.0
                            LuaKey.String "startvelocity", LuaValue.Number 100.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "trajectoryheight", LuaValue.Number 0.4
                            LuaKey.String "turnrate", LuaValue.Number 22000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 80.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 230.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 633.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 330.0
                                    LuaKey.String "subs", LuaValue.Number 165.0
                                    LuaKey.String "vtol", LuaValue.Number 35.0
                                ]
                        ]
                    LuaKey.String "cannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 160.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailcorroyspecial"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 160.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 4.0
                            LuaKey.String "model", LuaValue.String "airbombt2.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy ballistic underwater cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 575.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.8
                            LuaKey.String "soundhit", LuaValue.String "xplomed1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "largegun"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "cegtag", LuaValue.String "missiletrailcorroyspecial"
                                    LuaKey.String "def", LuaValue.String "armlun_cannonuw"
                                    LuaKey.String "model", LuaValue.String "airbombt2"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 370.0
                                    LuaKey.String "subs", LuaValue.Number 370.0
                                    LuaKey.String "vtol", LuaValue.Number 60.0
                                ]
                        ]
                    LuaKey.String "cannonuw", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 160.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailcorroyspecial"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 160.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "airbombt2.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy ballistic underwater cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 575.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.8
                            LuaKey.String "soundhit", LuaValue.String "xplomed1"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 0.5
                            LuaKey.String "soundstart", LuaValue.String "largegun"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "customparams", LuaValue.Table []
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 370.0
                                    LuaKey.String "subs", LuaValue.Number 370.0
                                    LuaKey.String "vtol", LuaValue.Number 60.0
                                ]
                        ]
                    LuaKey.String "depthcharge", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 24.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.9
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-uw"
                            LuaKey.String "flighttime", LuaValue.Number 3.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "cordepthcharge.s3o"
                            LuaKey.String "name", LuaValue.String "Depthcharge launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.0
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "soundhit", LuaValue.String "xplodep2"
                            LuaKey.String "soundstart", LuaValue.String "torpedo1"
                            LuaKey.String "startvelocity", LuaValue.Number 120.0
                            LuaKey.String "tolerance", LuaValue.Number 1000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 6000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 20.0
                            LuaKey.String "weapontimer", LuaValue.Number 3.0
                            LuaKey.String "weapontype", LuaValue.String "TorpedoLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 140.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 225.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "def", LuaValue.String "DEPTHCHARGE"
                            LuaKey.String "maindir", LuaValue.String "0 -1 0"
                            LuaKey.String "maxangledif", LuaValue.Number 179.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "CANBEUW UNDERWATER"
                        ]
                ]
        ]

    let armmar =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMMAR.DDS"
            LuaKey.String "buildtime", LuaValue.Number 33000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "50 70 50"
            LuaKey.String "collisionvolumetype", LuaValue.String "CYLY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 21000.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3med"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 4900.0
            LuaKey.String "mass", LuaValue.Number 970.0
            LuaKey.String "maxacc", LuaValue.Number 0.253
            LuaKey.String "maxdec", LuaValue.Number 0.8211
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 32.0
            LuaKey.String "metalcost", LuaValue.Number 970.0
            LuaKey.String "movementclass", LuaValue.String "HABOT5"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMMAR.s3o"
            LuaKey.String "script", LuaValue.String "Units/armmar.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "speed", LuaValue.Number 94.5
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.98
            LuaKey.String "turnrate", LuaValue.Number 1214.40002
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "maxrange", LuaValue.String "350"
                    LuaKey.String "model_author", LuaValue.String "PtaQ"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "weapon1turretx", LuaValue.Number 90.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 150.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "60 30 60"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2400.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 592.0
                            LuaKey.String "object", LuaValue.String "Units/armmar_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "40 40 40"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Sphere"
                            LuaKey.String "damage", LuaValue.Number 1200.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 237.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3F.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-medium"
                            LuaKey.Int 2, LuaValue.String "custom:subbubbles"
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
                            LuaKey.Int 1, LuaValue.String "mavbok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "mavbsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armamph_missile", LuaValue.Table [
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
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Guided g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.1
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 6.0
                            LuaKey.String "smokesize", LuaValue.Number 4.4
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "startvelocity", LuaValue.Number 650.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 48000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 200.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 850.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 90.0
                                ]
                        ]
                    LuaKey.String "armmech_cannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "firestarter", LuaValue.Number 5.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Double close-quarters gauss cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.7
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "KroGun1"
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.15
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 235.0
                                    LuaKey.String "vtol", LuaValue.Number 60.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "ARMMECH_CANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMAMPH_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armprowl =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMMAR.DDS"
            LuaKey.String "buildtime", LuaValue.Number 33000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -2 -1"
            LuaKey.String "collisionvolumescales", LuaValue.String "34 68 38"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 21000.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3med"
            LuaKey.String "footprintx", LuaValue.Number 3.0
            LuaKey.String "footprintz", LuaValue.Number 3.0
            LuaKey.String "health", LuaValue.Number 4900.0
            LuaKey.String "mass", LuaValue.Number 970.0
            LuaKey.String "maxacc", LuaValue.Number 0.253
            LuaKey.String "maxdec", LuaValue.Number 0.8211
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 32.0
            LuaKey.String "metalcost", LuaValue.Number 970.0
            LuaKey.String "movementclass", LuaValue.String "ATANK3"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/armprowl.s3o"
            LuaKey.String "script", LuaValue.String "Units/armprowl.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3"
            LuaKey.String "sightdistance", LuaValue.Number 455.0
            LuaKey.String "speed", LuaValue.Number 94.5
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.98
            LuaKey.String "turnrate", LuaValue.Number 1214.40002
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "i18nfromunit", LuaValue.String "armmar"
                    LuaKey.String "model_author", LuaValue.String "PtaQ"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "weapon1turretx", LuaValue.Number 90.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 150.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0.882118225098 0.0283161499023 6.0887298584"
                            LuaKey.String "collisionvolumescales", LuaValue.String "32.1447906494 31.2162322998 37.0860900879"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 2400.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 592.0
                            LuaKey.String "object", LuaValue.String "Units/armmar_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 1200.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 237.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3F.s3o"
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
                            LuaKey.Int 1, LuaValue.String "mavbok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "mavbsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "armamph_missile", LuaValue.Table [
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
                            LuaKey.String "flighttime", LuaValue.Number 1.75
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "metalpershot", LuaValue.Number 0.0
                            LuaKey.String "model", LuaValue.String "cormissile.s3o"
                            LuaKey.String "name", LuaValue.String "Guided g2a missile launcher"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.95
                            LuaKey.String "smokeperiod", LuaValue.Number 5.0
                            LuaKey.String "smokesize", LuaValue.Number 4.4
                            LuaKey.String "smoketime", LuaValue.Number 12.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smoketrailcastshadow", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "xplosml2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "rocklit1"
                            LuaKey.String "startvelocity", LuaValue.Number 650.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailaa"
                            LuaKey.String "tolerance", LuaValue.Number 9000.0
                            LuaKey.String "tracks", LuaValue.Bool true
                            LuaKey.String "turnrate", LuaValue.Number 48000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 200.0
                            LuaKey.String "weapontimer", LuaValue.Number 5.0
                            LuaKey.String "weapontype", LuaValue.String "MissileLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 850.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "vtol", LuaValue.Number 85.0
                                ]
                        ]
                    LuaKey.String "armmech_cannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "firestarter", LuaValue.Number 5.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "Double close-quarters gauss cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.7
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splshbig"
                            LuaKey.String "soundstart", LuaValue.String "KroGun1"
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.15
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 2.0
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 600.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 235.0
                                    LuaKey.String "vtol", LuaValue.Number 60.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "ARMMECH_CANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMAMPH_MISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "VTOL"
                        ]
                ]
        ]

    let armraz =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMRAZ.DDS"
            LuaKey.String "buildtime", LuaValue.Number 120000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "55 80 55"
            LuaKey.String "collisionvolumetype", LuaValue.String "CYLY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 68000.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 13300.0
            LuaKey.String "mass", LuaValue.Number 3800.0
            LuaKey.String "maxacc", LuaValue.Number 0.2369
            LuaKey.String "maxdec", LuaValue.Number 0.9039
            LuaKey.String "maxslope", LuaValue.Number 15.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 22.0
            LuaKey.String "metalcost", LuaValue.Number 3800.0
            LuaKey.String "movementclass", LuaValue.String "HBOT4"
            LuaKey.String "objectname", LuaValue.String "Units/ARMRAZ.s3o"
            LuaKey.String "script", LuaValue.String "Units/armraz.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xl"
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "speed", LuaValue.Number 69.0
            LuaKey.String "strafetoattack", LuaValue.Bool true
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.518
            LuaKey.String "turnrate", LuaValue.Number 600.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "PtaQ"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                    LuaKey.String "weapon1turretx", LuaValue.Number 200.0
                    LuaKey.String "weapon1turrety", LuaValue.Number 200.0
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
                            LuaKey.String "collisionvolumescales", LuaValue.String "61.6002807617 54.8114776611 71.5794219971"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 1500.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2325.0
                            LuaKey.String "object", LuaValue.String "Units/armraz_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "55.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 2000.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 930.0
                            LuaKey.String "object", LuaValue.String "Units/arm3X3B.s3o"
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
                            LuaKey.Int 1, LuaValue.String "mavbok1"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "mavbsel1"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "mech_rapidlaser", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 32.0
                            LuaKey.String "areaofeffect", LuaValue.Number 32.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamburst", LuaValue.Bool true
                            LuaKey.String "beamdecay", LuaValue.Number 1.0
                            LuaKey.String "beamtime", LuaValue.Number 0.07
                            LuaKey.String "burst", LuaValue.Number 6.0
                            LuaKey.String "burstrate", LuaValue.Number 0.06667
                            LuaKey.String "corethickness", LuaValue.Number 0.35
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 75.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-red"
                            LuaKey.String "firestarter", LuaValue.Number 10.0
                            LuaKey.String "firetolerance", LuaValue.Number 3640.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Rapid-fire close quarters g2g armor-piercing laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "pulsespeed", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.63333
                            LuaKey.String "rgbcolor", LuaValue.String "0.75 0 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.9 0.6"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasfirerc"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.4
                            LuaKey.String "tolerance", LuaValue.Number 4500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 920.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 116.0
                                    LuaKey.String "vtol", LuaValue.Number 22.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "burstcontrolwhenoutofarc", LuaValue.Number 2.0
                            LuaKey.String "comment", LuaValue.String "seems to have 40 deg burst limit arc limit w the burstcontrolwhenoutofarc = 2, fastautoretargeting, compounding"
                            LuaKey.String "def", LuaValue.String "MECH_RAPIDLASER"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                            LuaKey.String "fastquerypointupdate", LuaValue.Bool true
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armthor =
        LuaValue.Table [
            LuaKey.String "buildpic", LuaValue.String "ARMTHOR.DDS"
            LuaKey.String "buildtime", LuaValue.Number 320000.0
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 0 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "58 34 58"
            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 240000.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3xl"
            LuaKey.String "footprintx", LuaValue.Number 5.0
            LuaKey.String "footprintz", LuaValue.Number 5.0
            LuaKey.String "health", LuaValue.Number 56000.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "mass", LuaValue.Number 9000.0
            LuaKey.String "maxacc", LuaValue.Number 0.015
            LuaKey.String "maxdec", LuaValue.Number 0.03
            LuaKey.String "maxslope", LuaValue.Number 14.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 20.0
            LuaKey.String "metalcost", LuaValue.Number 9000.0
            LuaKey.String "movementclass", LuaValue.String "HTANK7"
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMTHOR.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMTHOR.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xxl"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "speed", LuaValue.Number 54.0
            LuaKey.String "trackoffset", LuaValue.Number 6.0
            LuaKey.String "trackstrength", LuaValue.Number 5.0
            LuaKey.String "tracktype", LuaValue.String "armacv_tracks"
            LuaKey.String "trackwidth", LuaValue.Number 60.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 1.6
            LuaKey.String "turnrate", LuaValue.Number 180.0
            LuaKey.String "usepiececollisionvolumes", LuaValue.Number 1.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "lumamult", LuaValue.String "0.7"
                    LuaKey.String "maxrange", LuaValue.String "540"
                    LuaKey.String "model_author", LuaValue.String "Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.0
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "emp"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-1.01699066162 -0.66435255127 0.0775146484375"
                            LuaKey.String "collisionvolumescales", LuaValue.String "31.8865509033 22.2328948975 29.3510131836"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 25000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 4.0
                            LuaKey.String "footprintz", LuaValue.Number 4.0
                            LuaKey.String "height", LuaValue.Number 25.0
                            LuaKey.String "metal", LuaValue.Number 5500.0
                            LuaKey.String "object", LuaValue.String "Units/armthor_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35.0 4.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 10000.0
                            LuaKey.String "footprintx", LuaValue.Number 5.0
                            LuaKey.String "footprintz", LuaValue.Number 5.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 2750.0
                            LuaKey.String "object", LuaValue.String "Units/arm2X2D.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "resurrectable", LuaValue.Number 0.0
                        ]
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:barrelshot-lightning"
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
                            LuaKey.Int 1, LuaValue.String "tarmmove"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "tarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "emp", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Number 0.5
                            LuaKey.String "beamtime", LuaValue.Number 0.25
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 0.01
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 15.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "firetolerance", LuaValue.Number 1820.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "Long Range EMP laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "hackshot"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 1.2
                            LuaKey.String "tolerance", LuaValue.Number 1820.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 800.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                ]
                        ]
                    LuaKey.String "empmissile", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 196.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool false
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "cruisemissiletrail-emp"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "commandfire", LuaValue.Bool true
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "energypershot", LuaValue.Number 5000.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "firestarter", LuaValue.Number 0.0
                            LuaKey.String "fixedlauncher", LuaValue.Bool true
                            LuaKey.String "flighttime", LuaValue.Number 12.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "interceptedbyshieldtype", LuaValue.Number 0.0
                            LuaKey.String "metalpershot", LuaValue.Number 100.0
                            LuaKey.String "model", LuaValue.String "corshiprocket.s3o"
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g EMP starburst rocket"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 12.0
                            LuaKey.String "range", LuaValue.Number 1050.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "smoketrail", LuaValue.Bool false
                            LuaKey.String "soundhit", LuaValue.String "emgpuls1"
                            LuaKey.String "soundstart", LuaValue.String "mismed1emp1"
                            LuaKey.String "startvelocity", LuaValue.Number 0.0
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 65.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "null"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "tolerance", LuaValue.Number 4000.0
                            LuaKey.String "turnrate", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weaponacceleration", LuaValue.Number 75.0
                            LuaKey.String "weapontimer", LuaValue.Number 2.5
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "shield_aoe_penetration", LuaValue.Bool true
                                    LuaKey.String "stockpilelimit", LuaValue.Number 2.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 80000.0
                                ]
                        ]
                    LuaKey.String "thunder", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 48.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 10.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 2.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 350.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-lightning-thor"
                            LuaKey.String "falloffrate", LuaValue.Number 0.5
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "hardstop", LuaValue.Bool false
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 28.0
                            LuaKey.String "name", LuaValue.String "Heavy Lighting Cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 540.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.1
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundhit", LuaValue.String "lasrfir2"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lghthvy1"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.8
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "noattackrangearc", LuaValue.Number 1.0
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-large-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.25"
                                    LuaKey.String "spark_maxunits", LuaValue.String "5"
                                    LuaKey.String "spark_range", LuaValue.String "125"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 300.0
                                    LuaKey.String "subs", LuaValue.Number 30.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "burstcontrolwhenoutofarc", LuaValue.Number 2.0
                            LuaKey.String "def", LuaValue.String "thunder"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMPMISSILE"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMP"
                            LuaKey.String "maindir", LuaValue.String "-1 0 0"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMP"
                            LuaKey.String "maindir", LuaValue.String "1 0 0"
                            LuaKey.String "maxangledif", LuaValue.Number 180.0
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                ]
        ]

    let armvang =
        LuaValue.Table [
            LuaKey.String "activatewhenbuilt", LuaValue.Bool false
            LuaKey.String "buildpic", LuaValue.String "ARMVANG.DDS"
            LuaKey.String "buildtime", LuaValue.Number 120000.0
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "cantbetransported", LuaValue.Bool true
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "65 60 65"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energycost", LuaValue.Number 71000.0
            LuaKey.String "explodeas", LuaValue.String "explosiont3"
            LuaKey.String "footprintx", LuaValue.Number 4.0
            LuaKey.String "footprintz", LuaValue.Number 4.0
            LuaKey.String "health", LuaValue.Number 8500.0
            LuaKey.String "mass", LuaValue.Number 3300.0
            LuaKey.String "maxacc", LuaValue.Number 0.02645
            LuaKey.String "maxdec", LuaValue.Number 0.345
            LuaKey.String "maxslope", LuaValue.Number 17.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalcost", LuaValue.Number 3300.0
            LuaKey.String "movementclass", LuaValue.String "HTBOT6"
            LuaKey.String "movestate", LuaValue.Number 0.0
            LuaKey.String "nochasecategory", LuaValue.String "VTOL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMVANG.s3o"
            LuaKey.String "script", LuaValue.String "Units/ARMVANG.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "explosiont3xl"
            LuaKey.String "sightdistance", LuaValue.Number 625.0
            LuaKey.String "speed", LuaValue.Number 33.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.726
            LuaKey.String "turnrate", LuaValue.Number 265.64999
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "model_author", LuaValue.String "Flaka"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "subfolder", LuaValue.String "ArmGantry"
                    LuaKey.String "techlevel", LuaValue.Number 3.0
                    LuaKey.String "unitgroup", LuaValue.String "weapon"
                ]
            LuaKey.String "featuredefs", LuaValue.Table [
                    LuaKey.String "dead", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool true
                            LuaKey.String "category", LuaValue.String "corpses"
                            LuaKey.String "collisionvolumeoffsets", LuaValue.String "-3.37104034424 -1.05229058838 1.8899307251"
                            LuaKey.String "collisionvolumescales", LuaValue.String "64.0154266357 41.4324188232 55.433883667"
                            LuaKey.String "collisionvolumetype", LuaValue.String "Box"
                            LuaKey.String "damage", LuaValue.Number 3000.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "metal", LuaValue.Number 2028.0
                            LuaKey.String "object", LuaValue.String "Units/armvang_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "85.0 14.0 6.0"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 3015.0
                            LuaKey.String "footprintx", LuaValue.Number 3.0
                            LuaKey.String "footprintz", LuaValue.Number 3.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "metal", LuaValue.Number 811.0
                            LuaKey.String "object", LuaValue.String "Units/arm4X4D.s3o"
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
                            LuaKey.Int 1, LuaValue.String "kbarmmov"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "kbarmsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "shocker_high", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 192.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-huge"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 192.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "firetolerance", LuaValue.Number 5000.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 2.8
                            LuaKey.String "hightrajectory", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.25
                            LuaKey.String "range", LuaValue.Number 1450.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_backup", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1100.0
                                    LuaKey.String "default", LuaValue.Number 1265.0
                                    LuaKey.String "shields", LuaValue.Number 765.0
                                    LuaKey.String "subs", LuaValue.Number 500.0
                                ]
                        ]
                    LuaKey.String "shocker_low", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 192.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-huge"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 192.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "firetolerance", LuaValue.Number 5000.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 2.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.25
                            LuaKey.String "range", LuaValue.Number 1450.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "exclude_preaim", LuaValue.Bool true
                                    LuaKey.String "smart_priority", LuaValue.Bool true
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 1100.0
                                    LuaKey.String "default", LuaValue.Number 1265.0
                                    LuaKey.String "shields", LuaValue.Number 765.0
                                    LuaKey.String "subs", LuaValue.Number 500.0
                                ]
                        ]
                    LuaKey.String "smart_trajectory_dummy", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 192.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "avoidneutral", LuaValue.Bool true
                            LuaKey.String "cegtag", LuaValue.String "arty-huge"
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 192.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.65
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge"
                            LuaKey.String "firetolerance", LuaValue.Number 5000.0
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "heightboostfactor", LuaValue.Number 2.8
                            LuaKey.String "impulsefactor", LuaValue.Number 0.5
                            LuaKey.String "name", LuaValue.String "Heavy long-range g2g plasma cannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 0.25
                            LuaKey.String "range", LuaValue.Number 1450.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed2"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy5"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
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
                            LuaKey.String "def", LuaValue.String "SHOCKER_LOW"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "SHOCKER_HIGH"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "smart_trajectory_dummy"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armbanth", armbanth
            "armlun", armlun
            "armmar", armmar
            "armprowl", armprowl
            "armraz", armraz
            "armthor", armthor
            "armvang", armvang
        ]
