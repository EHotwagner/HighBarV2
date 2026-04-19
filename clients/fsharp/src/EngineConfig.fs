namespace HighBar.Client

open System
open System.IO
open System.Text.Json

/// Specifies whether the engine runs headless (no GUI) or with a graphical window.
type EngineMode =
    | Headless
    | Graphical

/// Configuration record for an engine session. Controls engine launch parameters,
/// socket communication, game setup, and timeout behavior.
type EngineConfig = {
    Mode: EngineMode
    SocketPath: string
    MapName: string
    GameType: string
    EngineBin: string
    DataDir: string option
    OpponentAI: string
    OpponentSide: string
    OurSide: string
    AcceptTimeoutMs: int
    ReadTimeoutMs: int
    GameSpeed: int
    ShutdownGraceMs: int
}

module EngineConfig =

    /// Create a default config with a unique GUID-based socket path.
    let defaultConfig () =
        let guid = Guid.NewGuid().ToString("N")[..7]
        { Mode = Headless
          SocketPath = $"/tmp/highbar-{guid}.sock"
          MapName = "Avalanche 3.4"
          GameType = "Beyond All Reason test-29871-90f4bc1"
          EngineBin = "spring-headless"
          DataDir = None
          OpponentAI = "NullAI"
          OpponentSide = "Cortex"
          OurSide = "Armada"
          AcceptTimeoutMs = 30000
          ReadTimeoutMs = 10000
          GameSpeed = 10
          ShutdownGraceMs = 5000 }

    /// Load defaults from engine-version.json, then apply environment variable overrides.
    let fromVersionFile (path: string) =
        let base' = defaultConfig ()
        let mutable config = base'

        if File.Exists(path) then
            let json = File.ReadAllText(path)
            use doc = JsonDocument.Parse(json)
            let root = doc.RootElement

            let tryGetString (parent: JsonElement) (prop: string) =
                match parent.TryGetProperty(prop) with
                | true, el when el.ValueKind = JsonValueKind.String -> Some (el.GetString())
                | _ -> None

            match root.TryGetProperty("engine") with
            | true, engine ->
                match tryGetString engine "binary" with
                | Some bin -> config <- { config with EngineBin = bin }
                | None -> ()
            | _ -> ()

            match root.TryGetProperty("game") with
            | true, game ->
                match tryGetString game "name" with
                | Some name -> config <- { config with GameType = name }
                | None -> ()
                // Prefer dynamically-resolved name from rapid/versions.gz when
                // a rapidTag is configured — the hardcoded json name goes
                // stale every few days as upstream cuts test releases.
                match tryGetString game "rapidTag" with
                | Some tag ->
                    match EngineDiscovery.defaultDataDir () with
                    | Some dd ->
                        match EngineDiscovery.discoverGameName dd tag with
                        | Some resolved -> config <- { config with GameType = resolved }
                        | None -> ()
                    | None -> ()
                | None -> ()
            | _ -> ()

            match root.TryGetProperty("map") with
            | true, map ->
                match tryGetString map "name" with
                | Some name -> config <- { config with MapName = name }
                | None -> ()
            | _ -> ()

        // Apply environment variable overrides
        match Environment.GetEnvironmentVariable("HIGHBAR_TEST_ENGINE") with
        | null | "" -> ()
        | v -> config <- { config with EngineBin = v }

        match Environment.GetEnvironmentVariable("HIGHBAR_TEST_MAP") with
        | null | "" -> ()
        | v -> config <- { config with MapName = v }

        match Environment.GetEnvironmentVariable("SPRING_DATADIR") with
        | null | "" -> ()
        | v -> config <- { config with DataDir = Some v }

        match Environment.GetEnvironmentVariable("HIGHBAR_TEST_TIMEOUT") with
        | null | "" -> ()
        | v ->
            match Int32.TryParse(v) with
            | true, secs -> config <- { config with AcceptTimeoutMs = secs * 1000 }
            | _ -> ()

        match Environment.GetEnvironmentVariable("HIGHBAR_CLIENT_TIMEOUT_MS") with
        | null | "" -> ()
        | v ->
            match Int32.TryParse(v) with
            | true, ms -> config <- { config with ReadTimeoutMs = ms }
            | _ -> ()

        config

    /// Validate the configuration, raising an exception if invalid.
    let validate (config: EngineConfig) =
        if String.IsNullOrWhiteSpace(config.EngineBin) then
            failwith "EngineConfig.EngineBin must be non-empty"
        if String.IsNullOrWhiteSpace(config.MapName) then
            failwith "EngineConfig.MapName must be non-empty"
        if String.IsNullOrWhiteSpace(config.GameType) then
            failwith "EngineConfig.GameType must be non-empty"
        if config.AcceptTimeoutMs <= 0 then
            failwith $"EngineConfig.AcceptTimeoutMs must be positive, got {config.AcceptTimeoutMs}"
        if config.ReadTimeoutMs <= 0 then
            failwith $"EngineConfig.ReadTimeoutMs must be positive, got {config.ReadTimeoutMs}"
        config
