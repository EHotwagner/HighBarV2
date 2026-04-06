# Quickstart: Extract and Save Map Data

## Prerequisites

1. BAR engine installed: `~/.local/state/Beyond All Reason/engine/recoil_2025.06.19/spring-headless`
2. Maps downloaded: `~/.local/state/Beyond All Reason/maps/` (10+ maps present)
3. Proxy built: `cmake -B build -DCMAKE_BUILD_TYPE=Release proxy/ && cmake --build build`
4. F# client builds: `cd clients/fsharp && dotnet build`

## Run the Tests

```bash
# Run all persistent tests (includes T11 map data export)
./tests/run-all.sh --category persistent

# Keep session logs for debugging
HIGHBAR_KEEP_LOGS=1 ./tests/run-all.sh --category persistent
```

## Check Output

```bash
# View extraction summary
cat reports/map-data/Red_Rock_Desert_v2/summary.json | jq .

# List saved files
ls -la reports/map-data/Red_Rock_Desert_v2/

# Quick validation: check file sizes are non-zero
find reports/map-data/ -type f -exec ls -la {} \;
```

## Key Files

| File | Purpose |
|------|---------|
| `tests/persistent/fsharp/T11_MapDataExport.fs` | Test class with extraction, validation, save |
| `reports/map-data/{map-name}/summary.json` | Extraction report |
| `reports/map-data/{map-name}/*.bin` | Raw array data files |
| `reports/map-data/{map-name}/*.csv` | Human-readable structured data |

## Development Notes

- All callback queries must run inside `engine.RunFrames()` — the proxy only processes callbacks during frame response.
- The F# client returns empty arrays `[||]` on failure, not null. Check `Array.length > 0`.
- Primary data types (dimensions, heightmap, corners heightmap) assert hard failure; secondary types (LOS, radar) warn only.
- Default test map is "Red Rock Desert v2" from `tests/engine-version.json`.
