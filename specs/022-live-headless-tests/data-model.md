# Data Model: 022-live-headless-tests

**Date**: 2026-04-05

This feature is a test infrastructure migration — no new data entities are introduced. The key entities are existing test artifacts being reorganized.

## Test Disposition Registry

Each existing mock test receives a disposition decision:

| Attribute | Description |
|-----------|-------------|
| Test file | Source file containing the test |
| Test name | Individual test function/method name |
| Disposition | DELETE (replaced by live), RETAIN (unique mock value), SUPPLEMENT (add live equivalent) |
| Live equivalent | Path to live engine test that replaces or supplements this test |
| Rationale | Why this disposition was chosen |

## Test File Inventory

### F# Unit Tests → DELETE (6 tests)

| Test | Disposition | Live Equivalent |
|------|-------------|-----------------|
| GiveMeNewUnitCommand sets unit_def_id and position | DELETE | T6.7 (GiveMeNewUnitCommand) |
| GiveMeResourceCommand sets resource_id and amount | DELETE | T6.6 (GiveMeResourceCommand) |
| CallLuaRulesCommand sets data field | DELETE | T6.8 (CallLuaRulesCommand) |
| CallLuaRulesCommand handles empty string | DELETE | T6.8 (extended) |
| CallLuaUICommand sets data field | DELETE | T6.9 (CallLuaUICommand) |
| Cheat builders return AICommand compatible | DELETE | New T6.10 (all-commands smoke) |

### C Proxy Tests → MIXED (66 tests)

| File | Tests | DELETE | RETAIN | SUPPLEMENT |
|------|-------|--------|--------|------------|
| test_serialize.c | 29 | 29 | 0 | 0 |
| test_deserialize.c | 17 | 0 | 2 | 15 |
| test_roundtrip.c | 3 | 3 | 0 | 0 |
| test_callbacks.c | 17 | 0 | 17 | 0 |
| **Total** | **66** | **32** | **19** | **15** |

### New Live Tests → CREATE

| Test | Tier | Purpose |
|------|------|---------|
| T6.10 AllCommandsSmokeTest | Persistent | Replace unit test 6 — send all command types in one frame |
| T9_MapTests.fs | Persistent | Adopt FSBarV1 map query/grid test patterns |
| Enhanced T4 assertions | Persistent | Strengthen combat fidelity with outcome-level checks |
| Enhanced HeadlessCombatVerification | AI | Add combat event assertions (non-zero damage, destruction) |
