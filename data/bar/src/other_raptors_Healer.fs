// Auto-generated BAR unit data: other/raptors/Healer
namespace BarData.Units

open BarData

module other_raptors_Healer =

    let raptor_land_swarmer_heal_t1_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 1.0
            LuaKey.String "energycost", LuaValue.Number 600.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "builddistance", LuaValue.Number 200.0
            LuaKey.String "builder", LuaValue.Number 1.0
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorhealer.DDS"
            LuaKey.String "buildtime", LuaValue.Number 750.0
            LuaKey.String "canassist", LuaValue.Number 1.0
            LuaKey.String "canbuild", LuaValue.Number 1.0
            LuaKey.String "canguard", LuaValue.Number 1.0
            LuaKey.String "canmove", LuaValue.Number 1.0
            LuaKey.String "canpatrol", LuaValue.Number 1.0
            LuaKey.String "canrepair", LuaValue.Number 1.0
            LuaKey.String "canreclaim", LuaValue.Number 0.0
            LuaKey.String "canstop", LuaValue.Number 1.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "10 14 22"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "energymake", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 50.0
            LuaKey.String "health", LuaValue.Number 250.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 75.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 1000.0
            LuaKey.String "mobilestandorders", LuaValue.Number 1.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorhealer1.s3o"
            LuaKey.String "reclaimspeed", LuaValue.Number 400.0
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Raptors/raptorhealer.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 1.0
            LuaKey.String "selfdestructas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 600.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "standingmoveorder", LuaValue.Number 1.0
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 1.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 10.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_swarmer_heal_t1_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 12.0
            LuaKey.String "workertime", LuaValue.Number 250.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"raptor_turret_basic_t2_v1\",\r\n\t\t\t\"raptor_turret_antiair_t2_v1\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
        ]

    let raptor_land_swarmer_heal_t2_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 1.0
            LuaKey.String "energycost", LuaValue.Number 600.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "builddistance", LuaValue.Number 250.0
            LuaKey.String "builder", LuaValue.Number 1.0
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorhealer.DDS"
            LuaKey.String "buildtime", LuaValue.Number 750.0
            LuaKey.String "canassist", LuaValue.Number 1.0
            LuaKey.String "canbuild", LuaValue.Number 1.0
            LuaKey.String "canguard", LuaValue.Number 1.0
            LuaKey.String "canmove", LuaValue.Number 1.0
            LuaKey.String "canpatrol", LuaValue.Number 1.0
            LuaKey.String "canrepair", LuaValue.Number 1.0
            LuaKey.String "canreclaim", LuaValue.Number 0.0
            LuaKey.String "canstop", LuaValue.Number 1.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "10 14 22"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "energymake", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 50.0
            LuaKey.String "health", LuaValue.Number 500.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 112.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 1000.0
            LuaKey.String "mobilestandorders", LuaValue.Number 1.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorhealer2.s3o"
            LuaKey.String "reclaimspeed", LuaValue.Number 400.0
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Raptors/raptorhealer.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 1.0
            LuaKey.String "selfdestructas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 700.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "standingmoveorder", LuaValue.Number 1.0
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 1.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 10.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_swarmer_heal_t2_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 12.0
            LuaKey.String "workertime", LuaValue.Number 500.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"raptor_turret_basic_t2_v1\",\r\n\t\t\t\"raptor_turret_antiair_t2_v1\",\r\n\t\t\t\"raptor_turret_acid_t2_v1\",\r\n\t\t\t\"raptor_turret_emp_t2_v1\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
        ]

    let raptor_land_swarmer_heal_t3_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 1.0
            LuaKey.String "energycost", LuaValue.Number 600.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "builddistance", LuaValue.Number 300.0
            LuaKey.String "builder", LuaValue.Number 1.0
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorhealer.DDS"
            LuaKey.String "buildtime", LuaValue.Number 750.0
            LuaKey.String "canassist", LuaValue.Number 1.0
            LuaKey.String "canbuild", LuaValue.Number 1.0
            LuaKey.String "canguard", LuaValue.Number 1.0
            LuaKey.String "canmove", LuaValue.Number 1.0
            LuaKey.String "canpatrol", LuaValue.Number 1.0
            LuaKey.String "canrepair", LuaValue.Number 1.0
            LuaKey.String "canreclaim", LuaValue.Number 0.0
            LuaKey.String "canstop", LuaValue.Number 1.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "10 14 22"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "energymake", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 50.0
            LuaKey.String "health", LuaValue.Number 750.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 150.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 1000.0
            LuaKey.String "mobilestandorders", LuaValue.Number 1.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorhealer3.s3o"
            LuaKey.String "reclaimspeed", LuaValue.Number 400.0
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Raptors/raptorhealer.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 1.0
            LuaKey.String "selfdestructas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 800.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "standingmoveorder", LuaValue.Number 1.0
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 1.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 10.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_swarmer_heal_t3_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 12.0
            LuaKey.String "workertime", LuaValue.Number 750.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"raptor_turret_basic_t3_v1\",\r\n\t\t\t\"raptor_turret_antiair_t3_v1\",\r\n\t\t\t\"raptor_turret_acid_t2_v1\",\r\n\t\t\t\"raptor_turret_emp_t2_v1\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
        ]

    let raptor_land_swarmer_heal_t4_v1 =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 32.0
            LuaKey.String "maxdec", LuaValue.Number 1.0
            LuaKey.String "energycost", LuaValue.Number 600.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "builddistance", LuaValue.Number 350.0
            LuaKey.String "builder", LuaValue.Number 1.0
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorhealer.DDS"
            LuaKey.String "buildtime", LuaValue.Number 750.0
            LuaKey.String "canassist", LuaValue.Number 1.0
            LuaKey.String "canbuild", LuaValue.Number 1.0
            LuaKey.String "canguard", LuaValue.Number 1.0
            LuaKey.String "canmove", LuaValue.Number 1.0
            LuaKey.String "canpatrol", LuaValue.Number 1.0
            LuaKey.String "canrepair", LuaValue.Number 1.0
            LuaKey.String "canreclaim", LuaValue.Number 0.0
            LuaKey.String "canstop", LuaValue.Number 1.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "10 14 22"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "energymake", LuaValue.Number 25.0
            LuaKey.String "explodeas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 50.0
            LuaKey.String "health", LuaValue.Number 1000.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 187.5
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 1000.0
            LuaKey.String "mobilestandorders", LuaValue.Number 1.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Raptors/raptorhealer4.s3o"
            LuaKey.String "reclaimspeed", LuaValue.Number 400.0
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Raptors/raptorhealer.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 1.0
            LuaKey.String "selfdestructas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 900.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "standingmoveorder", LuaValue.Number 1.0
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 1.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 10.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptor_land_swarmer_heal_t4_v1"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 12.0
            LuaKey.String "workertime", LuaValue.Number 1000.0
            LuaKey.String "buildoptions", LuaValue.Expr "{\r\n\t\t\t\"raptor_turret_basic_t3_v1\",\r\n\t\t\t\"raptor_turret_antiair_t3_v1\",\r\n\t\t\t\"raptor_turret_acid_t3_v1\",\r\n\t\t\t\"raptor_turret_emp_t3_v1\",\r\n\t\t}"
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
        ]

    let raptorh1b =
        LuaValue.Table [
            LuaKey.String "maxacc", LuaValue.Number 1.0
            LuaKey.String "activatewhenbuilt", LuaValue.Bool true
            LuaKey.String "autoheal", LuaValue.Number 24.0
            LuaKey.String "maxdec", LuaValue.Number 1.0
            LuaKey.String "energycost", LuaValue.Number 600.0
            LuaKey.String "metalcost", LuaValue.Number 40.0
            LuaKey.String "builddistance", LuaValue.Number 400.0
            LuaKey.String "builder", LuaValue.Number 1.0
            LuaKey.String "buildpic", LuaValue.String "raptors/raptorh1b.DDS"
            LuaKey.String "buildtime", LuaValue.Number 1125.0
            LuaKey.String "canassist", LuaValue.Number 0.0
            LuaKey.String "canbuild", LuaValue.Number 1.0
            LuaKey.String "canguard", LuaValue.Number 1.0
            LuaKey.String "canmove", LuaValue.Number 1.0
            LuaKey.String "canpatrol", LuaValue.Number 1.0
            LuaKey.String "canrepair", LuaValue.Number 0.0
            LuaKey.String "canreclaim", LuaValue.Number 1.0
            LuaKey.String "canstop", LuaValue.Number 1.0
            LuaKey.String "capturable", LuaValue.Bool false
            LuaKey.String "category", LuaValue.String "RAPTOR"
            LuaKey.String "collide", LuaValue.Number 0.0
            LuaKey.String "collisionvolumeoffsets", LuaValue.String "0 -1 0"
            LuaKey.String "collisionvolumescales", LuaValue.String "15 18 22"
            LuaKey.String "collisionvolumetype", LuaValue.String "box"
            LuaKey.String "defaultmissiontype", LuaValue.String "Standby"
            LuaKey.String "energymake", LuaValue.Number 15.0
            LuaKey.String "explodeas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "floater", LuaValue.Bool false
            LuaKey.String "footprintx", LuaValue.Number 1.0
            LuaKey.String "footprintz", LuaValue.Number 1.0
            LuaKey.String "hidedamage", LuaValue.Number 1.0
            LuaKey.String "leavetracks", LuaValue.Bool true
            LuaKey.String "maneuverleashlength", LuaValue.Number 640.0
            LuaKey.String "mass", LuaValue.Number 60.0
            LuaKey.String "health", LuaValue.Number 365.0
            LuaKey.String "maxslope", LuaValue.Number 18.0
            LuaKey.String "speed", LuaValue.Number 150.0
            LuaKey.String "maxwaterdepth", LuaValue.Number 0.0
            LuaKey.String "metalstorage", LuaValue.Number 1000.0
            LuaKey.String "mobilestandorders", LuaValue.Number 1.0
            LuaKey.String "movementclass", LuaValue.String "RAPTORSMALLHOVER"
            LuaKey.String "noautofire", LuaValue.Number 0.0
            LuaKey.String "objectname", LuaValue.String "Raptors/raptor_droneb.s3o"
            LuaKey.String "reclaimspeed", LuaValue.Number 400.0
            LuaKey.String "repairable", LuaValue.Bool false
            LuaKey.String "script", LuaValue.String "Raptors/raptorh1b.cob"
            LuaKey.String "seismicsignature", LuaValue.Number 1.0
            LuaKey.String "selfdestructas", LuaValue.String "WEAVER_DEATH"
            LuaKey.String "side", LuaValue.String "THUNDERBIRDS"
            LuaKey.String "sightdistance", LuaValue.Number 50.0
            LuaKey.String "smoothanim", LuaValue.Bool true
            LuaKey.String "standingmoveorder", LuaValue.Number 1.0
            LuaKey.String "stealth", LuaValue.Number 1.0
            LuaKey.String "trackoffset", LuaValue.Number 1.0
            LuaKey.String "trackstrength", LuaValue.Number 3.0
            LuaKey.String "trackstretch", LuaValue.Number 1.0
            LuaKey.String "tracktype", LuaValue.String "RaptorTrack"
            LuaKey.String "trackwidth", LuaValue.Number 10.0
            LuaKey.String "turninplace", LuaValue.Bool true
            LuaKey.String "turninplaceanglelimit", LuaValue.Number 90.0
            LuaKey.String "turnrate", LuaValue.Number 1840.0
            LuaKey.String "unitname", LuaValue.String "raptorh1b"
            LuaKey.String "upright", LuaValue.Bool false
            LuaKey.String "waterline", LuaValue.Number 13.0
            LuaKey.String "workertime", LuaValue.Number 500.0
            LuaKey.String "customparams", LuaValue.Table [
                    LuaKey.String "subfolder", LuaValue.String "other/raptors"
                    LuaKey.String "model_author", LuaValue.String "KDR_11k, Beherith"
                    LuaKey.String "normalmaps", LuaValue.String "yes"
                    LuaKey.String "normaltex", LuaValue.String "unittextures/chicken_s_normals.png"
                ]
            LuaKey.String "sfxtypes", LuaValue.Table [
                    LuaKey.String "explosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "custom:blood_spray"
                            LuaKey.Int 2, LuaValue.String "custom:blood_explode"
                            LuaKey.Int 3, LuaValue.String "custom:dirt"
                        ]
                    LuaKey.String "pieceexplosiongenerators", LuaValue.Table [
                            LuaKey.Int 1, LuaValue.String "blood_spray"
                            LuaKey.Int 2, LuaValue.String "blood_spray"
                            LuaKey.Int 3, LuaValue.String "blood_spray"
                        ]
                ]
        ]

    let all : (string * LuaValue) list =
        [
            "raptor_land_swarmer_heal_t1_v1", raptor_land_swarmer_heal_t1_v1
            "raptor_land_swarmer_heal_t2_v1", raptor_land_swarmer_heal_t2_v1
            "raptor_land_swarmer_heal_t3_v1", raptor_land_swarmer_heal_t3_v1
            "raptor_land_swarmer_heal_t4_v1", raptor_land_swarmer_heal_t4_v1
            "raptorh1b", raptorh1b
        ]
