namespace HighBar.Client

open Highbar

/// Typed command builders that return protobuf AICommand messages.
module Commands =
    let private vec3 x y z =
        let v = Vector3()
        v.X <- x; v.Y <- y; v.Z <- z
        v

    let private baseCmd unitId groupId options timeout =
        (unitId, groupId, uint32 options, timeout)

    let MoveCommand (unitId: int) (x: float32) (y: float32) (z: float32) : AICommand =
        let cmd = AICommand()
        let m = MoveUnitCommand()
        m.UnitId <- unitId
        m.ToPosition <- vec3 x y z
        m.Timeout <- -1
        cmd.MoveUnit <- m
        cmd

    let BuildCommand (unitId: int) (unitDefId: int) (x: float32) (y: float32) (z: float32) (facing: int) : AICommand =
        let cmd = AICommand()
        let b = BuildUnitCommand()
        b.UnitId <- unitId
        b.ToBuildUnitDefId <- unitDefId
        b.BuildPosition <- vec3 x y z
        b.Facing <- facing
        b.Timeout <- -1
        cmd.BuildUnit <- b
        cmd

    let PatrolCommand (unitId: int) (x: float32) (y: float32) (z: float32) : AICommand =
        let cmd = AICommand()
        let p = PatrolCommand()
        p.UnitId <- unitId
        p.ToPosition <- vec3 x y z
        p.Timeout <- -1
        cmd.Patrol <- p
        cmd

    let AttackCommand (unitId: int) (targetUnitId: int) : AICommand =
        let cmd = AICommand()
        let a = AttackCommand()
        a.UnitId <- unitId
        a.TargetUnitId <- targetUnitId
        a.Timeout <- -1
        cmd.Attack <- a
        cmd

    let GuardCommand (unitId: int) (guardUnitId: int) : AICommand =
        let cmd = AICommand()
        let g = GuardCommand()
        g.UnitId <- unitId
        g.GuardUnitId <- guardUnitId
        g.Timeout <- -1
        cmd.Guard <- g
        cmd

    let StopCommand (unitId: int) : AICommand =
        let cmd = AICommand()
        let s = StopCommand()
        s.UnitId <- unitId
        s.Timeout <- -1
        cmd.Stop <- s
        cmd

    let RepairCommand (unitId: int) (repairUnitId: int) : AICommand =
        let cmd = AICommand()
        let r = RepairCommand()
        r.UnitId <- unitId
        r.RepairUnitId <- repairUnitId
        r.Timeout <- -1
        cmd.Repair <- r
        cmd

    let ReclaimUnitCommand (unitId: int) (reclaimUnitId: int) : AICommand =
        let cmd = AICommand()
        let r = ReclaimUnitCommand()
        r.UnitId <- unitId
        r.ReclaimUnitId <- reclaimUnitId
        r.Timeout <- -1
        cmd.ReclaimUnit <- r
        cmd

    let FightCommand (unitId: int) (x: float32) (y: float32) (z: float32) : AICommand =
        let cmd = AICommand()
        let f = FightCommand()
        f.UnitId <- unitId
        f.ToPosition <- vec3 x y z
        f.Timeout <- -1
        cmd.Fight <- f
        cmd

    let SetWantedMaxSpeedCommand (unitId: int) (speed: float32) : AICommand =
        let cmd = AICommand()
        let s = SetWantedMaxSpeedCommand()
        s.UnitId <- unitId
        s.WantedMaxSpeed <- speed
        s.Timeout <- -1
        cmd.SetWantedMaxSpeed <- s
        cmd

    let SelfDestructCommand (unitId: int) : AICommand =
        let cmd = AICommand()
        let s = SelfDestructCommand()
        s.UnitId <- unitId
        s.Timeout <- -1
        cmd.SelfDestruct <- s
        cmd

    let SendTextMessageCommand (text: string) (zone: int) : AICommand =
        let cmd = AICommand()
        let m = SendTextMessageCommand()
        m.Text <- text
        m.Zone <- zone
        cmd.SendTextMessage <- m
        cmd

    let CustomCommand (unitId: int) (commandId: int) (parameters: float32 list) : AICommand =
        let cmd = AICommand()
        let c = CustomCommand()
        c.UnitId <- unitId
        c.CommandId <- commandId
        c.Timeout <- -1
        for p in parameters do
            c.Params.Add(p)
        cmd.Custom <- c
        cmd
