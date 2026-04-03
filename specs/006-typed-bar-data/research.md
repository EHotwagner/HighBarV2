# Research: Typed BAR Data Records

**Feature**: 006-typed-bar-data | **Date**: 2026-04-03

## R1: Unit Field Inventory and Type Mapping

**Decision**: Universal fields mapped to typed `UnitDef` base record; capability-specific fields split into sub-records.

**Rationale**: Investigation of 8 representative Lua unit files across all categories (builder bot, combat bot, factory, turret, solar, aircraft, ship, commander) revealed clear field groupings based on presence/absence patterns. Universal fields (~16) appear in ALL units. Movement fields (~11) only in mobile units. Builder fields (~5) only in constructors. Weapon fields only in armed units. This natural separation maps directly to composable capability sub-records.

**Alternatives considered**:
- Single flat record with ~100+ option fields: too unwieldy, poor IntelliSense experience
- Mutually-exclusive DU by mobility type: breaks for commanders (builder + armed + mobile)
- Focused base + untyped extras map: loses type safety on important fields

## R2: Weapon Damage Model

**Decision**: `Map<string, float>` for weapon damage tables.

**Rationale**: Armor class names (default, vtol, subs, hvyboats, commanders, etc.) are game-defined strings that vary across weapons and could change between BAR versions. A typed record would be brittle. Map is flexible and easy to query.

**Alternatives considered**:
- Typed record with known armor classes: compile-time safety but breaks on new armor types
- `(string * float) list`: preserves order but harder to query by name

## R3: Sound Model

**Decision**: Typed `SoundDef` record with known fields.

**Rationale**: Sound field names are a small, stable set (~10 names). Single sounds as `string option`, indexed sound lists as `string list`. Provides IntelliSense discoverability.

**Alternatives considered**:
- `Map<string, string list>`: flexible but less discoverable
- Split maps (named + indexed): unnecessary complexity for small stable set

## R4: Runtime Expression Handling

**Decision**: `ValueOrExpr<'T>` DU with `Concrete of 'T | Expr of string`.

**Rationale**: Investigation found ~35 unit files with runtime expressions across 3 categories:
1. **Truly runtime (~20 units)**: `Spring.GetModOptions()`, `Spring.GetTeamList()` — depend on game lobby settings
2. **Semi-static (~15 files)**: Loop-generated variants (scav bosses, effigies, lootboxes), `VFS.Include` references
3. **Trivially evaluable (~2)**: Simple arithmetic like `1/70`

Only category 3 can be pre-computed. Categories 1-2 require preserving the expression text. `ValueOrExpr` gives compile-time visibility into which fields resolved vs. which are dynamic.

**Alternatives considered**:
- `None` for expressions: loses data, field appears missing
- Separate expressions map: data split across two locations
- String coercion: lossy for numeric fields

## R5: LuaValue.fs Disposition

**Decision**: Remove entirely from the published library.

**Rationale**: The typed records ARE the public API. Keeping `LuaValue` alongside creates two competing representations that consumers must choose between, defeating the purpose of the feature. The generator's internal AST (`LVal`) handles parsing; it doesn't need a public equivalent.

**Alternatives considered**:
- Keep alongside: confusing dual API
- Deprecate with `[<Obsolete>]`: delays the clean break with no benefit (no existing consumers to migrate)

## R6: Builder/Weapon Overlap

**Decision**: Composable model confirmed — no mutual exclusion between capabilities.

**Rationale**: Investigation disproved the initial claim that builders never have weapons. Commanders (`armcom.lua`, `legcom.lua`) have both `builder=true` with `buildoptions` AND `weapondefs` with multiple weapons. Mobile laser vehicles (`armmlv.lua`, `cormlv.lua`) are also armed builders. The composable capability model handles all combinations naturally.

## R7: Capability Detection Logic

**Decision**: Field presence in Lua source is authoritative for capability assignment.

**Rationale**: Detection rules for the generator:
- `movement`: present when `canmove=true` OR `canfly=true` OR `speed > 0` (and not a building with `maxacc=0`)
- `builder`: present when `builder=true` AND `buildoptions` table exists
- `weapons`: present when `weapondefs` table exists AND `weapons` array exists
- `economy`: present when `energymake > 0` OR `metalmake > 0` OR `extractsmetal=true`
- `building`: present when `yardmap` field exists OR (no `canmove` AND `maxacc=0`)

The `customparams.unitgroup` field can validate but not determine assignments.
