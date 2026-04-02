# HighBar V2 Research & Specifications

## Project Goal

Build a **native C proxy shared library** for the Recoil engine (Beyond All Reason) that forwards AI events and commands over **protobuf-serialized Unix domain sockets** to an external process, enabling AI development in any language.

## Research Documents

| # | Document | Description |
|---|----------|-------------|
| 01 | [Recoil Engine AI Interface](01-recoil-engine-ai-interface.md) | Complete technical reference for the engine's AI system: 28 events, 97 commands, 200+ callback functions, loading sequence |
| 02 | [HighBar V1 Analysis](02-highbar-v1-analysis.md) | Analysis of the existing HighBar project (Lua bridge + NDJSON/TCP + Python client), its architecture, limitations, and lessons learned |
| 03 | [BAR AI Ecosystem](03-bar-ai-ecosystem.md) | Overview of both AI systems (native C vs Lua), the Shard framework, existing tools (CircuitAI, Rust bindings), and why no out-of-process proxy exists yet |
| 04 | [Protobuf IPC Patterns](04-protobuf-ipc-patterns.md) | Best practices for protobuf over pipes/sockets: framing, multiplexing, transport comparison, threading, error handling, SC2API as reference |
| 05 | [Architecture Specification](05-architecture-spec.md) | V2 system design: proxy library, protocol, frame synchronization, callback queries, file layout, performance targets |
| 06 | [Protobuf Schema Design](06-protobuf-schema-design.md) | Complete `.proto` message definitions for all events, commands, callbacks, and frame-level messages |
| 07 | [Implementation Roadmap](07-implementation-roadmap.md) | Phased development plan from foundation through production hardening and advanced features |

## Key Architecture Decision

**V1 approach** (Lua bridge): Zero engine mods, but limited by JSON serialization overhead, Lua VM bottleneck, and partial API coverage.

**V2 approach** (Native C proxy): Still zero engine mods (standard AI plugin), but with full API access (28 events, 97 commands, 200+ callbacks), binary protobuf serialization, and Unix socket transport for ~10x lower latency.

## Reference Projects

- [RecoilEngine AI/Skirmish](https://github.com/beyond-all-reason/RecoilEngine/tree/master/AI/Skirmish) -- Engine AI interface
- [Beyond All Reason](https://github.com/beyond-all-reason/Beyond-All-Reason) -- The game
- [HighBar V1](https://github.com/EHotwagner/HighBar/tree/master) -- Previous Lua bridge approach
- [SC2API Proto](https://github.com/Blizzard/s2client-proto) -- Reference architecture (protobuf game AI proxy)
