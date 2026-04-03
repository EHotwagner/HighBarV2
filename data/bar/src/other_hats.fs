// Auto-generated BAR unit data: other/hats (unified)
namespace BarData.Units

open BarData

module other_hats =

    type Cor_hat_fightnight =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cor_hat_fightnight : Cor_hat_fightnight =
        { name = "cor_hat_fightnight"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_fightnight.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          customParams = Map.ofList [
                "nohealthbars", "true"
                "model_author", "NebuchadnezzarII="
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/hats"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "cancloak", "true"
                "capturable", "true"
                "cantbetransported", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "autoheal", "100000.0"
                "mass", "0.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "upright", "false"
            ] }

    let cor_hat_fightnightDef : UnitDef =
        { name = "cor_hat_fightnight"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_fightnight.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "nohealthbars", "true"
              "model_author", "NebuchadnezzarII="
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/hats"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "cancloak", "true"
              "capturable", "true"
              "cantbetransported", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "autoheal", "100000.0"
              "mass", "0.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "upright", "false"
          ] }

    let cor_hat_fightnightToFlat (def: UnitDef) : Cor_hat_fightnight =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          customParams = def.customParams
          extras = def.extras }

    let cor_hat_fightnightToUnitDef (flat: Cor_hat_fightnight) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Cor_hat_hornet =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cor_hat_hornet : Cor_hat_hornet =
        { name = "cor_hat_hornet"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_hornet.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          customParams = Map.ofList [
                "nohealthbars", "true"
                "model_author", "Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/hats"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "cancloak", "true"
                "capturable", "true"
                "cantbetransported", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "autoheal", "100000.0"
                "mass", "0.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "upright", "false"
            ] }

    let cor_hat_hornetDef : UnitDef =
        { name = "cor_hat_hornet"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_hornet.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "nohealthbars", "true"
              "model_author", "Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/hats"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "cancloak", "true"
              "capturable", "true"
              "cantbetransported", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "autoheal", "100000.0"
              "mass", "0.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "upright", "false"
          ] }

    let cor_hat_hornetToFlat (def: UnitDef) : Cor_hat_hornet =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          customParams = def.customParams
          extras = def.extras }

    let cor_hat_hornetToUnitDef (flat: Cor_hat_hornet) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Cor_hat_hw =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cor_hat_hw : Cor_hat_hw =
        { name = "cor_hat_hw"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_hw.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          customParams = Map.ofList [
                "nohealthbars", "true"
                "model_author", "Taken from corcom_hw"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/hats"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "cancloak", "true"
                "capturable", "true"
                "cantbetransported", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "autoheal", "100000.0"
                "mass", "0.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "upright", "false"
            ] }

    let cor_hat_hwDef : UnitDef =
        { name = "cor_hat_hw"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_hw.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "nohealthbars", "true"
              "model_author", "Taken from corcom_hw"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/hats"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "cancloak", "true"
              "capturable", "true"
              "cantbetransported", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "autoheal", "100000.0"
              "mass", "0.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "upright", "false"
          ] }

    let cor_hat_hwToFlat (def: UnitDef) : Cor_hat_hw =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          customParams = def.customParams
          extras = def.extras }

    let cor_hat_hwToUnitDef (flat: Cor_hat_hw) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Cor_hat_legfn =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cor_hat_legfn : Cor_hat_legfn =
        { name = "cor_hat_legfn"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_legfn.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          customParams = Map.ofList [
                "nohealthbars", "true"
                "model_author", "NebuchadnezzarII"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/hats"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "cancloak", "true"
                "capturable", "true"
                "cantbetransported", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "autoheal", "100000.0"
                "mass", "0.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "upright", "false"
            ] }

    let cor_hat_legfnDef : UnitDef =
        { name = "cor_hat_legfn"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_legfn.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "nohealthbars", "true"
              "model_author", "NebuchadnezzarII"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/hats"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "cancloak", "true"
              "capturable", "true"
              "cantbetransported", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "autoheal", "100000.0"
              "mass", "0.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "upright", "false"
          ] }

    let cor_hat_legfnToFlat (def: UnitDef) : Cor_hat_legfn =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          customParams = def.customParams
          extras = def.extras }

    let cor_hat_legfnToUnitDef (flat: Cor_hat_legfn) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Cor_hat_ptaq =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cor_hat_ptaq : Cor_hat_ptaq =
        { name = "cor_hat_ptaq"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_ptaq.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          customParams = Map.ofList [
                "nohealthbars", "true"
                "model_author", "Hornet"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/hats"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "cancloak", "true"
                "capturable", "true"
                "cantbetransported", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "autoheal", "100000.0"
                "mass", "0.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "upright", "false"
            ] }

    let cor_hat_ptaqDef : UnitDef =
        { name = "cor_hat_ptaq"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_ptaq.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "nohealthbars", "true"
              "model_author", "Hornet"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/hats"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "cancloak", "true"
              "capturable", "true"
              "cantbetransported", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "autoheal", "100000.0"
              "mass", "0.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "upright", "false"
          ] }

    let cor_hat_ptaqToFlat (def: UnitDef) : Cor_hat_ptaq =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          customParams = def.customParams
          extras = def.extras }

    let cor_hat_ptaqToUnitDef (flat: Cor_hat_ptaq) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

    type Cor_hat_viking =
        { name: string
          subfolder: string
          metalCost: ValueOrExpr<float>
          energyCost: ValueOrExpr<float>
          buildTime: ValueOrExpr<float>
          health: ValueOrExpr<float>
          sightDistance: ValueOrExpr<float>
          footprintX: float
          footprintZ: float
          objectName: string option
          buildPic: string option
          script: string option
          corpse: string option
          explodeAs: string option
          selfDestructAs: string option
          collisionVolumeOffsets: string option
          collisionVolumeScales: string option
          collisionVolumeType: string option
          seismicSignature: float option
          category: string option
          customParams: Map<string, string>
          extras: Map<string, string> }

    let cor_hat_viking : Cor_hat_viking =
        { name = "cor_hat_viking"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_viking.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          customParams = Map.ofList [
                "nohealthbars", "true"
                "model_author", "Beherith"
                "normaltex", "unittextures/cor_normal.dds"
                "subfolder", "other/hats"
                "decoration", "1.0"
            ]
          extras = Map.ofList [
                "blocking", "false"
                "canattack", "false"
                "cancloak", "true"
                "capturable", "true"
                "cantbetransported", "false"
                "crushresistance", "2500.0"
                "hidedamage", "true"
                "autoheal", "100000.0"
                "mass", "0.0"
                "reclaimable", "false"
                "repairable", "false"
                "sonarstealth", "true"
                "stealth", "true"
                "upright", "false"
            ] }

    let cor_hat_vikingDef : UnitDef =
        { name = "cor_hat_viking"
          subfolder = "other/hats"
          metalCost = ValueOrExpr.Concrete 1000.0
          energyCost = ValueOrExpr.Concrete 10000.0
          buildTime = ValueOrExpr.Concrete 10000.0
          health = ValueOrExpr.Concrete 5600000.0
          sightDistance = ValueOrExpr.Concrete 1.0
          footprintX = 1.0
          footprintZ = 1.0
          objectName = Some "hats/cor_hat_viking.s3o"
          buildPic = Some "ARMSTONE.DDS"
          script = Some "blank.cob"
          corpse = None
          explodeAs = None
          selfDestructAs = None
          collisionVolumeOffsets = Some "0 0 0"
          collisionVolumeScales = Some "0.1 0.1 0.1"
          collisionVolumeType = Some "CylY"
          seismicSignature = Some 0.0
          category = Some "OBJECT"
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = Map.ofList [
              "nohealthbars", "true"
              "model_author", "Beherith"
              "normaltex", "unittextures/cor_normal.dds"
              "subfolder", "other/hats"
              "decoration", "1.0"
          ]
          extras = Map.ofList [
              "blocking", "false"
              "canattack", "false"
              "cancloak", "true"
              "capturable", "true"
              "cantbetransported", "false"
              "crushresistance", "2500.0"
              "hidedamage", "true"
              "autoheal", "100000.0"
              "mass", "0.0"
              "reclaimable", "false"
              "repairable", "false"
              "sonarstealth", "true"
              "stealth", "true"
              "upright", "false"
          ] }

    let cor_hat_vikingToFlat (def: UnitDef) : Cor_hat_viking =
        { name = def.name
          subfolder = def.subfolder
          metalCost = def.metalCost
          energyCost = def.energyCost
          buildTime = def.buildTime
          health = def.health
          sightDistance = def.sightDistance
          footprintX = def.footprintX
          footprintZ = def.footprintZ
          objectName = def.objectName
          buildPic = def.buildPic
          script = def.script
          corpse = def.corpse
          explodeAs = def.explodeAs
          selfDestructAs = def.selfDestructAs
          collisionVolumeOffsets = def.collisionVolumeOffsets
          collisionVolumeScales = def.collisionVolumeScales
          collisionVolumeType = def.collisionVolumeType
          seismicSignature = def.seismicSignature
          category = def.category
          customParams = def.customParams
          extras = def.extras }

    let cor_hat_vikingToUnitDef (flat: Cor_hat_viking) : UnitDef =
        { name = flat.name
          subfolder = flat.subfolder
          metalCost = flat.metalCost
          energyCost = flat.energyCost
          buildTime = flat.buildTime
          health = flat.health
          sightDistance = flat.sightDistance
          footprintX = flat.footprintX
          footprintZ = flat.footprintZ
          objectName = flat.objectName
          buildPic = flat.buildPic
          script = flat.script
          corpse = flat.corpse
          explodeAs = flat.explodeAs
          selfDestructAs = flat.selfDestructAs
          collisionVolumeOffsets = flat.collisionVolumeOffsets
          collisionVolumeScales = flat.collisionVolumeScales
          collisionVolumeType = flat.collisionVolumeType
          seismicSignature = flat.seismicSignature
          category = flat.category
          movement = None
          builder = None
          weapons = None
          economy = None
          building = None
          featureDefs = None
          sounds = None
          customParams = flat.customParams
          extras = flat.extras }

