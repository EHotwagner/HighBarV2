namespace HighBar.Client

open Highbar

/// Discriminated union wrapping all 28 EngineEvent oneof variants
/// for idiomatic F# pattern matching.
[<RequireQualifiedAccess>]
type GameEvent =
    | Init of teamId: int
    | Release
    | Update of frame: int
    | Message of player: int * message: string
    | UnitCreated of unitId: int * builderId: int
    | UnitFinished of unitId: int
    | UnitIdle of unitId: int
    | UnitMoveFailed of unitId: int
    | UnitDamaged of unitId: int * attackerId: int option * damage: float32 * weaponDefId: int * isParalyzer: bool
    | UnitDestroyed of unitId: int * attackerId: int option
    | UnitGiven of unitId: int * oldTeamId: int * newTeamId: int
    | UnitCaptured of unitId: int * oldTeamId: int * newTeamId: int
    | EnemyEnterLOS of enemyId: int
    | EnemyLeaveLOS of enemyId: int
    | EnemyEnterRadar of enemyId: int
    | EnemyLeaveRadar of enemyId: int
    | EnemyDamaged of enemyId: int * attackerId: int option * damage: float32 * weaponDefId: int
    | EnemyDestroyed of enemyId: int * attackerId: int option
    | WeaponFired of unitId: int * weaponDefId: int
    | PlayerCommand of units: int list * commandTopicId: int * commandId: int
    | SeismicPing of x: float32 * y: float32 * z: float32 * strength: float32
    | CommandFinished of unitId: int * commandId: int * commandTopicId: int
    | Load
    | Save
    | EnemyCreated of enemyId: int
    | EnemyFinished of enemyId: int
    | LuaMessage of data: string * inMessageId: int
    | Unknown

module Events =
    let private optionalAttacker (ev: EngineEvent) (field: int) : int option =
        if field <> 0 then Some field else None

    /// Convert a protobuf EngineEvent to a typed F# GameEvent
    let fromProto (ev: EngineEvent) : GameEvent =
        match ev.EventCase with
        | EngineEvent.EventOneofCase.Init ->
            GameEvent.Init(ev.Init.TeamId)
        | EngineEvent.EventOneofCase.Release ->
            GameEvent.Release
        | EngineEvent.EventOneofCase.Update ->
            GameEvent.Update(ev.Update.Frame)
        | EngineEvent.EventOneofCase.Message ->
            GameEvent.Message(ev.Message.Player, ev.Message.Message)
        | EngineEvent.EventOneofCase.UnitCreated ->
            GameEvent.UnitCreated(ev.UnitCreated.UnitId, ev.UnitCreated.BuilderId)
        | EngineEvent.EventOneofCase.UnitFinished ->
            GameEvent.UnitFinished(ev.UnitFinished.UnitId)
        | EngineEvent.EventOneofCase.UnitIdle ->
            GameEvent.UnitIdle(ev.UnitIdle.UnitId)
        | EngineEvent.EventOneofCase.UnitMoveFailed ->
            GameEvent.UnitMoveFailed(ev.UnitMoveFailed.UnitId)
        | EngineEvent.EventOneofCase.UnitDamaged ->
            let d = ev.UnitDamaged
            let attacker =
                if d.HasAttackerId then Some d.AttackerId else None
            GameEvent.UnitDamaged(d.UnitId, attacker, d.Damage, d.WeaponDefId, d.IsParalyzer)
        | EngineEvent.EventOneofCase.UnitDestroyed ->
            let d = ev.UnitDestroyed
            let attacker =
                if d.HasAttackerId then Some d.AttackerId else None
            GameEvent.UnitDestroyed(d.UnitId, attacker)
        | EngineEvent.EventOneofCase.UnitGiven ->
            let g = ev.UnitGiven
            GameEvent.UnitGiven(g.UnitId, g.OldTeamId, g.NewTeamId)
        | EngineEvent.EventOneofCase.UnitCaptured ->
            let c = ev.UnitCaptured
            GameEvent.UnitCaptured(c.UnitId, c.OldTeamId, c.NewTeamId)
        | EngineEvent.EventOneofCase.EnemyEnterLos ->
            GameEvent.EnemyEnterLOS(ev.EnemyEnterLos.EnemyId)
        | EngineEvent.EventOneofCase.EnemyLeaveLos ->
            GameEvent.EnemyLeaveLOS(ev.EnemyLeaveLos.EnemyId)
        | EngineEvent.EventOneofCase.EnemyEnterRadar ->
            GameEvent.EnemyEnterRadar(ev.EnemyEnterRadar.EnemyId)
        | EngineEvent.EventOneofCase.EnemyLeaveRadar ->
            GameEvent.EnemyLeaveRadar(ev.EnemyLeaveRadar.EnemyId)
        | EngineEvent.EventOneofCase.EnemyDamaged ->
            let d = ev.EnemyDamaged
            let attacker =
                if d.HasAttackerId then Some d.AttackerId else None
            GameEvent.EnemyDamaged(d.EnemyId, attacker, d.Damage, d.WeaponDefId)
        | EngineEvent.EventOneofCase.EnemyDestroyed ->
            let d = ev.EnemyDestroyed
            let attacker =
                if d.HasAttackerId then Some d.AttackerId else None
            GameEvent.EnemyDestroyed(d.EnemyId, attacker)
        | EngineEvent.EventOneofCase.WeaponFired ->
            GameEvent.WeaponFired(ev.WeaponFired.UnitId, ev.WeaponFired.WeaponDefId)
        | EngineEvent.EventOneofCase.PlayerCommand ->
            let pc = ev.PlayerCommand
            GameEvent.PlayerCommand(pc.Units |> Seq.map int |> Seq.toList, pc.CommandTopicId, pc.CommandId)
        | EngineEvent.EventOneofCase.SeismicPing ->
            let sp = ev.SeismicPing
            let p = sp.Position
            GameEvent.SeismicPing(p.X, p.Y, p.Z, sp.Strength)
        | EngineEvent.EventOneofCase.CommandFinished ->
            let cf = ev.CommandFinished
            GameEvent.CommandFinished(cf.UnitId, cf.CommandId, cf.CommandTopicId)
        | EngineEvent.EventOneofCase.Load ->
            GameEvent.Load
        | EngineEvent.EventOneofCase.Save ->
            GameEvent.Save
        | EngineEvent.EventOneofCase.EnemyCreated ->
            GameEvent.EnemyCreated(ev.EnemyCreated.EnemyId)
        | EngineEvent.EventOneofCase.EnemyFinished ->
            GameEvent.EnemyFinished(ev.EnemyFinished.EnemyId)
        | EngineEvent.EventOneofCase.LuaMessage ->
            GameEvent.LuaMessage(ev.LuaMessage.Data, ev.LuaMessage.InMessageId)
        | _ ->
            GameEvent.Unknown
