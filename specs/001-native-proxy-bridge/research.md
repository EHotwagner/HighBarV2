# Research: Native C Proxy Bridge

**Feature**: 001-native-proxy-bridge | **Date**: 2026-04-02

## 1. Recoil Engine Skirmish AI C Interface

**Decision**: Implement against the standard `SSkirmishAILibrary` interface with 3 required exports.

**Key Details**:
- `int init(int skirmishAIId, const struct SSkirmishAICallback* callback)` — returns 0 on success; store callback pointer for later use
- `int release(int skirmishAIId)` — cleanup; returns 0
- `int handleEvent(int skirmishAIId, int topicId, const void* data)` — cast `data` based on `topicId` enum; return 0 on success, non-zero signals engine to remove AI
- `SSkirmishAICallback` is a struct of 200+ function pointers, all taking `skirmishAIId` as first param. Callbacks may only be called from within `handleEvent` (engine thread).
- Command execution: `Engine_handleCommand(skirmishAIId, toId, commandId, commandTopic, void* commandData)`

**Source**: Spring/Recoil headers — `SSkirmishAILibrary.h`, `AISEvents.h`, `AISCommands.h`, `SSkirmishAICallback.h`

**Alternatives Considered**: Lua AI interface via Shard gadget — rejected per constitution (binary protocol requirement, performance).

## 2. Event Types (28)

**Decision**: Map all 28 `EventTopic` enum values to protobuf messages with 1:1 field mapping.

**Key Details**: EVENT_NULL(0), EVENT_INIT(1), EVENT_RELEASE(2), EVENT_UPDATE(3), EVENT_MESSAGE(4), EVENT_UNIT_CREATED(5), EVENT_UNIT_FINISHED(6), EVENT_UNIT_IDLE(7), EVENT_UNIT_MOVE_FAILED(8), EVENT_UNIT_DAMAGED(9), EVENT_UNIT_DESTROYED(10), EVENT_UNIT_GIVEN(11), EVENT_UNIT_CAPTURED(12), EVENT_ENEMY_ENTER_LOS(13), EVENT_ENEMY_LEAVE_LOS(14), EVENT_ENEMY_ENTER_RADAR(15), EVENT_ENEMY_LEAVE_RADAR(16), EVENT_ENEMY_DAMAGED(17), EVENT_ENEMY_DESTROYED(18), EVENT_WEAPON_FIRED(19), EVENT_PLAYER_COMMAND(20), EVENT_SEISMIC_PING(21), EVENT_COMMAND_FINISHED(22), EVENT_LOAD(23), EVENT_SAVE(24), EVENT_ENEMY_CREATED(25), EVENT_ENEMY_FINISHED(26), EVENT_LUA_MESSAGE(27).

Event structs contain int unit/enemy IDs, float damage values, float[3] position vectors, int weaponDefIds, and string messages.

## 3. Command Types (97)

**Decision**: Map all 97 `CommandTopic` values to protobuf command messages.

**Key Details**: Commands cover drawing (1-3), chat/resources (4-9), groups (12-15), pathfinding (16-19), cheats (20, 79), Lua calls (21, 96), drawer figures (22-34), and unit commands (35-78: build, stop, wait, move, patrol, fight, attack, guard, repair, reclaim, restore, resurrect, capture, setbase, selfd, loadunits, unloadunits, setwantedmaxspeed, stockpile, dgun, custom).

Common struct pattern: `{int unitId; int groupId; short options; int timeOut; ...type-specific fields}`.

## 4. Callback Interface (200+ functions)

**Decision**: Expose via generic `CallbackRequest`/`CallbackResponse` with a callback ID enum.

**Key Details**: Categories — `Engine_*` (handleCommand, version), `Game_*` (teams, mode), `Unit_*` (position, health, current orders), `UnitDef_*` (type definitions, build options, weapons), `Map_*` (heightmap, LOS map, resource spots, metal map), `Resource_*`/`Economy_*`, `Team_*`, `Mod_*`, `Cheats_*`, `DataDirs_*`.

All callbacks take `skirmishAIId` as first param, return int/float/const char*/float[3] depending on function. Map data callbacks return pointers to arrays with known dimensions.

## 5. Protobuf Message Envelope Design

**Decision**: Top-level envelope message with `oneof` per direction.

**Rationale**: `oneof` provides built-in type discrimination without manual type bytes. Efficient wire encoding (just field tags). Frame batching via `repeated EngineEvent events` inside a `Frame` message.

**Alternatives Considered**:
- Type discriminator byte prefix — manual enum mapping, error-prone, duplicates what oneof provides
- `Any` type — runtime type URL resolution, adds overhead in C
- Separate top-level messages per type — 125+ types makes manual dispatch untenable

## 6. Proto3 Zero-Value Semantics

**Decision**: Use `optional` keyword (proto3 syntax, available since protobuf 3.15+).

**Rationale**: `optional int32 attacker_id` generates `has_attacker_id` presence check in protobuf-c. Cleanly distinguishes "value is 0" from "not set". Map "not set" to engine sentinel -1. Simpler and more performant than wrapper types.

**Alternatives Considered**:
- google.protobuf.wrappers (Int32Value) — heap-allocates sub-message per field in C, unacceptable overhead
- Sentinel convention (-1 in proto) — defeats typed schema purpose

## 7. C Code Generation: protobuf-c

**Decision**: Use `protobuf-c` for C code generation and runtime.

**Rationale**: Most mature C protobuf library. Generates straightforward structs. Supports arena allocation via `ProtobufCAllocator` — bump allocate in `alloc`, no-op `free`, reset pointer per frame. Eliminates per-message malloc/free.

**Alternatives Considered**:
- nanopb — embedded focus, no arena support, fixed-size arrays need compile-time bounds
- upb — Google's micro protobuf, supports arenas but unstable C API, sparse docs

## 8. Client Library Code Generation

**Decision**:
- **F#/.NET**: Standard `protoc --csharp_out` + `Google.Protobuf` NuGet. Wrap generated C# in F# discriminated unions for idiomatic pattern matching.
- **Python**: `betterproto` — generates dataclass-based code with type hints and `which_one_of()` for oneof. Standard protoc output is untyped and non-idiomatic.
- **Tooling**: `buf` for linting (`buf lint`) and generation (`buf generate`) orchestrating all three language plugins.

## 9. BAR AI Plugin Loading

**Decision**: Install as standard Skirmish AI plugin in `AI/Skirmish/HighBarV2/<version>/`.

**Key Details**: Required files:
- `AIInfo.lua` — metadata: `shortName="HighBarV2"`, `interfaceShortName="C"`, `interfaceVersion="0.1"`
- `AIOptions.lua` — configurable options (socket_path, timeout_ms, log_level, frame_mode, push_state)
- `SkirmishAI.so` (Linux) / `SkirmishAI.dll` (Windows)

Engine discovers AI by scanning `AI/Skirmish/*/` directories, reads `AIInfo.lua`, loads the shared library via the C AI Interface.

## 10. Frame Batching Pattern

**Decision**: `Frame` message containing `uint32 frame_number` + `repeated EngineEvent events`.

**Rationale**: Single arena allocation per frame in C, single socket write, single parse call on receiver. Length-prefixed on wire (4-byte LE size header + serialized Frame).
