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

    /// INTERNAL_ORDER flag (1 << 3 = 8) marks commands as programmatic AI orders.
    let [<Literal>] private INTERNAL_ORDER = 8u

    let MoveCommand (unitId: int) (x: float32) (y: float32) (z: float32) : AICommand =
        let cmd = AICommand()
        let m = MoveUnitCommand()
        m.UnitId <- unitId
        m.Options <- INTERNAL_ORDER
        m.ToPosition <- vec3 x y z
        m.Timeout <- 2147483647
        cmd.MoveUnit <- m
        cmd

    let BuildCommand (unitId: int) (unitDefId: int) (x: float32) (y: float32) (z: float32) (facing: int) : AICommand =
        let cmd = AICommand()
        let b = BuildUnitCommand()
        b.UnitId <- unitId
        b.Options <- INTERNAL_ORDER
        b.ToBuildUnitDefId <- unitDefId
        b.BuildPosition <- vec3 x y z
        b.Facing <- facing
        b.Timeout <- 2147483647
        cmd.BuildUnit <- b
        cmd

    let PatrolCommand (unitId: int) (x: float32) (y: float32) (z: float32) : AICommand =
        let cmd = AICommand()
        let p = PatrolCommand()
        p.UnitId <- unitId
        p.Options <- INTERNAL_ORDER
        p.ToPosition <- vec3 x y z
        p.Timeout <- 2147483647
        cmd.Patrol <- p
        cmd

    let AttackCommand (unitId: int) (targetUnitId: int) : AICommand =
        let cmd = AICommand()
        let a = AttackCommand()
        a.UnitId <- unitId
        a.Options <- INTERNAL_ORDER
        a.TargetUnitId <- targetUnitId
        a.Timeout <- 2147483647
        cmd.Attack <- a
        cmd

    let GuardCommand (unitId: int) (guardUnitId: int) : AICommand =
        let cmd = AICommand()
        let g = GuardCommand()
        g.UnitId <- unitId
        g.Options <- INTERNAL_ORDER
        g.GuardUnitId <- guardUnitId
        g.Timeout <- 2147483647
        cmd.Guard <- g
        cmd

    let StopCommand (unitId: int) : AICommand =
        let cmd = AICommand()
        let s = StopCommand()
        s.UnitId <- unitId
        s.Options <- INTERNAL_ORDER
        s.Timeout <- 2147483647
        cmd.Stop <- s
        cmd

    let RepairCommand (unitId: int) (repairUnitId: int) : AICommand =
        let cmd = AICommand()
        let r = RepairCommand()
        r.UnitId <- unitId
        r.Options <- INTERNAL_ORDER
        r.RepairUnitId <- repairUnitId
        r.Timeout <- 2147483647
        cmd.Repair <- r
        cmd

    let ReclaimUnitCommand (unitId: int) (reclaimUnitId: int) : AICommand =
        let cmd = AICommand()
        let r = ReclaimUnitCommand()
        r.UnitId <- unitId
        r.Options <- INTERNAL_ORDER
        r.ReclaimUnitId <- reclaimUnitId
        r.Timeout <- 2147483647
        cmd.ReclaimUnit <- r
        cmd

    let FightCommand (unitId: int) (x: float32) (y: float32) (z: float32) : AICommand =
        let cmd = AICommand()
        let f = FightCommand()
        f.UnitId <- unitId
        f.Options <- INTERNAL_ORDER
        f.ToPosition <- vec3 x y z
        f.Timeout <- 2147483647
        cmd.Fight <- f
        cmd

    let SetWantedMaxSpeedCommand (unitId: int) (speed: float32) : AICommand =
        let cmd = AICommand()
        let s = SetWantedMaxSpeedCommand()
        s.UnitId <- unitId
        s.Options <- INTERNAL_ORDER
        s.WantedMaxSpeed <- speed
        s.Timeout <- 2147483647
        cmd.SetWantedMaxSpeed <- s
        cmd

    let SelfDestructCommand (unitId: int) : AICommand =
        let cmd = AICommand()
        let s = SelfDestructCommand()
        s.UnitId <- unitId
        s.Options <- INTERNAL_ORDER
        s.Timeout <- 2147483647
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
        c.Options <- INTERNAL_ORDER
        c.CommandId <- commandId
        c.Timeout <- 2147483647
        for p in parameters do
            c.Params.Add(p)
        cmd.Custom <- c
        cmd

    let GiveMeResourceCommand (resourceId: int) (amount: float32) : AICommand =
        let cmd = AICommand()
        let g = GiveMeCommand()
        g.ResourceId <- resourceId
        g.Amount <- amount
        cmd.GiveMe <- g
        cmd

    let GiveMeNewUnitCommand (unitDefId: int) (x: float32) (y: float32) (z: float32) : AICommand =
        let cmd = AICommand()
        let g = GiveMeNewUnitCommand()
        g.UnitDefId <- unitDefId
        g.Position <- vec3 x y z
        cmd.GiveMeNewUnit <- g
        cmd

    let CallLuaRulesCommand (data: string) : AICommand =
        let cmd = AICommand()
        let c = CallLuaRulesCommand()
        c.Data <- data
        cmd.CallLuaRules <- c
        cmd

    let CallLuaUICommand (data: string) : AICommand =
        let cmd = AICommand()
        let c = CallLuaUICommand()
        c.Data <- data
        cmd.CallLuaUi <- c
        cmd
