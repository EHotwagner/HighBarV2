// Auto-generated BAR unit data: other/evocom
namespace BarData.Units

open BarData

module other_evocom =

    let armcomlvl10 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 110000.0
            LuaKey.String "metalcost", LuaValue.Number 11000.0
            LuaKey.String "builddistance", LuaValue.Number 217.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 195600.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canselfrepair", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 2000.0
            LuaKey.String "energystorage", LuaValue.Number 10000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "armcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 13200.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 50.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOMHILVL.lua"
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
            LuaKey.String "workertime", LuaValue.Number 1800.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"armmoho\",\r\n\t\t\t\"armadvsol\",\r\n\t\t\t\"armwin\",\r\n\t\t\t\"armfus\",\r\n\t\t\t\"armmmkr\",\r\n\t\t\t\"armageo\",\r\n\t\t\t\"armamex\",\r\n\t\t\t\"armtide\",\r\n\t\t\t\"armuwadves\",\r\n\t\t\t\"armuwadvms\",\r\n\t\t\t\"armuwmmm\",\r\n\t\t\t\"armlab\",\r\n\t\t\t\"armvp\",\r\n\t\t\t\"armap\",\r\n\t\t\t\"armeyes\",\r\n\t\t\t\"armarad\",\r\n\t\t\t\"armmine1\",\r\n\t\t\t\"armmine2\",\r\n\t\t\t\"armmine3\",\r\n\t\t\t\"armdrag\",\r\n\t\t\t\"armfort\",\r\n\t\t\t\"armjamt\",\r\n\t\t\t\"armclaw\",\r\n\t\t\t\"armbeamer\",\r\n\t\t\t\"armpb\",\r\n\t\t\t\"armanni\",\r\n\t\t\t\"armatl\",\r\n\t\t\t\"armflak\",\r\n\t\t\t\"armmercury\",\r\n\t\t\t\"armdl\",\r\n\t\t\t\"armamb\",\r\n\t\t\t\"armjuno\",\r\n\t\t\t\"armfflak\",\r\n\t\t\t\"armuwmme\",\r\n\t\t\t\"armuwageo\",\r\n\t\t\t\"armsy\",\r\n\t\t\t\"armnanotc\",\r\n\t\t\t\"armnanotcplat\",\r\n\t\t\t\"armfdrag\",\r\n\t\t\t\"armfrad\",\r\n\t\t\t\"armhp\",\r\n\t\t\t\"armfhp\",\r\n\t\t\t\"armdecom\",\r\n\t\t\t\"armshockwave\",\r\n\t\t\t\"armgate\",\r\n\t\t\t\"armlwall\",\r\n\t\t\t\"armannit3\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "armmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 10.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.5
                    LuaKey.String "childreninheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "parentsinheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "workertimeboost", LuaValue.Number 3.5
                    LuaKey.String "wtboostunittype", LuaValue.String "TURRET MOBILE"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 44000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
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
                            LuaKey.Int 4, LuaValue.String "custom:genericshellexplosion-huge-lightning"
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
                    LuaKey.String "backlauncher", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 121.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 70.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.61
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 7.4
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 870.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 8.0
                            LuaKey.String "smoketime", LuaValue.Number 30.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 250.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.9
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 1001.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 5.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 4400.0
                                ]
                        ]
                    LuaKey.String "longgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 5.05
                            LuaKey.String "name", LuaValue.String "Arcing Stun Beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "hackshot"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw2"
                            LuaKey.String "soundstartvolume", LuaValue.Number 30.0
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 40.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 30.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 60000.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 70.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.6
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UWSupernovaBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.28
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.7 0.10"
                            LuaKey.String "rgbcolor2", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1400.0
                                    LuaKey.String "subs", LuaValue.Number 700.0
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
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                    LuaKey.String "shortgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 5.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "name", LuaValue.String "Short-Range Lightening Discharge"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "1.0, 0.7, 0.0"
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "lghthvy2"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.33"
                                    LuaKey.String "spark_maxunits", LuaValue.String "12"
                                    LuaKey.String "spark_range", LuaValue.String "100"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 118.0
                                ]
                        ]
                    LuaKey.String "empflashbang", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Expr ".8"
                            LuaKey.String "beamttl", LuaValue.Number 0.8
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collideground", LuaValue.Bool false
                            LuaKey.String "collideneutral", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.001
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "EMP Damage-Mitigating Flashbang"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 3.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "rgbcolor", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "xplosml5"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "backlauncher"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "LONGGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SHORTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMPFLASHBANG"
                            LuaKey.String "onlytargetcategory", LuaValue.String "COMMANDER"
                        ]
                ]
        ]

    let armcomlvl2 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 30000.0
            LuaKey.String "metalcost", LuaValue.Number 3000.0
            LuaKey.String "builddistance", LuaValue.Number 153.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 75000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 50.0
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "armcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 6000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 3.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.Expr "\"Units/ARMCOM\"..(Spring.GetModOptions().xmas and '-XMAS' or '')..\".s3o\""
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOM_lus.lua"
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
            LuaKey.String "workertime", LuaValue.Number 324.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"armsolar\",\r\n\t\t\t\"armwin\",\r\n\t\t\t\"armmstor\",\r\n\t\t\t\"armestor\",\r\n\t\t\t\"armmex\",\r\n\t\t\t\"armmakr\",\r\n\t\t\t\"armlab\",\r\n\t\t\t\"armvp\",\r\n\t\t\t\"armap\",\r\n\t\t\t\"armeyes\",\r\n\t\t\t\"armrad\",\r\n\t\t\t\"armdrag\",\r\n\t\t\t\"armllt\",\r\n\t\t\t\"armrl\",\r\n\t\t\t\"armdl\",\r\n\t\t\t\"armtide\",\r\n\t\t\t\"armuwms\",\r\n\t\t\t\"armuwes\",\r\n\t\t\t\"armfmkr\",\r\n\t\t\t\"armsy\",\r\n\t\t\t\"armfdrag\",\r\n\t\t\t\"armtl\",\r\n\t\t\t\"armfrt\",\r\n\t\t\t\"armfrad\",\r\n\t\t\t\"armhp\",\r\n\t\t\t\"armfhp\",\r\n\t\t\t\"armmine1\",\r\n\t\t\t\"armmine2\",\r\n\t\t\t\"armmine3\",\r\n\t\t\t\"armbeamer\",\r\n\t\t\t\"armhlt\",\r\n\t\t\t\"armferret\",\r\n\t\t\t\"armfrock\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "armmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 2.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "workertimeboost", LuaValue.Number 2.0
                    LuaKey.String "wtboostunittype", LuaValue.String "TURRET"
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.5
                    LuaKey.String "childreninheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "parentsinheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "armcomlvl3"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 22000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 12000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
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
                    LuaKey.String "shortgun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 50.0
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Number 0.05
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "corethickness", LuaValue.Number 0.233
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosionscar", LuaValue.Bool false
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-beamer"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "laserflaresize", LuaValue.Number 9.35
                            LuaKey.String "name", LuaValue.String "Scatter Beamer"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "projectiles", LuaValue.Number 9.0
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "0 0 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "beamershot2"
                            LuaKey.String "sprayangle", LuaValue.Number 2500.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 14.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 7.7
                            LuaKey.String "name", LuaValue.String "Light underwater-combat laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.0
                            LuaKey.String "rgbcolor", LuaValue.String "0 0 0.8"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.0 0.0 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
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
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SHORTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let armcomlvl3 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 40000.0
            LuaKey.String "metalcost", LuaValue.Number 4000.0
            LuaKey.String "builddistance", LuaValue.Number 161.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 85000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canselfrepair", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 75.0
            LuaKey.String "energystorage", LuaValue.Number 1500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "armcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 6900.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 5.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1100.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOMHILVL.lua"
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
            LuaKey.String "workertime", LuaValue.Number 447.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"armmex\",\r\n\t\t\t\"armsolar\",\r\n\t\t\t\"armwin\",\r\n\t\t\t\"armadvsol\",\r\n\t\t\t\"armmakr\",\r\n\t\t\t\"armgeo\",\r\n\t\t\t\"armamex\",\r\n\t\t\t\"armtide\",\r\n\t\t\t\"armestor\",\r\n\t\t\t\"armmstor\",\r\n\t\t\t\"armfmkr\",\r\n\t\t\t\"armlab\",\r\n\t\t\t\"armvp\",\r\n\t\t\t\"armap\",\r\n\t\t\t\"armeyes\",\r\n\t\t\t\"armrad\",\r\n\t\t\t\"armmine1\",\r\n\t\t\t\"armmine2\",\r\n\t\t\t\"armmine3\",\r\n\t\t\t\"armdrag\",\r\n\t\t\t\"armjamt\",\r\n\t\t\t\"armclaw\",\r\n\t\t\t\"armllt\",\r\n\t\t\t\"armbeamer\",\r\n\t\t\t\"armhlt\",\r\n\t\t\t\"armtl\",\r\n\t\t\t\"armguard\",\r\n\t\t\t\"armrl\",\r\n\t\t\t\"armferret\",\r\n\t\t\t\"armcir\",\r\n\t\t\t\"armfrock\",\r\n\t\t\t\"armjuno\",\r\n\t\t\t\"armuwgeo\",\r\n\t\t\t\"armuwms\",\r\n\t\t\t\"armuwes\",\r\n\t\t\t\"armdl\",\r\n\t\t\t\"armsy\",\r\n\t\t\t\"armnanotc\",\r\n\t\t\t\"armnanotcplat\",\r\n\t\t\t\"armfdrag\",\r\n\t\t\t\"armfrt\",\r\n\t\t\t\"armfrad\",\r\n\t\t\t\"armhp\",\r\n\t\t\t\"armfhp\",\r\n\t\t\t\"armdecom\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "armmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 3.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "armcomlvl4"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 53000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "workertimeboost", LuaValue.Number 3.5
                    LuaKey.String "wtboostunittype", LuaValue.String "TURRET"
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.5
                    LuaKey.String "childreninheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "parentsinheritxp", LuaValue.String "TURRET MOBILEBUILT"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 16000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
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
                            LuaKey.Int 4, LuaValue.String "custom:genericshellexplosion-huge-lightning"
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
                    LuaKey.String "backlauncher", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 55.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 70.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.61
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 7.4
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 435.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.33
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 8.0
                            LuaKey.String "smoketime", LuaValue.Number 30.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 250.0
                            LuaKey.String "weapontimer", LuaValue.Number 0.87
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 501.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 3.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 550.0
                                ]
                        ]
                    LuaKey.String "longgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 3.05
                            LuaKey.String "name", LuaValue.String "Arcing Stun Beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 410.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "hackshot"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw2"
                            LuaKey.String "soundstartvolume", LuaValue.Number 30.0
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 40.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 30.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 16000.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "beamttl", LuaValue.Number 2.4
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.44
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.8 0.3"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
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
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                    LuaKey.String "shortgun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 50.0
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Number 0.05
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "corethickness", LuaValue.Number 0.233
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosionscar", LuaValue.Bool false
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-beamer"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "laserflaresize", LuaValue.Number 9.35
                            LuaKey.String "name", LuaValue.String "Scatter Beamer"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "projectiles", LuaValue.Number 12.0
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "0 0 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "beamershot2"
                            LuaKey.String "sprayangle", LuaValue.Number 3000.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 15.0
                                ]
                        ]
                    LuaKey.String "empflashbang", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Expr ".8"
                            LuaKey.String "beamttl", LuaValue.Number 0.8
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collideground", LuaValue.Bool false
                            LuaKey.String "collideneutral", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.001
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "EMP Damage-Mitigating Flashbang"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 3.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "rgbcolor", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "xplosml5"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "backlauncher"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "LONGGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SHORTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "empflashbang"
                            LuaKey.String "onlytargetcategory", LuaValue.String "COMMANDER"
                        ]
                ]
        ]

    let armcomlvl4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 50000.0
            LuaKey.String "metalcost", LuaValue.Number 5000.0
            LuaKey.String "builddistance", LuaValue.Number 169.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 94800.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canselfrepair", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 125.0
            LuaKey.String "energystorage", LuaValue.Number 2000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "armcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 7800.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 9.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1100.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOMHILVL.lua"
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
            LuaKey.String "workertime", LuaValue.Number 545.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"armmex\",\r\n\t\t\t\"armsolar\",\r\n\t\t\t\"armwin\",\r\n\t\t\t\"armadvsol\",\r\n\t\t\t\"armmakr\",\r\n\t\t\t\"armgeo\",\r\n\t\t\t\"armamex\",\r\n\t\t\t\"armtide\",\r\n\t\t\t\"armestor\",\r\n\t\t\t\"armmstor\",\r\n\t\t\t\"armfmkr\",\r\n\t\t\t\"armlab\",\r\n\t\t\t\"armvp\",\r\n\t\t\t\"armap\",\r\n\t\t\t\"armeyes\",\r\n\t\t\t\"armrad\",\r\n\t\t\t\"armmine1\",\r\n\t\t\t\"armmine2\",\r\n\t\t\t\"armmine3\",\r\n\t\t\t\"armdrag\",\r\n\t\t\t\"armjamt\",\r\n\t\t\t\"armclaw\",\r\n\t\t\t\"armpb\",\r\n\t\t\t\"armbeamer\",\r\n\t\t\t\"armhlt\",\r\n\t\t\t\"armtl\",\r\n\t\t\t\"armamb\",\r\n\t\t\t\"armrl\",\r\n\t\t\t\"armferret\",\r\n\t\t\t\"armcir\",\r\n\t\t\t\"armfrock\",\r\n\t\t\t\"armjuno\",\r\n\t\t\t\"armuwgeo\",\r\n\t\t\t\"armuwms\",\r\n\t\t\t\"armuwes\",\r\n\t\t\t\"armdl\",\r\n\t\t\t\"armsy\",\r\n\t\t\t\"armnanotc\",\r\n\t\t\t\"armnanotcplat\",\r\n\t\t\t\"armfdrag\",\r\n\t\t\t\"armfrt\",\r\n\t\t\t\"armfrad\",\r\n\t\t\t\"armhp\",\r\n\t\t\t\"armfhp\",\r\n\t\t\t\"armdecom\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "armmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 4.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "armcomlvl5"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 105000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "workertimeboost", LuaValue.Number 3.5
                    LuaKey.String "wtboostunittype", LuaValue.String "TURRET"
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.5
                    LuaKey.String "childreninheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "parentsinheritxp", LuaValue.String "TURRET MOBILEBUILT"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 20000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
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
                            LuaKey.Int 4, LuaValue.String "custom:genericshellexplosion-huge-lightning"
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
                    LuaKey.String "backlauncher", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 70.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 70.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.61
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 7.4
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.33
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 8.0
                            LuaKey.String "smoketime", LuaValue.Number 30.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 250.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.1
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 633.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 3.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 800.0
                                ]
                        ]
                    LuaKey.String "longgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 3.05
                            LuaKey.String "name", LuaValue.String "Arcing Stun Beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "hackshot"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 30.0
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 40.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 30.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 22000.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "beamttl", LuaValue.Number 2.4
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.36
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.8 0.3"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
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
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                    LuaKey.String "shortgun", LuaValue.Table [
                            LuaKey.String "accuracy", LuaValue.Number 50.0
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 10.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Number 0.05
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "corethickness", LuaValue.Number 0.233
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosionscar", LuaValue.Bool false
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-beamer"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "intensity", LuaValue.Number 0.7
                            LuaKey.String "laserflaresize", LuaValue.Number 9.35
                            LuaKey.String "name", LuaValue.String "Scatter Beamer"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "projectiles", LuaValue.Number 16.0
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "0 0 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "beamershot2"
                            LuaKey.String "sprayangle", LuaValue.Number 3500.0
                            LuaKey.String "tolerance", LuaValue.Number 5000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "empflashbang", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Expr ".8"
                            LuaKey.String "beamttl", LuaValue.Number 0.8
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collideground", LuaValue.Bool false
                            LuaKey.String "collideneutral", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.001
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "EMP Damage-Mitigating Flashbang"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 3.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "rgbcolor", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "xplosml5"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "backlauncher"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "LONGGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SHORTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMPFLASHBANG"
                            LuaKey.String "onlytargetcategory", LuaValue.String "COMMANDER"
                        ]
                ]
        ]

    let armcomlvl5 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 60000.0
            LuaKey.String "metalcost", LuaValue.Number 6000.0
            LuaKey.String "builddistance", LuaValue.Number 177.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 111600.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canselfrepair", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 200.0
            LuaKey.String "energystorage", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "armcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 8700.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 14.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOMHILVL.lua"
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
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"armmoho\",\r\n\t\t\t\"armadvsol\",\r\n\t\t\t\"armwin\",\r\n\t\t\t\"armfus\",\r\n\t\t\t\"armmmkr\",\r\n\t\t\t\"armageo\",\r\n\t\t\t\"armamex\",\r\n\t\t\t\"armtide\",\r\n\t\t\t\"armuwadves\",\r\n\t\t\t\"armuwadvms\",\r\n\t\t\t\"armuwmmm\",\r\n\t\t\t\"armlab\",\r\n\t\t\t\"armvp\",\r\n\t\t\t\"armap\",\r\n\t\t\t\"armeyes\",\r\n\t\t\t\"armarad\",\r\n\t\t\t\"armmine1\",\r\n\t\t\t\"armmine2\",\r\n\t\t\t\"armmine3\",\r\n\t\t\t\"armdrag\",\r\n\t\t\t\"armfort\",\r\n\t\t\t\"armjamt\",\r\n\t\t\t\"armclaw\",\r\n\t\t\t\"armbeamer\",\r\n\t\t\t\"armpb\",\r\n\t\t\t\"armanni\",\r\n\t\t\t\"armatl\",\r\n\t\t\t\"armflak\",\r\n\t\t\t\"armmercury\",\r\n\t\t\t\"armdl\",\r\n\t\t\t\"armamb\",\r\n\t\t\t\"armjuno\",\r\n\t\t\t\"armfflak\",\r\n\t\t\t\"armuwmme\",\r\n\t\t\t\"armuwageo\",\r\n\t\t\t\"armsy\",\r\n\t\t\t\"armnanotc\",\r\n\t\t\t\"armnanotcplat\",\r\n\t\t\t\"armfdrag\",\r\n\t\t\t\"armfrad\",\r\n\t\t\t\"armhp\",\r\n\t\t\t\"armfhp\",\r\n\t\t\t\"armdecom\",\r\n\t\t\t\"armshockwave\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "armmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 5.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "armcomlvl6"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 260000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.5
                    LuaKey.String "childreninheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "parentsinheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "workertimeboost", LuaValue.Number 3.5
                    LuaKey.String "wtboostunittype", LuaValue.String "TURRET MOBILE"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 24000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
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
                            LuaKey.Int 4, LuaValue.String "custom:genericshellexplosion-huge-lightning"
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
                    LuaKey.String "backlauncher", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 79.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 70.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.61
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 7.4
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 620.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 8.0
                            LuaKey.String "smoketime", LuaValue.Number 30.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 250.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.24
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 713.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 4.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1200.0
                                ]
                        ]
                    LuaKey.String "longgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 4.05
                            LuaKey.String "name", LuaValue.String "Arcing Stun Beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "hackshot"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw2"
                            LuaKey.String "soundstartvolume", LuaValue.Number 30.0
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 40.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 30.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 2.25
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 30000.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 42.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UltravioletRayBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.74
                            LuaKey.String "rgbcolor", LuaValue.String "0.6 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1200.0
                                    LuaKey.String "subs", LuaValue.Number 600.0
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
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                    LuaKey.String "shortgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 5.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "name", LuaValue.String "Short-Range Lightening Discharge"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 425.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "lghthvy2"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.33"
                                    LuaKey.String "spark_maxunits", LuaValue.String "6"
                                    LuaKey.String "spark_range", LuaValue.String "75"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 42.0
                                ]
                        ]
                    LuaKey.String "empflashbang", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Expr ".8"
                            LuaKey.String "beamttl", LuaValue.Number 0.8
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collideground", LuaValue.Bool false
                            LuaKey.String "collideneutral", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.001
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "EMP Damage-Mitigating Flashbang"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 3.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "rgbcolor", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "xplosml5"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "backlauncher"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "LONGGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SHORTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMPFLASHBANG"
                            LuaKey.String "onlytargetcategory", LuaValue.String "COMMANDER"
                        ]
                ]
        ]

    let armcomlvl6 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 70000.0
            LuaKey.String "metalcost", LuaValue.Number 7000.0
            LuaKey.String "builddistance", LuaValue.Number 185.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 128400.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canselfrepair", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 325.0
            LuaKey.String "energystorage", LuaValue.Number 3000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "armcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 9600.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 20.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOMHILVL.lua"
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
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"armmoho\",\r\n\t\t\t\"armadvsol\",\r\n\t\t\t\"armwin\",\r\n\t\t\t\"armfus\",\r\n\t\t\t\"armmmkr\",\r\n\t\t\t\"armageo\",\r\n\t\t\t\"armamex\",\r\n\t\t\t\"armtide\",\r\n\t\t\t\"armuwadves\",\r\n\t\t\t\"armuwadvms\",\r\n\t\t\t\"armuwmmm\",\r\n\t\t\t\"armlab\",\r\n\t\t\t\"armvp\",\r\n\t\t\t\"armap\",\r\n\t\t\t\"armeyes\",\r\n\t\t\t\"armarad\",\r\n\t\t\t\"armmine1\",\r\n\t\t\t\"armmine2\",\r\n\t\t\t\"armmine3\",\r\n\t\t\t\"armdrag\",\r\n\t\t\t\"armfort\",\r\n\t\t\t\"armjamt\",\r\n\t\t\t\"armclaw\",\r\n\t\t\t\"armbeamer\",\r\n\t\t\t\"armpb\",\r\n\t\t\t\"armanni\",\r\n\t\t\t\"armatl\",\r\n\t\t\t\"armflak\",\r\n\t\t\t\"armmercury\",\r\n\t\t\t\"armdl\",\r\n\t\t\t\"armamb\",\r\n\t\t\t\"armjuno\",\r\n\t\t\t\"armfflak\",\r\n\t\t\t\"armuwmme\",\r\n\t\t\t\"armuwageo\",\r\n\t\t\t\"armsy\",\r\n\t\t\t\"armnanotc\",\r\n\t\t\t\"armnanotcplat\",\r\n\t\t\t\"armfdrag\",\r\n\t\t\t\"armfrad\",\r\n\t\t\t\"armhp\",\r\n\t\t\t\"armfhp\",\r\n\t\t\t\"armdecom\",\r\n\t\t\t\"armshockwave\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "armmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 6.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "armcomlvl7"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 390000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.5
                    LuaKey.String "childreninheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "parentsinheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "workertimeboost", LuaValue.Number 3.5
                    LuaKey.String "wtboostunittype", LuaValue.String "TURRET MOBILE"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 28000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
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
                            LuaKey.Int 4, LuaValue.String "custom:genericshellexplosion-huge-lightning"
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
                    LuaKey.String "backlauncher", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 93.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 70.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.61
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 7.4
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 730.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 8.0
                            LuaKey.String "smoketime", LuaValue.Number 30.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 250.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.46
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 840.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 4.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1350.0
                                ]
                        ]
                    LuaKey.String "longgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 4.05
                            LuaKey.String "name", LuaValue.String "Arcing Stun Beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "hackshot"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw2"
                            LuaKey.String "soundstartvolume", LuaValue.Number 30.0
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 40.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 30.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 2.25
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 40000.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 42.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UltravioletRayBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.54
                            LuaKey.String "rgbcolor", LuaValue.String "0.6 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1200.0
                                    LuaKey.String "subs", LuaValue.Number 600.0
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
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                    LuaKey.String "shortgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 5.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "name", LuaValue.String "Short-Range Lightening Discharge"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 425.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "lghthvy2"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.33"
                                    LuaKey.String "spark_maxunits", LuaValue.String "6"
                                    LuaKey.String "spark_range", LuaValue.String "75"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 50.0
                                ]
                        ]
                    LuaKey.String "empflashbang", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Expr ".8"
                            LuaKey.String "beamttl", LuaValue.Number 0.8
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collideground", LuaValue.Bool false
                            LuaKey.String "collideneutral", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.001
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "EMP Damage-Mitigating Flashbang"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 3.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "rgbcolor", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "xplosml5"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "backlauncher"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "LONGGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SHORTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMPFLASHBANG"
                            LuaKey.String "onlytargetcategory", LuaValue.String "COMMANDER"
                        ]
                ]
        ]

    let armcomlvl7 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 80000.0
            LuaKey.String "metalcost", LuaValue.Number 8000.0
            LuaKey.String "builddistance", LuaValue.Number 193.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 145200.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canselfrepair", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 525.0
            LuaKey.String "energystorage", LuaValue.Number 3500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "armcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 10500.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 27.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOMHILVL.lua"
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
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"armmoho\",\r\n\t\t\t\"armadvsol\",\r\n\t\t\t\"armwin\",\r\n\t\t\t\"armfus\",\r\n\t\t\t\"armmmkr\",\r\n\t\t\t\"armageo\",\r\n\t\t\t\"armamex\",\r\n\t\t\t\"armtide\",\r\n\t\t\t\"armuwadves\",\r\n\t\t\t\"armuwadvms\",\r\n\t\t\t\"armuwmmm\",\r\n\t\t\t\"armlab\",\r\n\t\t\t\"armvp\",\r\n\t\t\t\"armap\",\r\n\t\t\t\"armeyes\",\r\n\t\t\t\"armarad\",\r\n\t\t\t\"armmine1\",\r\n\t\t\t\"armmine2\",\r\n\t\t\t\"armmine3\",\r\n\t\t\t\"armdrag\",\r\n\t\t\t\"armfort\",\r\n\t\t\t\"armjamt\",\r\n\t\t\t\"armclaw\",\r\n\t\t\t\"armbeamer\",\r\n\t\t\t\"armpb\",\r\n\t\t\t\"armanni\",\r\n\t\t\t\"armatl\",\r\n\t\t\t\"armflak\",\r\n\t\t\t\"armmercury\",\r\n\t\t\t\"armdl\",\r\n\t\t\t\"armamb\",\r\n\t\t\t\"armjuno\",\r\n\t\t\t\"armfflak\",\r\n\t\t\t\"armuwmme\",\r\n\t\t\t\"armuwageo\",\r\n\t\t\t\"armsy\",\r\n\t\t\t\"armnanotc\",\r\n\t\t\t\"armnanotcplat\",\r\n\t\t\t\"armfdrag\",\r\n\t\t\t\"armfrad\",\r\n\t\t\t\"armhp\",\r\n\t\t\t\"armfhp\",\r\n\t\t\t\"armdecom\",\r\n\t\t\t\"armshockwave\",\r\n\t\t\t\"armlwall\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "armmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 7.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "armcomlvl8"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 520000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.5
                    LuaKey.String "childreninheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "parentsinheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "workertimeboost", LuaValue.Number 3.5
                    LuaKey.String "wtboostunittype", LuaValue.String "TURRET MOBILE"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 32000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
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
                            LuaKey.Int 4, LuaValue.String "custom:genericshellexplosion-huge-lightning"
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
                    LuaKey.String "backlauncher", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 93.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 70.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.61
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 7.4
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 730.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.5
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 8.0
                            LuaKey.String "smoketime", LuaValue.Number 30.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 250.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.46
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 840.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 4.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1800.0
                                ]
                        ]
                    LuaKey.String "longgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "beamtime", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 4.05
                            LuaKey.String "name", LuaValue.String "Arcing Stun Beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "hackshot"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw2"
                            LuaKey.String "soundstartvolume", LuaValue.Number 30.0
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 40.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 30.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 2.25
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 56000.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 42.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UltravioletRayBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.43
                            LuaKey.String "rgbcolor", LuaValue.String "0.6 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1200.0
                                    LuaKey.String "subs", LuaValue.Number 600.0
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
                            LuaKey.String "groundbounce", LuaValue.Bool true
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
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                    LuaKey.String "shortgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 5.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "name", LuaValue.String "Short-Range Lightening Discharge"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 425.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.5 1"
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "lghthvy2"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.33"
                                    LuaKey.String "spark_maxunits", LuaValue.String "8"
                                    LuaKey.String "spark_range", LuaValue.String "75"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 57.0
                                ]
                        ]
                    LuaKey.String "empflashbang", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Expr ".8"
                            LuaKey.String "beamttl", LuaValue.Number 0.8
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collideground", LuaValue.Bool false
                            LuaKey.String "collideneutral", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.001
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "EMP Damage-Mitigating Flashbang"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 3.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "rgbcolor", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "xplosml5"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "backlauncher"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "LONGGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SHORTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMPFLASHBANG"
                            LuaKey.String "onlytargetcategory", LuaValue.String "COMMANDER"
                        ]
                ]
        ]

    let armcomlvl8 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 90000.0
            LuaKey.String "metalcost", LuaValue.Number 9000.0
            LuaKey.String "builddistance", LuaValue.Number 201.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 162000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canselfrepair", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 850.0
            LuaKey.String "energystorage", LuaValue.Number 5000.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "armcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 11400.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 34.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOMHILVL.lua"
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
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"armmoho\",\r\n\t\t\t\"armadvsol\",\r\n\t\t\t\"armwin\",\r\n\t\t\t\"armfus\",\r\n\t\t\t\"armmmkr\",\r\n\t\t\t\"armageo\",\r\n\t\t\t\"armamex\",\r\n\t\t\t\"armtide\",\r\n\t\t\t\"armuwadves\",\r\n\t\t\t\"armuwadvms\",\r\n\t\t\t\"armuwmmm\",\r\n\t\t\t\"armlab\",\r\n\t\t\t\"armvp\",\r\n\t\t\t\"armap\",\r\n\t\t\t\"armeyes\",\r\n\t\t\t\"armarad\",\r\n\t\t\t\"armmine1\",\r\n\t\t\t\"armmine2\",\r\n\t\t\t\"armmine3\",\r\n\t\t\t\"armdrag\",\r\n\t\t\t\"armfort\",\r\n\t\t\t\"armjamt\",\r\n\t\t\t\"armclaw\",\r\n\t\t\t\"armbeamer\",\r\n\t\t\t\"armpb\",\r\n\t\t\t\"armanni\",\r\n\t\t\t\"armatl\",\r\n\t\t\t\"armflak\",\r\n\t\t\t\"armmercury\",\r\n\t\t\t\"armdl\",\r\n\t\t\t\"armamb\",\r\n\t\t\t\"armjuno\",\r\n\t\t\t\"armfflak\",\r\n\t\t\t\"armuwmme\",\r\n\t\t\t\"armuwageo\",\r\n\t\t\t\"armsy\",\r\n\t\t\t\"armnanotc\",\r\n\t\t\t\"armnanotcplat\",\r\n\t\t\t\"armfdrag\",\r\n\t\t\t\"armfrad\",\r\n\t\t\t\"armhp\",\r\n\t\t\t\"armfhp\",\r\n\t\t\t\"armdecom\",\r\n\t\t\t\"armshockwave\",\r\n\t\t\t\"armgate\",\r\n\t\t\t\"armlwall\",\r\n\t\t\t\"armannit3\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "armmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 8.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "armcomlvl9"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 660000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.5
                    LuaKey.String "childreninheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "parentsinheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "workertimeboost", LuaValue.Number 3.5
                    LuaKey.String "wtboostunittype", LuaValue.String "TURRET MOBILE"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 36000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
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
                            LuaKey.Int 4, LuaValue.String "custom:genericshellexplosion-huge-lightning"
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
                    LuaKey.String "backlauncher", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 102.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 70.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.61
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 7.4
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 8.0
                            LuaKey.String "smoketime", LuaValue.Number 30.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 250.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.6
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 920.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 5.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 2300.0
                                ]
                        ]
                    LuaKey.String "longgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 5.05
                            LuaKey.String "name", LuaValue.String "Arcing Stun Beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "hackshot"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw2"
                            LuaKey.String "soundstartvolume", LuaValue.Number 30.0
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 40.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 30.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 60000.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 70.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.5
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UWSupernovaBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "0.1 0.2 0.7"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.9 0.9"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1400.0
                                    LuaKey.String "subs", LuaValue.Number 700.0
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
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                    LuaKey.String "shortgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 5.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "name", LuaValue.String "Short-Range Lightening Discharge"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "1.0, 0.7, 0.0"
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "lghthvy2"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.33"
                                    LuaKey.String "spark_maxunits", LuaValue.String "8"
                                    LuaKey.String "spark_range", LuaValue.String "100"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 72.0
                                ]
                        ]
                    LuaKey.String "empflashbang", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Expr ".8"
                            LuaKey.String "beamttl", LuaValue.Number 0.8
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collideground", LuaValue.Bool false
                            LuaKey.String "collideneutral", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.001
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "EMP Damage-Mitigating Flashbang"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 3.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "rgbcolor", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "xplosml5"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "backlauncher"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "LONGGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SHORTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMPFLASHBANG"
                            LuaKey.String "onlytargetcategory", LuaValue.String "COMMANDER"
                        ]
                ]
        ]

    let armcomlvl9 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 100000.0
            LuaKey.String "metalcost", LuaValue.Number 10000.0
            LuaKey.String "builddistance", LuaValue.Number 209.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "ARMCOM.DDS"
            LuaKey.String "buildtime", LuaValue.Number 178000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "canselfrepair", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 1375.0
            LuaKey.String "energystorage", LuaValue.Number 7500.0
            LuaKey.String "explodeas", LuaValue.String "commanderExplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "armcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 12300.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 42.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/ARMCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1200.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "releaseheld", LuaValue.Bool true
            LuaKey.String "script", LuaValue.String "Units/ARMCOMHILVL.lua"
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
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"armmoho\",\r\n\t\t\t\"armadvsol\",\r\n\t\t\t\"armwin\",\r\n\t\t\t\"armfus\",\r\n\t\t\t\"armmmkr\",\r\n\t\t\t\"armageo\",\r\n\t\t\t\"armamex\",\r\n\t\t\t\"armtide\",\r\n\t\t\t\"armuwadves\",\r\n\t\t\t\"armuwadvms\",\r\n\t\t\t\"armuwmmm\",\r\n\t\t\t\"armlab\",\r\n\t\t\t\"armvp\",\r\n\t\t\t\"armap\",\r\n\t\t\t\"armeyes\",\r\n\t\t\t\"armarad\",\r\n\t\t\t\"armmine1\",\r\n\t\t\t\"armmine2\",\r\n\t\t\t\"armmine3\",\r\n\t\t\t\"armdrag\",\r\n\t\t\t\"armfort\",\r\n\t\t\t\"armjamt\",\r\n\t\t\t\"armclaw\",\r\n\t\t\t\"armbeamer\",\r\n\t\t\t\"armpb\",\r\n\t\t\t\"armanni\",\r\n\t\t\t\"armatl\",\r\n\t\t\t\"armflak\",\r\n\t\t\t\"armmercury\",\r\n\t\t\t\"armdl\",\r\n\t\t\t\"armamb\",\r\n\t\t\t\"armjuno\",\r\n\t\t\t\"armfflak\",\r\n\t\t\t\"armuwmme\",\r\n\t\t\t\"armuwageo\",\r\n\t\t\t\"armsy\",\r\n\t\t\t\"armnanotc\",\r\n\t\t\t\"armnanotcplat\",\r\n\t\t\t\"armfdrag\",\r\n\t\t\t\"armfrad\",\r\n\t\t\t\"armhp\",\r\n\t\t\t\"armfhp\",\r\n\t\t\t\"armdecom\",\r\n\t\t\t\"armshockwave\",\r\n\t\t\t\"armgate\",\r\n\t\t\t\"armlwall\",\r\n\t\t\t\"armannit3\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "armmex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 9.0
                    LuaKey.String "model_author", LuaValue.String "FireStorm"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/Arm_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "armcomlvl10"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 800000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "inheritxpratemultiplier", LuaValue.Number 0.5
                    LuaKey.String "childreninheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "parentsinheritxp", LuaValue.String "TURRET MOBILEBUILT"
                    LuaKey.String "workertimeboost", LuaValue.Number 3.5
                    LuaKey.String "wtboostunittype", LuaValue.String "TURRET MOBILE"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
                            LuaKey.String "damage", LuaValue.Number 40000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/armcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
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
                            LuaKey.Int 4, LuaValue.String "custom:genericshellexplosion-huge-lightning"
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
                    LuaKey.String "backlauncher", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 111.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "cegtag", LuaValue.String "missiletrailmedium-starburst"
                            LuaKey.String "craterareaofeffect", LuaValue.Number 70.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.61
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-bomb"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "flighttime", LuaValue.Number 7.4
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "model", LuaValue.String "corkbmissl1.s3o"
                            LuaKey.String "name", LuaValue.String "HeavyRockets"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 870.0
                            LuaKey.String "reloadtime", LuaValue.Number 2.0
                            LuaKey.String "smoketrail", LuaValue.Bool true
                            LuaKey.String "smokePeriod", LuaValue.Number 8.0
                            LuaKey.String "smoketime", LuaValue.Number 30.0
                            LuaKey.String "smokesize", LuaValue.Number 12.0
                            LuaKey.String "smokecolor", LuaValue.Number 0.7
                            LuaKey.String "smokeTrailCastShadow", LuaValue.Bool true
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splssml"
                            LuaKey.String "soundstart", LuaValue.String "Rockhvy1"
                            LuaKey.String "stockpile", LuaValue.Bool true
                            LuaKey.String "stockpiletime", LuaValue.Number 10.0
                            LuaKey.String "texture1", LuaValue.String "null"
                            LuaKey.String "texture2", LuaValue.String "smoketrailbar"
                            LuaKey.String "texture3", LuaValue.String "null"
                            LuaKey.String "turnrate", LuaValue.Number 15000.0
                            LuaKey.String "weaponacceleration", LuaValue.Number 250.0
                            LuaKey.String "weapontimer", LuaValue.Number 1.74
                            LuaKey.String "weapontype", LuaValue.String "StarburstLauncher"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1000.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "overrange_distance", LuaValue.Number 1001.0
                                    LuaKey.String "projectile_destruction_method", LuaValue.String "descend"
                                    LuaKey.String "stockpilelimit", LuaValue.Number 5.0
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 3600.0
                                ]
                        ]
                    LuaKey.String "longgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 60.0
                            LuaKey.String "beamtime", LuaValue.Number 0.15
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.23
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-emp"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "largebeamlaser", LuaValue.Bool true
                            LuaKey.String "laserflaresize", LuaValue.Number 5.05
                            LuaKey.String "name", LuaValue.String "Arcing Stun Beam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 7.0
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 8.0
                            LuaKey.String "rgbcolor", LuaValue.String "0.7 0.7 1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "hackshot"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "lasrcrw2"
                            LuaKey.String "soundstartvolume", LuaValue.Number 30.0
                            LuaKey.String "soundhitdryvolume", LuaValue.Number 40.0
                            LuaKey.String "soundhitwetvolume", LuaValue.Number 30.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "texture3", LuaValue.String "largebeam"
                            LuaKey.String "thickness", LuaValue.Number 3.0
                            LuaKey.String "tilelength", LuaValue.Number 150.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 60000.0
                                ]
                        ]
                    LuaKey.String "armcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 70.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UWSupernovaBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.33
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.3 0.8"
                            LuaKey.String "rgbcolor2", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1400.0
                                    LuaKey.String "subs", LuaValue.Number 700.0
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
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor1", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "Plasma repulsor"
                            LuaKey.String "range", LuaValue.Number 50.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.25
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 479.0
                                    LuaKey.String "power", LuaValue.Number 1000.0
                                    LuaKey.String "powerregen", LuaValue.Number 20.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 0.0
                                    LuaKey.String "radius", LuaValue.Number 30.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1000.0
                                    LuaKey.String "visible", LuaValue.Bool false
                                    LuaKey.String "visiblehitframes", LuaValue.Number 0.0
                                    LuaKey.String "badcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 1.0
                                            LuaKey.Int 2, LuaValue.Number 0.2
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.25
                                        ]
                                    LuaKey.String "goodcolor", LuaValue.Table [
                                            LuaKey.Int 1, LuaValue.Number 0.2
                                            LuaKey.Int 2, LuaValue.Number 1.0
                                            LuaKey.Int 3, LuaValue.Number 0.2
                                            LuaKey.Int 4, LuaValue.Number 0.2
                                        ]
                                ]
                        ]
                    LuaKey.String "shortgun", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 8.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamttl", LuaValue.Number 1.0
                            LuaKey.String "burst", LuaValue.Number 3.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "duration", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 5.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-lightning2"
                            LuaKey.String "firestarter", LuaValue.Number 50.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 24.0
                            LuaKey.String "name", LuaValue.String "Short-Range Lightening Discharge"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.1
                            LuaKey.String "rgbcolor", LuaValue.String "1.0, 0.7, 0.0"
                            LuaKey.String "soundhit", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "lghthvy2"
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "thickness", LuaValue.Number 1.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LightningCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 400.0
                            LuaKey.String "customparams", LuaValue.Table [
                                    LuaKey.String "spark_ceg", LuaValue.String "genericshellexplosion-splash-lightning"
                                    LuaKey.String "spark_forkdamage", LuaValue.String "0.33"
                                    LuaKey.String "spark_maxunits", LuaValue.String "12"
                                    LuaKey.String "spark_range", LuaValue.String "100"
                                ]
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 88.0
                                ]
                        ]
                    LuaKey.String "empflashbang", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamdecay", LuaValue.Expr ".8"
                            LuaKey.String "beamttl", LuaValue.Number 0.8
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "collideenemy", LuaValue.Bool false
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "collideground", LuaValue.Bool false
                            LuaKey.String "collideneutral", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 1.0
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.001
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-huge-lightning"
                            LuaKey.String "falloffrate", LuaValue.Number 0.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.8
                            LuaKey.String "name", LuaValue.String "EMP Damage-Mitigating Flashbang"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "paralyzer", LuaValue.Bool true
                            LuaKey.String "paralyzetime", LuaValue.Number 8.0
                            LuaKey.String "range", LuaValue.Number 3.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.25
                            LuaKey.String "rgbcolor", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String ""
                            LuaKey.String "soundstart", LuaValue.String "xplosml5"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 6.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "LaserCannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 20000.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "MOBILE"
                            LuaKey.String "def", LuaValue.String "backlauncher"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "ARMCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "GROUNDSCOUT"
                            LuaKey.String "def", LuaValue.String "LONGGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "EMPABLE"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "SHORTGUN"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "EMPFLASHBANG"
                            LuaKey.String "onlytargetcategory", LuaValue.String "COMMANDER"
                        ]
                ]
        ]

    let corcomlvl10 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 110000.0
            LuaKey.String "metalcost", LuaValue.Number 11000.0
            LuaKey.String "builddistance", LuaValue.Number 217.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 240000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 2000.0
            LuaKey.String "energystorage", LuaValue.Number 10000.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "corcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 20000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 47.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 50.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1500.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOMHILVL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "sonardistance", LuaValue.Number 700.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 1800.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"cormoho\",\r\n\t\t\t\"coradvsol\",\r\n\t\t\t\"corwin\",\r\n\t\t\t\"corageo\",\r\n\t\t\t\"cormmkr\",\r\n\t\t\t\"coruwadves\",\r\n\t\t\t\"coruwadvms\",\r\n\t\t\t\"cortide\",\r\n\t\t\t\"cormexp\",\r\n\t\t\t\"coruwmmm\", \r\n\t\t\t\"coruwmme\",\r\n\t\t\t\"corarad\", \r\n\t\t\t\"coreyes\", \r\n\t\t\t\"cordrag\",\r\n\t\t\t\"corfort\",\r\n\t\t\t\"cormaw\", \r\n\t\t\t\"corhllt\", \r\n\t\t\t\"corvipe\", \r\n\t\t\t\"cordoom\", \r\n\t\t\t\"cortoast\", \r\n\t\t\t\"corflak\", \r\n\t\t\t\"corscreamer\", \r\n\t\t\t\"cordl\", \r\n\t\t\t\"corshroud\", \r\n\t\t\t\"corjuno\",\r\n\t\t\t\"corlab\",\r\n\t\t\t\"corvp\",\r\n\t\t\t\"corap\",\r\n\t\t\t\"coratl\", \r\n\t\t\t\"corenaa\", \r\n\t\t\t\"corfrad\",\r\n\t\t\t\"corfus\",\r\n\t\t\t\"corsy\",\r\n\t\t\t\"cornanotc\",\r\n\t\t\t\"corhp\",\r\n\t\t\t\"corfdrag\",\r\n\t\t\t\"cornanotcplat\",\r\n\t\t\t\"corfhp\",\r\n\t\t\t\"coruwageo\",\r\n\t\t\t\"corgate\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "cormoho"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 10.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 57000.0
                    LuaKey.String "shield_radius", LuaValue.Number 100.0
                    LuaKey.String "maxrange", LuaValue.String "500"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 44000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
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
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "accuracy", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "bouncerebound", LuaValue.Number 1.0
                            LuaKey.String "cegtag", LuaValue.String "demonflame"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.01
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblackxl"
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "flameGFXTime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.85
                            LuaKey.String "name", LuaValue.String "Long range AoE flamethrower"
                            LuaKey.String "noexplode", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.39996
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 1.1
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 9.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 7.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 120.0
                                    LuaKey.String "subs", LuaValue.Number 49.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 70.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.6
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UWSupernovaBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "0.5 0.7 0.10"
                            LuaKey.String "rgbcolor2", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1400.0
                                    LuaKey.String "subs", LuaValue.Number 700.0
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
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "corcomeyelaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.033
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.35
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firetolerance", LuaValue.Number 300.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.0
                            LuaKey.String "name", LuaValue.String "EyeLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 870.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.033
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray3burn"
                            LuaKey.String "soundstartvolume", LuaValue.Number 11.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 80.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 8191.0
                                    LuaKey.String "power", LuaValue.Number 57000.0
                                    LuaKey.String "powerregen", LuaValue.Number 1250.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 100.0
                                    LuaKey.String "radius", LuaValue.Number 100.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 57000.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool false
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
                    LuaKey.String "armcannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 292.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 292.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy2"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 310.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 2000.0
                                    LuaKey.String "subs", LuaValue.Number 400.0
                                    LuaKey.String "vtol", LuaValue.Number 150.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "commander"
                            LuaKey.String "def", LuaValue.String "CORCOMEYELASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let corcomlvl2 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 30000.0
            LuaKey.String "metalcost", LuaValue.Number 3000.0
            LuaKey.String "builddistance", LuaValue.Number 153.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 112500.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "energymake", LuaValue.Number 50.0
            LuaKey.String "energystorage", LuaValue.Number 1000.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "corcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 6000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 3.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.Expr "\"Units/CORCOM\"..(Spring.GetModOptions().xmas and '-XMAS' or '')..\".s3o\""
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOM.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 450.0
            LuaKey.String "sonardistance", LuaValue.Number 450.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 366.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "corsolar"
                    LuaKey.Int 2, LuaValue.String "corwin"
                    LuaKey.Int 3, LuaValue.String "cormstor"
                    LuaKey.Int 4, LuaValue.String "corestor"
                    LuaKey.Int 5, LuaValue.String "cormex"
                    LuaKey.Int 6, LuaValue.String "cormakr"
                    LuaKey.Int 7, LuaValue.String "corlab"
                    LuaKey.Int 8, LuaValue.String "corvp"
                    LuaKey.Int 9, LuaValue.String "corap"
                    LuaKey.Int 10, LuaValue.String "coreyes"
                    LuaKey.Int 11, LuaValue.String "corrad"
                    LuaKey.Int 12, LuaValue.String "cordrag"
                    LuaKey.Int 13, LuaValue.String "corllt"
                    LuaKey.Int 14, LuaValue.String "corrl"
                    LuaKey.Int 15, LuaValue.String "cordl"
                    LuaKey.Int 16, LuaValue.String "cortide"
                    LuaKey.Int 17, LuaValue.String "coruwms"
                    LuaKey.Int 18, LuaValue.String "coruwes"
                    LuaKey.Int 20, LuaValue.String "corfmkr"
                    LuaKey.Int 21, LuaValue.String "corsy"
                    LuaKey.Int 22, LuaValue.String "corfdrag"
                    LuaKey.Int 23, LuaValue.String "cortl"
                    LuaKey.Int 24, LuaValue.String "corfrt"
                    LuaKey.Int 25, LuaValue.String "corfrad"
                    LuaKey.Int 26, LuaValue.String "corhp"
                    LuaKey.Int 27, LuaValue.String "corfhp"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "cormex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 2.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "corcomlvl3"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 22000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 1900.0
                    LuaKey.String "shield_radius", LuaValue.Number 100.0
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 12000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
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
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "beamttl", LuaValue.Number 2.4
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.21
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "HighEnergyLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "rgbcolor", LuaValue.String "0.027 0.40 0.027"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1 0.9"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Lasrmas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 215.0
                                    LuaKey.String "subs", LuaValue.Number 85.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.3
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 300.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.5
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 200.0
                                    LuaKey.String "subs", LuaValue.Number 100.0
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
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 8191.0
                                    LuaKey.String "power", LuaValue.Number 1900.0
                                    LuaKey.String "powerregen", LuaValue.Number 83.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 6.6
                                    LuaKey.String "radius", LuaValue.Number 100.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 1900.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool false
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
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                ]
        ]

    let corcomlvl3 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 40000.0
            LuaKey.String "metalcost", LuaValue.Number 4000.0
            LuaKey.String "builddistance", LuaValue.Number 161.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 120000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 75.0
            LuaKey.String "energystorage", LuaValue.Number 1500.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "corcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 6000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 5.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOMHILVL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "sonardistance", LuaValue.Number 550.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 450.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "cormex"
                    LuaKey.Int 2, LuaValue.String "corsolar"
                    LuaKey.Int 3, LuaValue.String "corwin"
                    LuaKey.Int 4, LuaValue.String "coradvsol"
                    LuaKey.Int 5, LuaValue.String "corgeo"
                    LuaKey.Int 6, LuaValue.String "cormakr"
                    LuaKey.Int 7, LuaValue.String "corestor"
                    LuaKey.Int 8, LuaValue.String "coruwms"
                    LuaKey.Int 9, LuaValue.String "cortide"
                    LuaKey.Int 10, LuaValue.String "corexp"
                    LuaKey.Int 11, LuaValue.String "cormstor"
                    LuaKey.Int 12, LuaValue.String "coruwes"
                    LuaKey.Int 13, LuaValue.String "corfmkr"
                    LuaKey.Int 14, LuaValue.String "coreyes"
                    LuaKey.Int 15, LuaValue.String "corrad"
                    LuaKey.Int 16, LuaValue.String "cordrag"
                    LuaKey.Int 17, LuaValue.String "cormaw"
                    LuaKey.Int 18, LuaValue.String "corllt"
                    LuaKey.Int 19, LuaValue.String "corhllt"
                    LuaKey.Int 20, LuaValue.String "corhlt"
                    LuaKey.Int 21, LuaValue.String "corpun"
                    LuaKey.Int 22, LuaValue.String "corfrock"
                    LuaKey.Int 23, LuaValue.String "cormadsam"
                    LuaKey.Int 24, LuaValue.String "corerad"
                    LuaKey.Int 25, LuaValue.String "cordl"
                    LuaKey.Int 26, LuaValue.String "corjamt"
                    LuaKey.Int 27, LuaValue.String "corjuno"
                    LuaKey.Int 28, LuaValue.String "corlab"
                    LuaKey.Int 29, LuaValue.String "corvp"
                    LuaKey.Int 30, LuaValue.String "corap"
                    LuaKey.Int 31, LuaValue.String "cortl"
                    LuaKey.Int 32, LuaValue.String "corfrt"
                    LuaKey.Int 33, LuaValue.String "corfrad"
                    LuaKey.Int 34, LuaValue.String "corsy"
                    LuaKey.Int 35, LuaValue.String "cornanotc"
                    LuaKey.Int 36, LuaValue.String "corhp"
                    LuaKey.Int 37, LuaValue.String "corfdrag"
                    LuaKey.Int 38, LuaValue.String "cornanotcplat"
                    LuaKey.Int 39, LuaValue.String "corfhp"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "cormex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 3.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "corcomlvl4"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 53000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 6270.0
                    LuaKey.String "shield_radius", LuaValue.Number 100.0
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 16000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
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
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "beamttl", LuaValue.Number 2.4
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.21
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "HighEnergyLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.4
                            LuaKey.String "rgbcolor", LuaValue.String "0.027 0.40 0.027"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1 0.9"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Lasrmas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 380.0
                                    LuaKey.String "subs", LuaValue.Number 125.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "beamttl", LuaValue.Number 2.4
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.46
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.8 0.3"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
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
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "corcomeyelaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.12
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 20.0
                            LuaKey.String "name", LuaValue.String "Eye laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
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
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 75.0
                                    LuaKey.String "subs", LuaValue.Number 18.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 8191.0
                                    LuaKey.String "power", LuaValue.Number 6270.0
                                    LuaKey.String "powerregen", LuaValue.Number 188.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 15.0
                                    LuaKey.String "radius", LuaValue.Number 100.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 6270.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool false
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
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMEYELASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let corcomlvl4 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 50000.0
            LuaKey.String "metalcost", LuaValue.Number 5000.0
            LuaKey.String "builddistance", LuaValue.Number 169.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 140000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 125.0
            LuaKey.String "energystorage", LuaValue.Number 2000.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "corcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 8000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 37.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 9.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 700.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOMHILVL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "sonardistance", LuaValue.Number 550.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 545.0
            LuaKey.String "buildoptions", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.String "cormex"
                    LuaKey.Int 2, LuaValue.String "corsolar"
                    LuaKey.Int 3, LuaValue.String "corwin"
                    LuaKey.Int 4, LuaValue.String "coradvsol"
                    LuaKey.Int 5, LuaValue.String "corgeo"
                    LuaKey.Int 6, LuaValue.String "cormakr"
                    LuaKey.Int 7, LuaValue.String "corestor"
                    LuaKey.Int 8, LuaValue.String "coruwms"
                    LuaKey.Int 9, LuaValue.String "cortide"
                    LuaKey.Int 10, LuaValue.String "corexp"
                    LuaKey.Int 11, LuaValue.String "cormstor"
                    LuaKey.Int 12, LuaValue.String "coruwes"
                    LuaKey.Int 13, LuaValue.String "corfmkr"
                    LuaKey.Int 14, LuaValue.String "coreyes"
                    LuaKey.Int 15, LuaValue.String "corrad"
                    LuaKey.Int 16, LuaValue.String "cordrag"
                    LuaKey.Int 17, LuaValue.String "cormaw"
                    LuaKey.Int 18, LuaValue.String "corllt"
                    LuaKey.Int 19, LuaValue.String "corhllt"
                    LuaKey.Int 20, LuaValue.String "corhlt"
                    LuaKey.Int 21, LuaValue.String "corpun"
                    LuaKey.Int 22, LuaValue.String "corfrock"
                    LuaKey.Int 23, LuaValue.String "cormadsam"
                    LuaKey.Int 24, LuaValue.String "corerad"
                    LuaKey.Int 25, LuaValue.String "cordl"
                    LuaKey.Int 26, LuaValue.String "corjamt"
                    LuaKey.Int 27, LuaValue.String "corjuno"
                    LuaKey.Int 28, LuaValue.String "corlab"
                    LuaKey.Int 29, LuaValue.String "corvp"
                    LuaKey.Int 30, LuaValue.String "corap"
                    LuaKey.Int 31, LuaValue.String "cortl"
                    LuaKey.Int 32, LuaValue.String "corfrt"
                    LuaKey.Int 33, LuaValue.String "corfrad"
                    LuaKey.Int 34, LuaValue.String "corsy"
                    LuaKey.Int 35, LuaValue.String "cornanotc"
                    LuaKey.Int 36, LuaValue.String "corhp"
                    LuaKey.Int 37, LuaValue.String "corfdrag"
                    LuaKey.Int 38, LuaValue.String "cornanotcplat"
                    LuaKey.Int 39, LuaValue.String "corfhp"
                ]
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "cormex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 4.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 10450.0
                    LuaKey.String "shield_radius", LuaValue.Number 100.0
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "corcomlvl5"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 105000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 20000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
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
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "collidefeature", LuaValue.Bool false
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.21
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-green"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "HighEnergyLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 350.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.33
                            LuaKey.String "rgbcolor", LuaValue.String "0.027 0.40 0.027"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 1 0.9"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Lasrmas2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 550.0
                                    LuaKey.String "subs", LuaValue.Number 275.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "beamttl", LuaValue.Number 2.4
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.1
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 1.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-blue"
                            LuaKey.String "firestarter", LuaValue.Number 35.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.3
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "J7NSLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 450.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.42
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.8 0.3"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 5.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
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
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "corcomeyelaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 12.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.12
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 20.0
                            LuaKey.String "name", LuaValue.String "Eye laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 550.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.306
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
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 85.0
                                    LuaKey.String "subs", LuaValue.Number 22.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 8191.0
                                    LuaKey.String "power", LuaValue.Number 10450.0
                                    LuaKey.String "powerregen", LuaValue.Number 313.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 25.0
                                    LuaKey.String "radius", LuaValue.Number 100.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 10450.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool false
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
                    LuaKey.String "armcannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 144.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 292.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "soundhit", LuaValue.String "corlevlrhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "corlevlr"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 310.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 450.0
                                    LuaKey.String "subs", LuaValue.Number 225.0
                                    LuaKey.String "vtol", LuaValue.Number 45.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMEYELASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let corcomlvl5 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 60000.0
            LuaKey.String "metalcost", LuaValue.Number 6000.0
            LuaKey.String "builddistance", LuaValue.Number 177.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 154800.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 200.0
            LuaKey.String "energystorage", LuaValue.Number 2500.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "corcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 10000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 39.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 14.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOMHILVL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "sonardistance", LuaValue.Number 550.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 665.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"cormoho\",\r\n\t\t\t\"coradvsol\",\r\n\t\t\t\"corwin\",\r\n\t\t\t\"corageo\",\r\n\t\t\t\"cormmkr\",\r\n\t\t\t\"coruwadves\",\r\n\t\t\t\"coruwadvms\",\r\n\t\t\t\"cortide\",\r\n\t\t\t\"cormexp\",\r\n\t\t\t\"coruwmmm\",\r\n\t\t\t\"coruwmme\",\r\n\t\t\t\"corarad\",\r\n\t\t\t\"coreyes\",\r\n\t\t\t\"cordrag\",\r\n\t\t\t\"corfort\",\r\n\t\t\t\"cormaw\",\r\n\t\t\t\"corhllt\",\r\n\t\t\t\"corvipe\",\r\n\t\t\t\"cordoom\",\r\n\t\t\t\"cortoast\",\r\n\t\t\t\"corflak\",\r\n\t\t\t\"corscreamer\",\r\n\t\t\t\"cordl\",\r\n\t\t\t\"corshroud\",\r\n\t\t\t\"corjuno\",\r\n\t\t\t\"corlab\",\r\n\t\t\t\"corvp\",\r\n\t\t\t\"corap\",\r\n\t\t\t\"coratl\",\r\n\t\t\t\"corenaa\",\r\n\t\t\t\"corfrad\",\r\n\t\t\t\"corfus\",\r\n\t\t\t\"corsy\",\r\n\t\t\t\"cornanotc\",\r\n\t\t\t\"corhp\",\r\n\t\t\t\"corfdrag\",\r\n\t\t\t\"cornanotcplat\",\r\n\t\t\t\"corfhp\",\r\n\t\t\t\"coruwageo\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "cormex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 5.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 13300.0
                    LuaKey.String "shield_radius", LuaValue.Number 100.0
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "corcomlvl6"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 260000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 24000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
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
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 80.0
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
                            LuaKey.String "name", LuaValue.String "Anti-swarm AoE flamethrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 1.1
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 0.5
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 5.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "texture1", LuaValue.String "flame"
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 90.0
                                    LuaKey.String "subs", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 42.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UltravioletRayBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.92
                            LuaKey.String "rgbcolor", LuaValue.String "0.6 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1200.0
                                    LuaKey.String "subs", LuaValue.Number 600.0
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
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "corcomeyelaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 16.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.2
                            LuaKey.String "corethickness", LuaValue.Number 0.175
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-small-red"
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "impactonly", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 20.0
                            LuaKey.String "name", LuaValue.String "Eye laser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 620.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.19
                            LuaKey.String "rgbcolor", LuaValue.String "1 0 0"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "beamershot2"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 2.0
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 2250.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 120.0
                                    LuaKey.String "subs", LuaValue.Number 30.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 8191.0
                                    LuaKey.String "power", LuaValue.Number 13300.0
                                    LuaKey.String "powerregen", LuaValue.Number 500.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 40.0
                                    LuaKey.String "radius", LuaValue.Number 100.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 13300.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool false
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
                    LuaKey.String "armcannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 144.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 292.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "soundhit", LuaValue.String "corlevlrhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "corlevlr"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 310.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 450.0
                                    LuaKey.String "subs", LuaValue.Number 150.0
                                    LuaKey.String "vtol", LuaValue.Number 30.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "commander"
                            LuaKey.String "def", LuaValue.String "CORCOMEYELASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let corcomlvl6 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 70000.0
            LuaKey.String "metalcost", LuaValue.Number 7000.0
            LuaKey.String "builddistance", LuaValue.Number 185.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 182000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 325.0
            LuaKey.String "energystorage", LuaValue.Number 3000.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "corcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 12000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 40.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 20.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOMHILVL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "sonardistance", LuaValue.Number 550.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 810.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"cormoho\",\r\n\t\t\t\"coradvsol\",\r\n\t\t\t\"corwin\",\r\n\t\t\t\"corageo\",\r\n\t\t\t\"cormmkr\",\r\n\t\t\t\"coruwadves\",\r\n\t\t\t\"coruwadvms\",\r\n\t\t\t\"cortide\",\r\n\t\t\t\"cormexp\",\r\n\t\t\t\"coruwmmm\",\r\n\t\t\t\"coruwmme\",\r\n\t\t\t\"corarad\",\r\n\t\t\t\"coreyes\",\r\n\t\t\t\"cordrag\",\r\n\t\t\t\"corfort\",\r\n\t\t\t\"cormaw\",\r\n\t\t\t\"corhllt\",\r\n\t\t\t\"corvipe\",\r\n\t\t\t\"cordoom\",\r\n\t\t\t\"cortoast\",\r\n\t\t\t\"corflak\",\r\n\t\t\t\"corscreamer\",\r\n\t\t\t\"cordl\",\r\n\t\t\t\"corshroud\",\r\n\t\t\t\"corjuno\",\r\n\t\t\t\"corlab\",\r\n\t\t\t\"corvp\",\r\n\t\t\t\"corap\",\r\n\t\t\t\"coratl\",\r\n\t\t\t\"corenaa\",\r\n\t\t\t\"corfrad\",\r\n\t\t\t\"corfus\",\r\n\t\t\t\"corsy\",\r\n\t\t\t\"cornanotc\",\r\n\t\t\t\"corhp\",\r\n\t\t\t\"corfdrag\",\r\n\t\t\t\"cornanotcplat\",\r\n\t\t\t\"corfhp\",\r\n\t\t\t\"coruwageo\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "cormex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 6.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 19000.0
                    LuaKey.String "shield_radius", LuaValue.Number 100.0
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "corcomlvl7"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 390000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 28000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
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
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 80.0
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
                            LuaKey.String "name", LuaValue.String "Anti-swarm AoE flamethrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.95
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 0.75
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 5.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "texture1", LuaValue.String "flame"
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 90.0
                                    LuaKey.String "subs", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 42.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UltravioletRayBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.7
                            LuaKey.String "rgbcolor", LuaValue.String "0.6 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1200.0
                                    LuaKey.String "subs", LuaValue.Number 600.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
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
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "corcomeyelaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.033
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.3
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firetolerance", LuaValue.Number 300.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 5.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.0
                            LuaKey.String "name", LuaValue.String "EyeLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 730.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.033
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.2 0.2"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0.1 0.1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray3burn"
                            LuaKey.String "soundstartvolume", LuaValue.Number 11.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 26.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 8191.0
                                    LuaKey.String "power", LuaValue.Number 19000.0
                                    LuaKey.String "powerregen", LuaValue.Number 625.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 50.0
                                    LuaKey.String "radius", LuaValue.Number 100.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 19000.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool false
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
                    LuaKey.String "armcannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 144.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 292.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 600.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "soundhit", LuaValue.String "corlevlrhit"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "corlevlr"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 310.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 675.0
                                    LuaKey.String "subs", LuaValue.Number 180.0
                                    LuaKey.String "vtol", LuaValue.Number 60.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMEYELASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let corcomlvl7 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 80000.0
            LuaKey.String "metalcost", LuaValue.Number 8000.0
            LuaKey.String "builddistance", LuaValue.Number 193.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 210000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 525.0
            LuaKey.String "energystorage", LuaValue.Number 3500.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "corcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 14000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 42.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 27.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1000.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOMHILVL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 550.0
            LuaKey.String "sonardistance", LuaValue.Number 550.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 990.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"cormoho\",\r\n\t\t\t\"coradvsol\",\r\n\t\t\t\"corwin\",\r\n\t\t\t\"corageo\",\r\n\t\t\t\"cormmkr\",\r\n\t\t\t\"coruwadves\",\r\n\t\t\t\"coruwadvms\",\r\n\t\t\t\"cortide\",\r\n\t\t\t\"cormexp\",\r\n\t\t\t\"coruwmmm\",\r\n\t\t\t\"coruwmme\",\r\n\t\t\t\"corarad\",\r\n\t\t\t\"coreyes\",\r\n\t\t\t\"cordrag\",\r\n\t\t\t\"corfort\",\r\n\t\t\t\"cormaw\",\r\n\t\t\t\"corhllt\",\r\n\t\t\t\"corvipe\",\r\n\t\t\t\"cordoom\",\r\n\t\t\t\"cortoast\",\r\n\t\t\t\"corflak\",\r\n\t\t\t\"corscreamer\",\r\n\t\t\t\"cordl\",\r\n\t\t\t\"corshroud\",\r\n\t\t\t\"corjuno\",\r\n\t\t\t\"corlab\",\r\n\t\t\t\"corvp\",\r\n\t\t\t\"corap\",\r\n\t\t\t\"coratl\",\r\n\t\t\t\"corenaa\",\r\n\t\t\t\"corfrad\",\r\n\t\t\t\"corfus\",\r\n\t\t\t\"corsy\",\r\n\t\t\t\"cornanotc\",\r\n\t\t\t\"corhp\",\r\n\t\t\t\"corfdrag\",\r\n\t\t\t\"cornanotcplat\",\r\n\t\t\t\"corfhp\",\r\n\t\t\t\"coruwageo\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "cormex"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 7.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 24700.0
                    LuaKey.String "shield_radius", LuaValue.Number 100.0
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "corcomlvl8"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 520000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 32000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
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
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 80.0
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
                            LuaKey.String "name", LuaValue.String "Anti-swarm AoE flamethrower"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 400.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.8
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 0.8
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 7.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 5.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "sprayangle", LuaValue.Number 100.0
                            LuaKey.String "targetmoveerror", LuaValue.Number 0.001
                            LuaKey.String "texture1", LuaValue.String "flame"
                            LuaKey.String "tolerance", LuaValue.Number 2500.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 1.0
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 90.0
                                    LuaKey.String "subs", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 42.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.2
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UltravioletRayBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.55
                            LuaKey.String "rgbcolor", LuaValue.String "0.6 0.2 0.6"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.2 0.2 0.2"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1200.0
                                    LuaKey.String "subs", LuaValue.Number 600.0
                                ]
                        ]
                    LuaKey.String "disintegrator", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 36.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
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
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "corcomeyelaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.033
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.3
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firetolerance", LuaValue.Number 300.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 5.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.0
                            LuaKey.String "name", LuaValue.String "EyeLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 730.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.033
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.2 0.2"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0.1 0.1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray3burn"
                            LuaKey.String "soundstartvolume", LuaValue.Number 11.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 34.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 8191.0
                                    LuaKey.String "power", LuaValue.Number 24700.0
                                    LuaKey.String "powerregen", LuaValue.Number 770.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 61.0
                                    LuaKey.String "radius", LuaValue.Number 100.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 24700.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool false
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
                    LuaKey.String "armcannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 210.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 292.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "largegun"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 310.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 900.0
                                    LuaKey.String "subs", LuaValue.Number 200.0
                                    LuaKey.String "vtol", LuaValue.Number 50.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMEYELASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let corcomlvl8 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 90000.0
            LuaKey.String "metalcost", LuaValue.Number 9000.0
            LuaKey.String "builddistance", LuaValue.Number 201.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 230000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 850.0
            LuaKey.String "energystorage", LuaValue.Number 5000.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "corcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 16000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 43.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 34.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1500.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOMHILVL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 1200.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"cormoho\",\r\n\t\t\t\"coradvsol\",\r\n\t\t\t\"corwin\",\r\n\t\t\t\"corageo\",\r\n\t\t\t\"cormmkr\",\r\n\t\t\t\"coruwadves\",\r\n\t\t\t\"coruwadvms\",\r\n\t\t\t\"cortide\",\r\n\t\t\t\"cormexp\",\r\n\t\t\t\"coruwmmm\",\r\n\t\t\t\"coruwmme\",\r\n\t\t\t\"corarad\",\r\n\t\t\t\"coreyes\",\r\n\t\t\t\"cordrag\",\r\n\t\t\t\"corfort\",\r\n\t\t\t\"cormaw\",\r\n\t\t\t\"corhllt\",\r\n\t\t\t\"corvipe\",\r\n\t\t\t\"cordoom\",\r\n\t\t\t\"cortoast\",\r\n\t\t\t\"corflak\",\r\n\t\t\t\"corscreamer\",\r\n\t\t\t\"cordl\",\r\n\t\t\t\"corshroud\",\r\n\t\t\t\"corjuno\",\r\n\t\t\t\"corlab\",\r\n\t\t\t\"corvp\",\r\n\t\t\t\"corap\",\r\n\t\t\t\"coratl\",\r\n\t\t\t\"corenaa\",\r\n\t\t\t\"corfrad\",\r\n\t\t\t\"corfus\",\r\n\t\t\t\"corsy\",\r\n\t\t\t\"cornanotc\",\r\n\t\t\t\"corhp\",\r\n\t\t\t\"corfdrag\",\r\n\t\t\t\"cornanotcplat\",\r\n\t\t\t\"corfhp\",\r\n\t\t\t\"coruwageo\",\r\n\t\t\t\"corgate\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "cormoho"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 8.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 32300.0
                    LuaKey.String "shield_radius", LuaValue.Number 100.0
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "corcomlvl9"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 660000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "maxrange", LuaValue.String "500"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 36000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
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
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "accuracy", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "bouncerebound", LuaValue.Number 1.0
                            LuaKey.String "cegtag", LuaValue.String "demonflame"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.01
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblackxl"
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "flameGFXTime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.85
                            LuaKey.String "name", LuaValue.String "Long range AoE flamethrower"
                            LuaKey.String "noexplode", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.39996
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 1.1
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 9.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 7.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 80.0
                                    LuaKey.String "subs", LuaValue.Number 25.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 70.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.5
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UWSupernovaBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.54
                            LuaKey.String "rgbcolor", LuaValue.String "0.1 0.2 0.7"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.9 0.9"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1400.0
                                    LuaKey.String "subs", LuaValue.Number 700.0
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
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "corcomeyelaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 50.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.033
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.3
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firetolerance", LuaValue.Number 300.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 5.0
                            LuaKey.String "laserflaresize", LuaValue.Number 6.0
                            LuaKey.String "name", LuaValue.String "EyeLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 800.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.033
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.2 0.2"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0.1 0.1"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray3burn"
                            LuaKey.String "soundstartvolume", LuaValue.Number 11.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 900.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 42.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 8191.0
                                    LuaKey.String "power", LuaValue.Number 32300.0
                                    LuaKey.String "powerregen", LuaValue.Number 915.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 72.0
                                    LuaKey.String "radius", LuaValue.Number 100.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 32300.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool false
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
                    LuaKey.String "armcannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 210.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 292.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 700.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "largegun"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 310.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1050.0
                                    LuaKey.String "subs", LuaValue.Number 250.0
                                    LuaKey.String "vtol", LuaValue.Number 75.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMEYELASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let corcomlvl9 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 0.18
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 5.0
            LuaKey.String "maxdec", LuaValue.Number 1.125
            LuaKey.String "energycost", LuaValue.Number 100000.0
            LuaKey.String "metalcost", LuaValue.Number 10000.0
            LuaKey.String "builddistance", LuaValue.Number 209.0
            LuaKey.String "builder", LuaValue.Bool true
            LuaKey.String "buildpic", LuaValue.String "CORCOM.DDS"
            LuaKey.String "onoffable", LuaValue.Bool true
            LuaKey.String "buildtime", LuaValue.Number 240000.0
            LuaKey.String "cancapture", LuaValue.Bool true
            LuaKey.String "cancloak", LuaValue.Bool true
            LuaKey.String "canmanualfire", LuaValue.Bool true
            LuaKey.String "canmove", LuaValue.Bool true
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "capturespeed", LuaValue.Number 1800.0
            LuaKey.String "cloakcost", LuaValue.Number 100.0
            LuaKey.String "cloakcostmoving", LuaValue.Number 1000.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 3 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "28 52 28"
            LuaKey.String "collisionvolumetype", LuaValue.String "CylY"
            LuaKey.String "corpse", LuaValue.String "DEAD"
            LuaKey.String "damagemodifier", LuaValue.Number 0.1
            LuaKey.String "energymake", LuaValue.Number 1375.0
            LuaKey.String "energystorage", LuaValue.Number 7500.0
            LuaKey.String "explodeas", LuaValue.String "commanderexplosion"
            LuaKey.String "footprintx", LuaValue.Number 2.0
            LuaKey.String "footprintz", LuaValue.Number 2.0
            LuaKey.String "hidedamage", LuaValue.Bool true
            LuaKey.String "holdsteady", LuaValue.Bool true
            LuaKey.String "icontype", LuaValue.String "corcom"
            LuaKey.String "sightemitheight", LuaValue.Number 40.0
            LuaKey.String "mass", LuaValue.Number 4900.0
            LuaKey.String "health", LuaValue.Number 18000.0
            LuaKey.String "maxslope", LuaValue.Number 20.0
            LuaKey.String "speed", LuaValue.Number 45.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 35.0
            LuaKey.String "metalmake", LuaValue.Number 42.0
            LuaKey.String "metalstorage", LuaValue.Number 500.0
            LuaKey.String "mincloakdistance", LuaValue.Number 50.0
            LuaKey.String "movementclass", LuaValue.String "COMMANDERBOT"
            LuaKey.String "nochasecategory", LuaValue.String "ALL"
            LuaKey.String "objectname", LuaValue.String "Units/CORCOMHILVL.s3o"
            LuaKey.String "radardistance", LuaValue.Number 1500.0
            LuaKey.String "radaremitheight", LuaValue.Number 40.0
            LuaKey.String "reclaimable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Units/CORCOMHILVL.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 0.0
            LuaKey.String "selfdestructas", LuaValue.String "commanderExplosion"
            LuaKey.String "selfdestructcountdown", LuaValue.Number 5.0
            LuaKey.String "showplayername", LuaValue.Bool true
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "sonardistance", LuaValue.Number 600.0
            LuaKey.String "terraformspeed", LuaValue.Number 1500.0
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 140.0
            LuaKey.String "turninplacespeedlimit", LuaValue.Number 0.825
            LuaKey.String "turnrate", LuaValue.Number 1133.0
            LuaKey.String "upright", LuaValue.Bool true
            LuaKey.String "workertime", LuaValue.Number 1472.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"cormoho\",\r\n\t\t\t\"coradvsol\",\r\n\t\t\t\"corwin\",\r\n\t\t\t\"corageo\",\r\n\t\t\t\"cormmkr\",\r\n\t\t\t\"coruwadves\",\r\n\t\t\t\"coruwadvms\",\r\n\t\t\t\"cortide\",\r\n\t\t\t\"cormexp\",\r\n\t\t\t\"coruwmmm\", \r\n\t\t\t\"coruwmme\",\r\n\t\t\t\"corarad\", \r\n\t\t\t\"coreyes\", \r\n\t\t\t\"cordrag\",\r\n\t\t\t\"corfort\",\r\n\t\t\t\"cormaw\", \r\n\t\t\t\"corhllt\", \r\n\t\t\t\"corvipe\", \r\n\t\t\t\"cordoom\", \r\n\t\t\t\"cortoast\", \r\n\t\t\t\"corflak\", \r\n\t\t\t\"corscreamer\", \r\n\t\t\t\"cordl\", \r\n\t\t\t\"corshroud\", \r\n\t\t\t\"corjuno\",\r\n\t\t\t\"corlab\",\r\n\t\t\t\"corvp\",\r\n\t\t\t\"corap\",\r\n\t\t\t\"coratl\", \r\n\t\t\t\"corenaa\", \r\n\t\t\t\"corfrad\",\r\n\t\t\t\"corfus\",\r\n\t\t\t\"corsy\",\r\n\t\t\t\"cornanotc\",\r\n\t\t\t\"corhp\",\r\n\t\t\t\"corfdrag\",\r\n\t\t\t\"cornanotcplat\",\r\n\t\t\t\"corfhp\",\r\n\t\t\t\"coruwageo\",\r\n\t\t\t\"corgate\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "unitgroup", LuaValue.String "builder"
                    LuaKey.String "area_mex_def", LuaValue.String "cormoho"
                    LuaKey.String "iscommander", LuaValue.Bool true
                    LuaKey.String "effigy_offset", LuaValue.Number 1.0
                    LuaKey.String "evocomlvl", LuaValue.Number 9.0
                    LuaKey.String "model_author", LuaValue.String "Mr Bob"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/cor_normal.dds"
                    LuaKey.String "paralyzemultiplier", LuaValue.Number 0.025
                    LuaKey.String "subfolder", LuaValue.String ""
                    LuaKey.String "shield_color_mult", LuaValue.Number 0.8
                    LuaKey.String "shield_power", LuaValue.Number 43700.0
                    LuaKey.String "shield_radius", LuaValue.Number 100.0
                    LuaKey.String "evolution_health_transfer", LuaValue.String "percentage"
                    LuaKey.String "evolution_target", LuaValue.String "corcomlvl10"
                    LuaKey.String "evolution_condition", LuaValue.String "timer"
                    LuaKey.String "evolution_timer", LuaValue.Number 99999.0
                    LuaKey.String "evolution_power_threshold", LuaValue.Number 800000.0
                    LuaKey.String "evolution_power_multiplier", LuaValue.Number 1.0
                    LuaKey.String "combatradius", LuaValue.Number 0.0
                    LuaKey.String "maxrange", LuaValue.String "500"
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
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 40000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featuredead", LuaValue.String "HEAP"
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 20.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 1250.0
                            LuaKey.String "object", LuaValue.String "Units/corcom_dead.s3o"
                            LuaKey.String "reclaimable", LuaValue.Bool true
                            LuaKey.String "seqnamereclamate", LuaValue.String "TREE1RECLAMATE"
                            LuaKey.String "world", LuaValue.String "All Worlds"
                        ]
                    LuaKey.String "heap", LuaValue.Table [
                            LuaKey.String "blocking", LuaValue.Bool false
                            LuaKey.String "category", LuaValue.String "heaps"
                            LuaKey.String "collisionvolumescales", LuaValue.String "35 12 54"
                            LuaKey.String "collisionvolumetype", LuaValue.String "cylY"
                            LuaKey.String "damage", LuaValue.Number 5000.0
                            LuaKey.String "energy", LuaValue.Number 0.0
                            LuaKey.String "featurereclamate", LuaValue.String "SMUDGE01"
                            LuaKey.String "footprintx", LuaValue.Number 2.0
                            LuaKey.String "footprintz", LuaValue.Number 2.0
                            LuaKey.String "height", LuaValue.Number 4.0
                            LuaKey.String "hitdensity", LuaValue.Number 100.0
                            LuaKey.String "metal", LuaValue.Number 500.0
                            LuaKey.String "object", LuaValue.String "Units/cor2X2C.s3o"
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
                        ]
                ]
            LuaKey.String "sounds", LuaValue.Table [
                    LuaKey.String "build", LuaValue.String "nanlath2"
                    LuaKey.String "canceldestruct", LuaValue.String "cancel2"
                    LuaKey.String "capture", LuaValue.String "capture2"
                    LuaKey.String "cloak", LuaValue.String "kloak2"
                    LuaKey.String "repair", LuaValue.String "repair2"
                    LuaKey.String "uncloak", LuaValue.String "kloak2un"
                    LuaKey.String "underattack", LuaValue.String "warning2"
                    LuaKey.String "unitcomplete", LuaValue.String "corcomsel"
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
                            LuaKey.Int 1, LuaValue.String "corcom1"
                            LuaKey.Int 2, LuaValue.String "corcom2"
                            LuaKey.Int 3, LuaValue.String "corcom3"
                            LuaKey.Int 4, LuaValue.String "corcom4"
                            LuaKey.Int 5, LuaValue.String "corcom5"
                        ]
                    LuaKey.String "select", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "corcomsel"
                        ]
                ]
            LuaKey.String "weapondefs", LuaValue.Table [
                    LuaKey.String "corcomlaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "accuracy", LuaValue.Number 0.0
                            LuaKey.String "areaofeffect", LuaValue.Number 128.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "avoidfriendly", LuaValue.Bool true
                            LuaKey.String "burst", LuaValue.Number 12.0
                            LuaKey.String "burstrate", LuaValue.Number 0.03333
                            LuaKey.String "burnblow", LuaValue.Bool true
                            LuaKey.String "bouncerebound", LuaValue.Number 1.0
                            LuaKey.String "cegtag", LuaValue.String "demonflame"
                            LuaKey.String "colormap", LuaValue.String "1 0.95 0.9 0.032   0.55 0.55 0.40 0.028   0.40 0.28 0.19 0.024   0.033 0.018 0.011 0.04   0.0 0.0 0.0 0.01"
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.01
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:burnblackxl"
                            LuaKey.String "bounceSlip", LuaValue.Number 1.0
                            LuaKey.String "firestarter", LuaValue.Number 100.0
                            LuaKey.String "firesubmersed", LuaValue.Bool false
                            LuaKey.String "flameGFXTime", LuaValue.Number 1.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.85
                            LuaKey.String "name", LuaValue.String "Long range AoE flamethrower"
                            LuaKey.String "noexplode", LuaValue.Bool false
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "predictboost", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 475.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.39996
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.94 0.88"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.9 0.84 0.8"
                            LuaKey.String "sizegrowth", LuaValue.Number 1.1
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "Flamhvy1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 9.5
                            LuaKey.String "soundstartvolume", LuaValue.Number 7.3
                            LuaKey.String "soundtrigger", LuaValue.Bool false
                            LuaKey.String "tolerance", LuaValue.Number 20000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool false
                            LuaKey.String "weapontype", LuaValue.String "Flame"
                            LuaKey.String "weaponvelocity", LuaValue.Number 500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 96.0
                                    LuaKey.String "subs", LuaValue.Number 38.0
                                ]
                        ]
                    LuaKey.String "corcomsealaser", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 70.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.16
                            LuaKey.String "camerashake", LuaValue.Number 0.0
                            LuaKey.String "corethickness", LuaValue.Number 0.4
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "cylindertargeting", LuaValue.Number 1.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:laserhit-medium-blue"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firesubmersed", LuaValue.Bool true
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "intensity", LuaValue.Number 0.6
                            LuaKey.String "laserflaresize", LuaValue.Number 5.5
                            LuaKey.String "name", LuaValue.String "UWSupernovaBeam"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 500.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.46
                            LuaKey.String "rgbcolor", LuaValue.String "0.2 0.3 0.8"
                            LuaKey.String "rgbcolor2", LuaValue.String "1 1 1"
                            LuaKey.String "soundhitdry", LuaValue.String ""
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "uwlasrfir1"
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 3.5
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 700.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1400.0
                                    LuaKey.String "subs", LuaValue.Number 700.0
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
                            LuaKey.String "soundhit", LuaValue.String "xplomas2s"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzlexs"
                            LuaKey.String "soundstart", LuaValue.String "disigun1"
                            LuaKey.String "soundhitvolume", LuaValue.Number 36.0
                            LuaKey.String "soundstartvolume", LuaValue.Number 96.0
                            LuaKey.String "soundtrigger", LuaValue.Bool true
                            LuaKey.String "tolerance", LuaValue.Number 10000.0
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "waterweapon", LuaValue.Bool true
                            LuaKey.String "weapontimer", LuaValue.Number 4.2
                            LuaKey.String "weapontype", LuaValue.String "DGun"
                            LuaKey.String "weaponvelocity", LuaValue.Number 300.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "commanders", LuaValue.Number 0.0
                                    LuaKey.String "default", LuaValue.Number 99999.0
                                    LuaKey.String "scavboss", LuaValue.Number 1000.0
                                    LuaKey.String "raptorqueen", LuaValue.Number 1000.0
                                ]
                        ]
                    LuaKey.String "corcomeyelaser", LuaValue.Table [
                            LuaKey.String "allowNonBlockingAim", LuaValue.Bool true
                            LuaKey.String "areaofeffect", LuaValue.Number 72.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "beamtime", LuaValue.Number 0.033
                            LuaKey.String "camerashake", LuaValue.Number 0.1
                            LuaKey.String "collidefriendly", LuaValue.Bool false
                            LuaKey.String "corethickness", LuaValue.Number 0.35
                            LuaKey.String "craterareaofeffect", LuaValue.Number 72.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "energypershot", LuaValue.Number 0.0
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-medium-beam"
                            LuaKey.String "firestarter", LuaValue.Number 90.0
                            LuaKey.String "firetolerance", LuaValue.Number 300.0
                            LuaKey.String "impulsefactor", LuaValue.Number 0.0
                            LuaKey.String "laserflaresize", LuaValue.Number 8.0
                            LuaKey.String "name", LuaValue.String "EyeLaser"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "proximitypriority", LuaValue.Number 1.0
                            LuaKey.String "range", LuaValue.Number 870.0
                            LuaKey.String "reloadtime", LuaValue.Number 0.033
                            LuaKey.String "rgbcolor", LuaValue.String "1 0.8 0"
                            LuaKey.String "rgbcolor2", LuaValue.String "0.8 0 0"
                            LuaKey.String "scrollspeed", LuaValue.Number 5.0
                            LuaKey.String "soundhitdry", LuaValue.String "flamhit1"
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "soundstart", LuaValue.String "heatray3burn"
                            LuaKey.String "soundstartvolume", LuaValue.Number 11.0
                            LuaKey.String "soundtrigger", LuaValue.Number 1.0
                            LuaKey.String "thickness", LuaValue.Number 4.5
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "BeamLaser"
                            LuaKey.String "weaponvelocity", LuaValue.Number 1500.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 58.0
                                ]
                        ]
                    LuaKey.String "repulsor", LuaValue.Table [
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 0.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "name", LuaValue.String "PlasmaRepulsor"
                            LuaKey.String "range", LuaValue.Number 100.0
                            LuaKey.String "soundhitwet", LuaValue.String "sizzle"
                            LuaKey.String "weapontype", LuaValue.String "Shield"
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 100.0
                                ]
                            LuaKey.String "shield", LuaValue.Table [
                                    LuaKey.String "alpha", LuaValue.Number 0.17
                                    LuaKey.String "armortype", LuaValue.String "shields"
                                    LuaKey.String "exterior", LuaValue.Bool true
                                    LuaKey.String "force", LuaValue.Number 2.5
                                    LuaKey.String "intercepttype", LuaValue.Number 8191.0
                                    LuaKey.String "power", LuaValue.Number 43700.0
                                    LuaKey.String "powerregen", LuaValue.Number 1060.0
                                    LuaKey.String "powerregenenergy", LuaValue.Number 84.0
                                    LuaKey.String "radius", LuaValue.Number 100.0
                                    LuaKey.String "repulser", LuaValue.Bool false
                                    LuaKey.String "smart", LuaValue.Bool true
                                    LuaKey.String "startingpower", LuaValue.Number 43700.0
                                    LuaKey.String "visiblerepulse", LuaValue.Bool false
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
                    LuaKey.String "armcannon", LuaValue.Table [
                            LuaKey.String "areaofeffect", LuaValue.Number 292.0
                            LuaKey.String "avoidfeature", LuaValue.Bool false
                            LuaKey.String "craterareaofeffect", LuaValue.Number 292.0
                            LuaKey.String "craterboost", LuaValue.Number 0.0
                            LuaKey.String "cratermult", LuaValue.Number 0.0
                            LuaKey.String "edgeeffectiveness", LuaValue.Number 0.15
                            LuaKey.String "explosiongenerator", LuaValue.String "custom:genericshellexplosion-large-aoe"
                            LuaKey.String "gravityaffected", LuaValue.String "true"
                            LuaKey.String "impulsefactor", LuaValue.Number 0.123
                            LuaKey.String "name", LuaValue.String "HeavyCannon"
                            LuaKey.String "noselfdamage", LuaValue.Bool true
                            LuaKey.String "range", LuaValue.Number 750.0
                            LuaKey.String "reloadtime", LuaValue.Number 3.0
                            LuaKey.String "soundhit", LuaValue.String "xplomed4"
                            LuaKey.String "soundhitwet", LuaValue.String "splslrg"
                            LuaKey.String "soundstart", LuaValue.String "cannhvy2"
                            LuaKey.String "turret", LuaValue.Bool true
                            LuaKey.String "weapontype", LuaValue.String "Cannon"
                            LuaKey.String "weaponvelocity", LuaValue.Number 310.0
                            LuaKey.String "damage", LuaValue.Table [
                                    LuaKey.String "default", LuaValue.Number 1350.0
                                    LuaKey.String "subs", LuaValue.Number 300.0
                                    LuaKey.String "vtol", LuaValue.Number 100.0
                                ]
                        ]
                ]
            LuaKey.String "weapons", LuaValue.Table [
                    LuaKey.Int 1, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMLASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 2, LuaValue.Table [
                            LuaKey.String "badtargetcategory", LuaValue.String "VTOL"
                            LuaKey.String "def", LuaValue.String "CORCOMSEALASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTAIR"
                        ]
                    LuaKey.Int 3, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "DISINTEGRATOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 4, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "REPULSOR"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                        ]
                    LuaKey.Int 5, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "CORCOMEYELASER"
                            LuaKey.String "onlytargetcategory", LuaValue.String "NOTSUB"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                    LuaKey.Int 6, LuaValue.Table [
                            LuaKey.String "def", LuaValue.String "ARMCANNON"
                            LuaKey.String "onlytargetcategory", LuaValue.String "SURFACE"
                            LuaKey.String "fastautoretargeting", LuaValue.Bool true
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "armcomlvl10", armcomlvl10
            "armcomlvl2", armcomlvl2
            "armcomlvl3", armcomlvl3
            "armcomlvl4", armcomlvl4
            "armcomlvl5", armcomlvl5
            "armcomlvl6", armcomlvl6
            "armcomlvl7", armcomlvl7
            "armcomlvl8", armcomlvl8
            "armcomlvl9", armcomlvl9
            "corcomlvl10", corcomlvl10
            "corcomlvl2", corcomlvl2
            "corcomlvl3", corcomlvl3
            "corcomlvl4", corcomlvl4
            "corcomlvl5", corcomlvl5
            "corcomlvl6", corcomlvl6
            "corcomlvl7", corcomlvl7
            "corcomlvl8", corcomlvl8
            "corcomlvl9", corcomlvl9
        ]
