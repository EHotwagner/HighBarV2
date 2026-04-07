namespace HighBar.AI.Tests

open System
open System.Diagnostics
open System.IO
open System.Threading.Tasks
open Xunit
open HighBar.Client

/// Shared helper for running a single game against the engine.
module GameOrchestrator =

    let private testsDir =
        let assemblyDir = Path.GetDirectoryName(typeof<GameResult>.Assembly.Location)
        let testProjectDir = Path.GetFullPath(Path.Combine(assemblyDir, "..", "..", ".."))
        Path.GetFullPath(Path.Combine(testProjectDir, "..", ".."))

    let private checkPrereqScript = Path.Combine(testsDir, "check-prerequisites.sh")

    let reportsDir =
        let assemblyDir = Path.GetDirectoryName(typeof<GameResult>.Assembly.Location)
        let testProjectDir = Path.GetFullPath(Path.Combine(assemblyDir, "..", "..", ".."))
        Path.Combine(testProjectDir, "reports")

    let checkPrerequisites () =
        let psi = ProcessStartInfo()
        psi.FileName <- "/usr/bin/env"
        psi.ArgumentList.Add("bash")
        psi.ArgumentList.Add(checkPrereqScript)
        psi.ArgumentList.Add("--json")
        psi.UseShellExecute <- false
        psi.RedirectStandardOutput <- true
        psi.RedirectStandardError <- true
        let proc = Process.Start(psi)
        let stdout = proc.StandardOutput.ReadToEnd()
        let stderr = proc.StandardError.ReadToEnd()
        proc.WaitForExit()
        if proc.ExitCode = 2 then
            failwith $"Prerequisites check script error: {stderr}{stdout}"
        elif proc.ExitCode <> 0 then
            failwith $"Prerequisites not met.\n{stdout}"

    let private emptyOutcome gameNumber (msg: string) =
        { GameNumber = gameNumber
          Result = GameResult.Crash
          DurationFrames = 0
          DurationMinutes = 0.0
          UnitsProduced = 0; UnitsLost = 0; EnemyUnitsDestroyed = 0
          MexBuiltCount = 0; MexFirstBuiltFrame = None
          EnergyBuiltCount = 0; EnergyFirstBuiltFrame = None
          FactoryBuiltCount = 0; FactoryFirstBuiltFrame = None
          FirstCombatUnitFrame = None; CrashMessage = Some msg
          WeaponFiredCount = 0; UnitDamagedCount = 0; EnemyDamagedCount = 0
          UnitDestroyedCount = 0; EnemyDestroyedCount = 0 }

    let private configPath = Path.Combine(testsDir, "engine-version.json")

    /// Run a single game: launch engine, connect, run AI brain, collect outcome.
    let runSingleGame
        (gameNumber: int)
        (setupFile: string)
        (maxFrames: int)
        (engineBin: string option)
        : GameOutcome =

        let config =
            let base' = EngineConfig.fromVersionFile configPath
            let withEngine =
                match engineBin with
                | Some bin -> { base' with EngineBin = bin }
                | None -> base'
            withEngine |> EngineConfig.validate

        let session = new EngineSession(config)
        let logPath = Path.Combine(session.SessionDir, "decisions.jsonl")

        try
            session.Start()
            let client = session.Client

            // Track game metrics
            let mutable frameCount = 0
            let mutable unitsProduced = 0
            let mutable unitsLost = 0
            let mutable enemyUnitsDestroyed = 0
            let mutable mexBuiltCount = 0
            let mutable mexFirstBuiltFrame: int option = None
            let mutable energyBuiltCount = 0
            let mutable energyFirstBuiltFrame: int option = None
            let mutable factoryBuiltCount = 0
            let mutable factoryFirstBuiltFrame: int option = None
            let mutable firstCombatUnitFrame: int option = None
            let mutable weaponFiredCount = 0
            let mutable unitDamagedCount = 0
            let mutable enemyDamagedCount = 0
            let mutable unitDestroyedCount = 0
            let mutable enemyDestroyedCount = 0
            let mutable zeroCommandFrames = 0
            let mutable gameResult = GameResult.Timeout
            let mutable crashMessage: string option = None
            let mutable gameOver = false

            // Lazy init: GameState and frame handler
            let mutable gs: GameState option = None
            let mutable frameHandler: (GameFrame -> Highbar.AICommand list) option = None

            let classifyFinishedUnit (unitId: int) =
                let defId = client.GetUnitDef(unitId)
                if defId > 0 then
                    let name = client.GetUnitDefName(defId)
                    let nameLower = if isNull name then "" else name.ToLowerInvariant()
                    let buildOptions = client.GetBuildOptions(defId)
                    let buildSpeed = client.GetBuildSpeed(defId)
                    let maxWeaponRange = client.GetMaxWeaponRange(defId)

                    if nameLower.Contains("mex") then
                        mexBuiltCount <- mexBuiltCount + 1
                        if mexFirstBuiltFrame.IsNone then
                            mexFirstBuiltFrame <- Some frameCount

                    if nameLower.Contains("solar") || nameLower.Contains("wind") ||
                       nameLower.Contains("fusion") || nameLower.Contains("geo") ||
                       nameLower.Contains("moho") || nameLower.Contains("energy") then
                        energyBuiltCount <- energyBuiltCount + 1
                        if energyFirstBuiltFrame.IsNone then
                            energyFirstBuiltFrame <- Some frameCount

                    if buildOptions.Length > 0 && buildSpeed > 0.0f then
                        factoryBuiltCount <- factoryBuiltCount + 1
                        if factoryFirstBuiltFrame.IsNone then
                            factoryFirstBuiltFrame <- Some frameCount

                    if maxWeaponRange > 0.0f && buildSpeed = 0.0f then
                        if firstCombatUnitFrame.IsNone then
                            firstCombatUnitFrame <- Some frameCount

            try
                client.Run(fun frame ->
                    frameCount <- frameCount + 1

                    // Initialize GameState on Init event (first frame)
                    for ev in frame.Events do
                        match ev with
                        | GameEvent.Init teamId when gs.IsNone ->
                            let newGs = GameState.init client teamId logPath
                            gs <- Some newGs
                            frameHandler <- Some(GameState.createFrameHandler newGs)
                        | _ -> ()

                    // Track metrics from all events
                    for ev in frame.Events do
                        match ev with
                        | GameEvent.UnitCreated _ ->
                            unitsProduced <- unitsProduced + 1
                        | GameEvent.UnitFinished(unitId) ->
                            classifyFinishedUnit unitId
                        | GameEvent.UnitDestroyed _ ->
                            unitsLost <- unitsLost + 1
                            unitDestroyedCount <- unitDestroyedCount + 1
                        | GameEvent.UnitDamaged _ ->
                            unitDamagedCount <- unitDamagedCount + 1
                        | GameEvent.EnemyDestroyed _ ->
                            enemyUnitsDestroyed <- enemyUnitsDestroyed + 1
                            enemyDestroyedCount <- enemyDestroyedCount + 1
                        | GameEvent.EnemyDamaged _ ->
                            enemyDamagedCount <- enemyDamagedCount + 1
                        | GameEvent.WeaponFired _ ->
                            weaponFiredCount <- weaponFiredCount + 1
                        | GameEvent.Release ->
                            gameOver <- true
                        | _ -> ()

                    if gameOver then
                        match gs with
                        | Some g ->
                            let friendlyAlive =
                                g.UnitRegistry.GetFriendlyByClass(UnitClass.Commander)
                                |> List.exists (fun u -> u.Lifecycle = UnitLifecycle.Ready || u.Lifecycle = UnitLifecycle.Alive)
                            gameResult <- if friendlyAlive then GameResult.Win else GameResult.Loss
                        | None ->
                            gameResult <- GameResult.Loss
                        failwith "GAME_ENDED"

                    // Run AI brain if initialized
                    let cmds =
                        match frameHandler with
                        | Some handler -> handler frame
                        | None -> []

                    if cmds.IsEmpty then
                        zeroCommandFrames <- zeroCommandFrames + 1
                    else
                        zeroCommandFrames <- 0

                    if zeroCommandFrames >= 1800 then
                        gameResult <- GameResult.Stall
                        failwith "GAME_ENDED"

                    if frameCount >= maxFrames then
                        gameResult <- GameResult.Timeout
                        failwith "GAME_ENDED"

                    cmds
                )
            with
            | ex when ex.Message = "GAME_ENDED" -> ()
            | ex when ex.Message = "CAPTURED_ENOUGH" -> ()
            | :? IOException as ex ->
                gameResult <- GameResult.Crash
                crashMessage <- Some ex.Message
            | :? System.Net.Sockets.SocketException as ex ->
                gameResult <- GameResult.Crash
                crashMessage <- Some ex.Message
            | ex ->
                gameResult <- GameResult.Crash
                crashMessage <- Some ex.Message

            // Cleanup
            gs |> Option.iter (fun g -> try g.DecisionLog.Close() with _ -> ())
            let keepLogs = Environment.GetEnvironmentVariable("HIGHBAR_KEEP_LOGS")
            let preserve = not (String.IsNullOrEmpty(keepLogs)) || gameResult = GameResult.Crash
            session.Stop(preserve)

            { GameNumber = gameNumber
              Result = gameResult
              DurationFrames = frameCount
              DurationMinutes = float frameCount / 30.0 / 60.0
              UnitsProduced = unitsProduced
              UnitsLost = unitsLost
              EnemyUnitsDestroyed = enemyUnitsDestroyed
              MexBuiltCount = mexBuiltCount
              MexFirstBuiltFrame = mexFirstBuiltFrame
              EnergyBuiltCount = energyBuiltCount
              EnergyFirstBuiltFrame = energyFirstBuiltFrame
              FactoryBuiltCount = factoryBuiltCount
              FactoryFirstBuiltFrame = factoryFirstBuiltFrame
              FirstCombatUnitFrame = firstCombatUnitFrame
              CrashMessage = crashMessage
              WeaponFiredCount = weaponFiredCount
              UnitDamagedCount = unitDamagedCount
              EnemyDamagedCount = enemyDamagedCount
              UnitDestroyedCount = unitDestroyedCount
              EnemyDestroyedCount = enemyDestroyedCount }

        with ex ->
            session.Stop(false)
            emptyOutcome gameNumber ex.Message

    /// Run N sequential games, each with a fresh engine instance.
    let runGames (n: int) (setupFile: string) (maxFrames: int) (engineBin: string option) : GameOutcome list =
        [ for i in 1..n do
            yield runSingleGame i setupFile maxFrames engineBin ]


/// Fixture for headless engine AI validation tests.
type HeadlessAiFixture() =

    /// Run N sequential games using the headless engine.
    member _.RunGames(n: int, setupFile: string, ?maxFrames: int) : GameOutcome list =
        let frames = defaultArg maxFrames 18000
        GameOrchestrator.runGames n setupFile frames None

    /// Reports output directory.
    member _.ReportsDir = GameOrchestrator.reportsDir

    interface IAsyncLifetime with
        member _.InitializeAsync() = task {
            GameOrchestrator.checkPrerequisites()
            Directory.CreateDirectory(GameOrchestrator.reportsDir) |> ignore
        }
        member _.DisposeAsync() = Task.CompletedTask


/// Fixture for live graphical engine AI validation tests.
type LiveAiFixture() =
    let liveBin =
        let env = Environment.GetEnvironmentVariable("HIGHBAR_LIVE_ENGINE")
        if not (String.IsNullOrEmpty(env)) then env
        else
            let defaultPath = "/home/developer/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring"
            if File.Exists(defaultPath) then defaultPath
            else "spring"

    /// Run N sequential games using the live graphical engine.
    member _.RunGames(n: int, setupFile: string, ?maxFrames: int) : GameOutcome list =
        let frames = defaultArg maxFrames 108000
        GameOrchestrator.runGames n setupFile frames (Some liveBin)

    /// Reports output directory.
    member _.ReportsDir = GameOrchestrator.reportsDir

    /// Whether the live engine environment is available.
    member _.IsAvailable =
        let display = Environment.GetEnvironmentVariable("DISPLAY")
        not (String.IsNullOrEmpty(display))

    interface IAsyncLifetime with
        member _.InitializeAsync() = task {
            let display = Environment.GetEnvironmentVariable("DISPLAY")
            if String.IsNullOrEmpty(display) then
                failwith "Live engine tests require DISPLAY (run Xvfb or set DISPLAY)"
            GameOrchestrator.checkPrerequisites()
            Directory.CreateDirectory(GameOrchestrator.reportsDir) |> ignore
        }
        member _.DisposeAsync() = Task.CompletedTask


// xUnit collection definitions

[<CollectionDefinition("AIEndToEnd")>]
type AIEndToEndCollection() =
    interface ICollectionFixture<HeadlessAiFixture>

[<CollectionDefinition("AINonCombat")>]
type AINonCombatCollection() =
    interface ICollectionFixture<HeadlessAiFixture>

[<CollectionDefinition("AICompetitive")>]
type AICompetitiveCollection() =
    interface ICollectionFixture<LiveAiFixture>

[<CollectionDefinition("AICombat")>]
type AICombatCollection() =
    interface ICollectionFixture<LiveAiFixture>
