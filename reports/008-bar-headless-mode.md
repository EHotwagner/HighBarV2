# Report: Running Beyond All Reason in Headless Mode

**Date**: 2026-04-03
**Iteration**: 003

## Context

Comprehensive reference for running Beyond All Reason (BAR) using the Recoil engine's headless and dedicated server binaries. Covers local AI simulation, replay analysis, multiplayer hosting via SPADS, and integration with HighBarV2's proxy testing infrastructure.

## 1. Engine Binary Types

The Recoil engine (forked from the original SpringRTS engine) ships three distinct binaries:

| Binary | Simulation | Rendering | Networking | Primary Use |
|--------|-----------|-----------|------------|-------------|
| `spring` | Yes | Yes | Yes | Normal gameplay with full graphics |
| `spring-headless` | Yes | No | Yes | AI testing, replay analysis, small-scale hosting |
| `spring-dedicated` | No | No | Yes (relay) | Large-scale multiplayer hosting (no sim) |

### spring-headless

Runs the full game simulation without any graphical or audio output. Lua widgets still function and are the primary mechanism for programmatic input and data extraction. All rendering-related call-ins and call-outs become no-ops.

**Use cases:**
- AI vs AI simulation at maximum speed (~6x faster than real-time, ~5ms/frame)
- Replay analysis and statistics extraction via Lua widgets
- Small-scale multiplayer hosting (tournament-level games)
- Automated integration testing (e.g., HighBarV2 test harness)

### spring-dedicated

Does **not** run simulation at all. Instead, it collects and relays network traffic between players, who each run the simulation locally. Substantially lighter weight than `spring-headless`.

**Use cases:**
- Large-scale multiplayer hosting where server CPU is a constraint
- Production autohost deployments serving many concurrent games
- Scenarios where replay verification can happen after the fact

## 2. Command-Line Reference

### Basic Invocation

```bash
spring-headless [OPTIONS] SCRIPT
```

Where `SCRIPT` is a start script file (script.txt), replay file (*.sdfz), or save game (*.ssf).

### Key Options

| Option | Description |
|--------|-------------|
| `--write-dir PATH` | Directory for all save output (logs, demos, settings) |
| `--isolation` / `-i` | Limit data scanner to a single directory |
| `--isolation-dir PATH` | Specify the isolation-mode data directory |
| `--config FILE` / `-C` | Use an exclusive configuration file |
| `--name STRING` / `-n` | Set the player name |
| `--server IP` / `-s` | Run as server, connecting to the specified address |
| `--game GAME` / `-g` | Start a game directly (requires `--map`) |
| `--map MAP` / `-m` | Specify the map (requires `--game`) |
| `--safemode` | Disable features that may cause issues |
| `--list-skirmish-ais` | Output available AI implementations |
| `--list-ai-interfaces` | Output available AI interface libraries |
| `--list-config-vars` | Output all config variables as JSON |
| `--nocolor` | Disable colored terminal output |
| `--version` / `-V` | Show version information |
| `--sync-version` | Show sync version (for online play compatibility) |

### Environment Variables

| Variable | Purpose |
|----------|---------|
| `SPRING_LOG_SECTIONS` | Control log verbosity by section (comma-separated) |
| `SPRING_WRITEDIR` | Custom write directory (alternative to `--write-dir`) |
| `SPRING_DATADIR` | Additional data directories (colon-separated on Linux) |
| `SPRING_ISOLATED` | Enable isolation mode; optionally specify directory |
| `SPRING_NOCOLOR` | Equivalent to `--nocolor` flag |

### Data Directory Hierarchy

The engine scans directories in priority order:

1. **High**: Custom write directory (`--write-dir` or `SPRING_WRITEDIR`)
2. **Medium**: `~/.config/spring/`, system directories (`/etc/spring/`, `/usr/share/spring/`)
3. **Low**: `SPRING_DATADIR` paths, SpringData config tag

Within each directory, the engine looks for: `games/`, `maps/`, `AI/`, `configs/`, `logs/`, `cache/`.

### Isolation Mode

Restricts data scanning to a single folder. Enable via any of:
- `--isolation` or `--isolation-dir PATH` flags
- An empty `isolated.txt` file next to the engine binary
- The `SPRING_ISOLATED` environment variable

This is essential for running multiple concurrent game instances (e.g., test harness, CI) without data directory conflicts.

## 3. Start Script Format (script.txt)

The start script is the primary configuration mechanism for launching a game. Lobbies and autohosts generate these automatically; for headless testing, you create them manually.

### Full Structure

```ini
[GAME]
{
    // === Core Settings ===
    MapName=map_name.smf;
    GameType=Game Name;         // mod name, rapid tag, or archive
    IsHost=1;                   // 1=host, 0=client
    GameStartDelay=4;           // seconds before game starts

    // === Start Position Mode ===
    StartPosType=0;             // 0=fixed, 1=random, 2=in-game, 3=pre-game

    // === Recording ===
    RecordDemo=1;               // 0 to disable replay recording

    // === Autohost Integration ===
    AutohostIP=127.0.0.1;      // IP the autohost listens on
    AutohostPort=8454;          // UDP port for autohost protocol

    // === Structure Counts ===
    NumPlayers=0;               // human players
    NumTeams=2;                 // teams in the game
    NumAllyTeams=2;             // alliance groups

    // === Replay Mode ===
    // DemoFile=replay.sdfz;   // play back a recorded game

    // === Player Section (for each human player) ===
    [PLAYER0]
    {
        Name=PlayerName;
        Spectator=0;            // 1 for observer
        Team=0;
        CountryCode=us;
        Rank=0;
    }

    // === AI Section (for each AI) ===
    [AI0]
    {
        Name=Bot1;              // display name
        ShortName=BARb;         // AI library name (e.g., BARb, SimpleAI, NullAI)
        Team=0;                 // which team this AI controls
        Host=0;                 // which player's machine runs the AI
        Version=<default>;
        [OPTIONS]
        {
            // AI-specific key=value pairs
            difficultyLevel=2;
        }
    }

    [AI1]
    {
        Name=Bot2;
        ShortName=BARb;
        Team=1;
        Host=0;
        Version=<default>;
    }

    // === Team Definitions ===
    [TEAM0]
    {
        TeamLeader=0;
        AllyTeam=0;
        RgbColor=0.2 0.4 0.9;  // RGB values in [0,1] range
        Side=Armada;            // faction name
        Advantage=0.0;          // resource meta value factor [-1.0, 1.0]
        IncomeMultiplier=1.0;   // resource income multiplier [0.0, 2.0]
    }

    [TEAM1]
    {
        TeamLeader=0;
        AllyTeam=1;
        RgbColor=0.9 0.2 0.2;
        Side=Cortex;
    }

    // === Alliance Definitions ===
    [ALLYTEAM0]
    {
        NumAllies=0;
        // Start box for position selection (values in [0,1] = fraction of map)
        StartRectLeft=0.0;
        StartRectTop=0.0;
        StartRectRight=0.25;
        StartRectBottom=1.0;
    }

    [ALLYTEAM1]
    {
        NumAllies=0;
        StartRectLeft=0.75;
        StartRectTop=0.0;
        StartRectRight=1.0;
        StartRectBottom=1.0;
    }

    // === Mod Options ===
    [MODOPTIONS]
    {
        StartMetal=1000;
        StartEnergy=1000;
        MaxUnits=500;           // per team
        MaxSpeed=9999;          // unlock maximum game speed
        MinSpeed=9999;          // force maximum speed in headless
        GameMode=0;             // 0=commander dies, 1=lineage, 2=KillAll, 3=off
        FixedAllies=1;
        LuaGaia=1;
        LuaRules=1;
        NoHelperAIs=0;
        DisableMapDamage=0;
        GhostedBuildings=1;
    }

    // === Map Options ===
    [MAPOPTIONS]
    {
        // map-specific key=value pairs
    }

    // === Unit Restrictions ===
    [RESTRICT]
    {
        // Unit0=unitname;
        // Limit0=0;           // 0=disabled, >0=build limit
    }
}
```

### Key Notes

- Property keys are **case-insensitive**
- Comments use `//` notation
- IP addresses support IPv4 and IPv6 (hostnames are **not** supported)
- `GameType` can be a mod name, rapid tag (since engine 99.0), or archive filename
- `MUTATOR0..9` sections can load additional archives (since engine 97.0)

### Minimal Headless AI-vs-AI Script

```ini
[GAME]
{
    MapName=Red Comet Remake 1.8;
    GameType=Beyond All Reason test-27612-e70fbc0;
    IsHost=1;
    StartPosType=2;
    NumPlayers=0;
    NumTeams=2;
    NumAllyTeams=2;

    [AI0]
    {
        ShortName=BARb;
        Team=0;
        Host=0;
    }

    [AI1]
    {
        ShortName=BARb;
        Team=1;
        Host=0;
    }

    [TEAM0]   { TeamLeader=0; AllyTeam=0; Side=Armada; }
    [TEAM1]   { TeamLeader=0; AllyTeam=1; Side=Cortex; }
    [ALLYTEAM0] { NumAllies=0; }
    [ALLYTEAM1] { NumAllies=0; }

    [MODOPTIONS]
    {
        MaxSpeed=9999;
        MinSpeed=9999;
    }
}
```

### Replay Playback Script

```ini
[GAME]
{
    DemoFile=path/to/replay.sdfz;
}
```

## 4. Running Headless Locally

### Prerequisites

- Engine binary (`spring-headless` or `spring-headless.exe`)
- Game files (BAR mod archive)
- Map files
- (Optional) AI libraries

### Step-by-Step: AI vs AI Game

1. **Get the engine binary**: Download from [Recoil engine releases](https://github.com/beyond-all-reason/spring/releases) or extract from a BAR installation.

2. **Get game files**: Use `pr-downloader` to fetch the correct game version:
   ```bash
   pr-downloader --filesystem-writepath /path/to/data --download-game "Beyond All Reason test-XXXXX-XXXXXXX"
   ```

3. **Get maps**: Download map archives into the `maps/` subdirectory of your data path.

4. **Create the start script**: Write `_script.txt` with game configuration (see Section 3).

5. **Set speed options** in `[MODOPTIONS]`:
   ```ini
   MinSpeed=9999;
   MaxSpeed=9999;
   ```
   This forces the engine to run at maximum simulation speed.

6. **Run**:
   ```bash
   spring-headless --write-dir /path/to/data _script.txt
   ```

7. **Collect output**: Replays are saved to the `demos/` directory under the write path.

### Step-by-Step: Replay Analysis

1. Place the replay file (`.sdfz`) in an accessible location.

2. Ensure the correct game version and map are available (use `pr-downloader` if needed).

3. (Optional) Install a Lua widget for data extraction in `LuaUI/Widgets/`:
   - Widgets can output CSV/JSON data during replay playback
   - Common outputs: unit definitions, team statistics per frame, unit creation/destruction events, spawn positions

4. Create a minimal replay script:
   ```ini
   [GAME]
   {
       DemoFile=demos/20260401_123456_Red_Comet.sdfz;
   }
   ```

5. Run:
   ```bash
   spring-headless --write-dir /path/to/data _script.txt
   ```

### Performance Characteristics

| Metric | Value |
|--------|-------|
| Headless vs normal speed | ~3x faster (normal mode), ~6x faster (headless) |
| Frame time (AI vs AI) | ~5ms per frame |
| Memory usage | Similar to graphical mode minus GPU buffers |
| CPU usage | Single-threaded simulation; no GPU required |

## 5. Multiplayer Hosting with SPADS

### Architecture Overview

SPADS (Spring Perl Autohost for Dedicated Server) is the standard autohost for BAR multiplayer. The multiplayer flow is:

```
Players (Chobby lobby) <--SpringLobby protocol--> Teiserver (lobby server)
                                                        |
                                                    SPADS (autohost)
                                                        |
                                              Recoil Engine (dedicated/headless)
                                                        |
                                                  Autohost Protocol (UDP)
```

1. Players connect to Teiserver via Chobby (the BAR lobby client)
2. SPADS manages battle rooms, player balancing, and game configuration
3. When a game starts, SPADS launches a `spring-dedicated` or `spring-headless` instance
4. SPADS communicates with the engine via the Autohost protocol on a local UDP port
5. Players connect directly to the engine instance for gameplay

### SPADS Installation

**Prerequisites (Linux):**
```bash
# Debian/Ubuntu
apt install perl perl-modules libffi-platypus-perl libio-socket-ssl-perl libdbd-sqlite3-perl

# RedHat/Fedora/CentOS
dnf install perl perl-core perl-FFI-Platypus perl-IO-Socket-SSL perl-DBD-SQLite
```

**Prerequisites (Windows):**
- Install Strawberry Perl from https://strawberryperl.com
- Add Perl bin directory to PATH

**Installation steps:**
```bash
mkdir /opt/spads && cd /opt/spads
wget http://planetspads.free.fr/spads/installer/spadsInstaller.tar
tar xf spadsInstaller.tar
perl spadsInstaller.pl
```

The installer prompts for:
- Engine type and path
- Lobby server address
- Bot account credentials
- Network configuration (host IP, port)

### Key SPADS Configuration Files

| File | Purpose |
|------|---------|
| `spads.conf` | Global settings (lobby connection, autohost port, paths) |
| `hostingPresets.conf` | Game hosting port, max players, team sizes |
| `battlePresets.conf` | Map rotation, mod options, game settings |

### Critical Settings in spads.conf

```perl
# Lobby connection
lobbyLogin:YourBotName
lobbyPassword:YourBotPassword
lobbyHost:server4.beyondallreason.info

# Engine configuration
engineDir:/opt/spads/engine/
springDataDir:/opt/spads/data/

# Autohost protocol (local UDP between SPADS and engine)
autoHostPort:8454

# Hosting
hostPort:8452          # Port players connect to (must be forwarded)
hostIp:0.0.0.0         # Bind address
```

### Network Requirements

| Port | Protocol | Direction | Purpose |
|------|----------|-----------|---------|
| 8452 | UDP | Inbound | Player connections to game server |
| 8454 | UDP | Local only | SPADS <-> engine autohost protocol |
| 8200 | TCP | Outbound | SPADS <-> lobby server (Teiserver) |

**Only port 8452 (or your configured `hostPort`) needs to be forwarded** for external players to connect. The autohost port (8454) is local-only communication between SPADS and the engine process.

### BAR-Specific SPADS Configuration

The official BAR SPADS configuration is maintained at [beyond-all-reason/spads_config_bar](https://github.com/beyond-all-reason/spads_config_bar). Key features:

- **Automated updates**: Systemd timers sync maps (via rclone from Google Drive), game versions (via pr-downloader), and SPADS config daily at noon UTC
- **Multi-instance support**: `spads@.service` template for running multiple instances on one host
- **Cluster deployment**: `spads_cluster_launcher.sh` for multi-host setups with autoregister and clustermanager plugins
- **BarManager plugin**: Requires `Inline::Python` Perl module for BAR-specific game management
- **Docker support**: Dockerfile provided for containerized deployments

### Map Synchronization

```bash
# Configure rclone with Google Drive access
rclone config
# Then sync maps
rclone sync --drive-shared-with-me BYAR-maps:BYAR-maps /opt/spads/data/maps/
```

### Starting SPADS

```bash
# Single instance
perl spads.pl etc/spads.conf

# Via systemd (production)
systemctl start spads@host01

# Multiple instances
systemctl start spads@host01 spads@host02 spads@host03
```

### Running the Service

```bash
# Launch
perl spads.pl etc/spads.conf

# Via systemd
systemctl enable --now spads.service
```

## 6. Recoil Autohost (Next-Generation)

The BAR project is developing a new autohost implementation: [recoil-autohost](https://github.com/beyond-all-reason/recoil-autohost). Written in TypeScript, it replaces SPADS's SpringLobby protocol with the Tachyon protocol.

### Configuration (JSON)

```json
{
    "tachyonServer": "wss://server4.beyondallreason.info/tachyon",
    "authClientId": "your-client-id",
    "authClientSecret": "your-client-secret",
    "hostingIP": "203.0.113.1"
}
```

### Architecture

- Receives battle start requests via Tachyon protocol from Teiserver
- Creates isolated instance directories per battle (UUID-named)
- Manages engine version selection from an `engines/` folder
- Includes a fake Tachyon server (`tachyonServer.fake.ts`) for local development/testing

This is not yet production-ready but represents the direction BAR infrastructure is heading.

## 7. Infrastructure Overview

The full BAR multiplayer infrastructure consists of:

| Component | Technology | Role |
|-----------|-----------|------|
| **Teiserver** | Elixir/Phoenix + PostgreSQL | Lobby server: accounts, matchmaking, ratings, moderation |
| **Chobby** | Lua (in-engine lobby) | Player-facing lobby client |
| **SPADS** | Perl + Python plugins | Battle room management, autohost |
| **Recoil Engine** | C++ | Game simulation (headless/dedicated) |
| **pr-downloader** | C++ | Game/engine version management |
| **BAR Live Services** | bar-rts.com | Replay hosting, live match listings |
| **Spring Launcher** | Electron | Game launcher, asset delivery |
| **Ansible** | YAML/Python | Server provisioning and configuration management |

### Production Deployment (via Ansible)

The [ansible-spads-setup](https://github.com/beyond-all-reason/ansible-spads-setup) repository automates:

- SPADS installation and configuration across regional servers (US, EU, AU)
- Engine updates via `spads_config_bar_updater.py`
- Bot account registration with Teiserver
- Service lifecycle management (start/stop/restart)
- Log retrieval and monitoring

```bash
# Deploy configuration
ansible-playbook play.yaml -i inventory/prod --ask-vault-pass

# Update engine on specific host
ansible-playbook engineupdate.yaml --limit us-server-01

# Register a new bot account
ansible-playbook register_bot.yaml -i inventory/prod --ask-vault-pass
```

Variable hierarchy (highest to lowest priority):
1. `host_vars/(hostname).yaml` -- Host-specific overrides
2. `group_vars/(region).yaml` -- Regional settings
3. `group_vars/prod/vars.yaml` -- Production defaults
4. `group_vars/all.yaml` -- Global defaults

## 8. Relevance to HighBarV2

### Test Harness Integration

The HighBarV2 test harness (`tests/fixtures/start-headless.sh`) uses `spring-headless` to:

1. Launch a headless engine instance with a game scenario (`game-setup.lua`)
2. Establish a Unix domain socket for IPC between the proxy plugin and test client
3. Run integration tests against the live proxy

**Current limitation**: The headless engine binary is not bundled with the repository. Tests require either `spring-headless` on PATH or the `HIGHBAR_TEST_ENGINE` environment variable set.

### Recommended Setup for Developers

```bash
# Option A: Install spring-headless system-wide
# Download from https://github.com/beyond-all-reason/spring/releases
cp spring-headless /usr/local/bin/

# Option B: Point to a local installation
export HIGHBAR_TEST_ENGINE=/path/to/spring-headless

# Required: game files and maps in the data directory
export SPRING_DATADIR=/path/to/bar-data
```

### AI Plugin Development Workflow

For developing the HighBarV2 proxy plugin against the headless engine:

1. Build the proxy: `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build`
2. Place `libSkirmishAI.so` in the engine's `AI/Skirmish/HighBar/` directory
3. Create a start script referencing the HighBar AI
4. Run: `spring-headless --write-dir /tmp/highbar-test _script.txt`
5. The proxy opens a Unix socket; connect with the F# or Python client

## 9. Troubleshooting

| Problem | Cause | Solution |
|---------|-------|---------|
| `Engine process not found after start` | `spring-headless` not installed or not on PATH | Install binary or set `HIGHBAR_TEST_ENGINE` |
| `Engine socket not ready after 30s` | Engine crashed at startup or missing game files | Check engine stderr; ensure maps and mods are in data dir |
| Engine exits immediately | Missing or corrupt game archive | Run `pr-downloader` to fetch correct game version |
| `Sync error` when connecting | Engine version mismatch between server and client | Ensure all participants use the same engine version |
| SPADS won't start | Missing Perl modules | Install `FFI::Platypus`, `IO::Socket::SSL`, `DBD::SQLite` |
| Players can't connect | Port 8452 not forwarded | Forward UDP port 8452 (or configured `hostPort`) |
| Maps not loading | Maps directory not in data path | Verify `SPRING_DATADIR` includes your maps directory |
| Multiple instances conflict | Shared data directories | Use `--isolation-dir` per instance |
| Headless not exiting after game | Known engine issue | Monitor process and force-kill after timeout |

## Sources

- [Yarsh Technologies: BAR Headless](https://neek-sss.gitlab.io/yarsh-technologies-blog/posts/bar_headless/)
- [Recoil Engine: Headless and Dedicated](https://recoilengine.org/docs/guides/getting-started/headless-and-dedicated/)
- [SPADS Wiki](https://github.com/Yaribz/SPADS/wiki/)
- [Ansible SPADS Setup](https://github.com/beyond-all-reason/ansible-spads-setup)
- [BAR SPADS Config](https://github.com/beyond-all-reason/spads_config_bar)
- [Recoil Autohost](https://github.com/beyond-all-reason/recoil-autohost)
- [BAR Infrastructure Docs](https://beyond-all-reason.github.io/infrastructure/)
- [Spring Engine Script.txt Format](https://springrts.com/wiki/Script.txt)
- [Spring StartScriptFormat.txt](https://github.com/spring/spring/blob/develop/doc/StartScriptFormat.txt)
- [spring-headless Man Page](https://manpages.ubuntu.com/manpages/bionic/man6/spring-headless.6.html)
- [BAR Self-Hosting FAQ](https://www.beyondallreason.info/faq/can-i-host-a-server-by-myself)
- [BAR AI System (DeepWiki)](https://deepwiki.com/beyond-all-reason/Beyond-All-Reason/8-ai-system)
