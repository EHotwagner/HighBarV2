# Data Model: Extract and Save Map Data

## Entities

### MapDimensions

| Field | Type | Constraints |
|-------|------|-------------|
| Width | int | > 0 |
| Height | int | > 0 |

### HeightMapData

| Field | Type | Constraints |
|-------|------|-------------|
| Values | float32[] | Length = Width × Height; range [-5000, 50000] elmos |

### CornersHeightMapData

| Field | Type | Constraints |
|-------|------|-------------|
| Values | float32[] | Length = (Width+1) × (Height+1); range [-5000, 50000] elmos |

### SlopeMapData

| Field | Type | Constraints |
|-------|------|-------------|
| Values | float32[] | Length = (Width/2) × (Height/2); range [0.0, 1.0] |

### LosMapData

| Field | Type | Constraints |
|-------|------|-------------|
| Values | int[] | Length = Width × Height; values >= 0 |

### RadarMapData

| Field | Type | Constraints |
|-------|------|-------------|
| Values | int[] | Length = Width × Height; values >= 0 |

### ResourceMapData

| Field | Type | Constraints |
|-------|------|-------------|
| ResourceId | int | 0 = metal, 1 = energy |
| Values | int[] | Length = (Width/2) × (Height/2); values >= 0 |

### MetalSpot

| Field | Type | Constraints |
|-------|------|-------------|
| X | float32 | 0 <= X <= Width × 8 (map units to elmos) |
| Y | float32 | Any (elevation) |
| Z | float32 | 0 <= Z <= Height × 8 |
| Income | float32 | > 0 |

### StartPosition

| Field | Type | Constraints |
|-------|------|-------------|
| TeamId | int | >= 0 |
| X | float32 | Within map bounds |
| Y | float32 | Any (elevation) |
| Z | float32 | Within map bounds |

### ExtractionResult

| Field | Type | Constraints |
|-------|------|-------------|
| DataType | string | One of: dimensions, heightmap, corners-heightmap, slope-map, los-map, radar-map, resource-map-metal, metal-spots, start-positions |
| Status | string | "success", "warning", "fail" |
| ElementCount | int | >= 0 |
| MinValue | float option | Populated for numeric arrays |
| MaxValue | float option | Populated for numeric arrays |
| FilePath | string option | Path to saved file, if saved |
| ErrorMessage | string option | Populated on warning/fail |

### ExtractionReport (summary.json)

| Field | Type | Constraints |
|-------|------|-------------|
| MapName | string | From engine config |
| Timestamp | string | ISO 8601 |
| Width | int | Extracted dimension |
| Height | int | Extracted dimension |
| Results | ExtractionResult[] | One per data type |
| OverallStatus | string | "pass" if all primary succeed; "fail" otherwise |

## Relationships

- ExtractionReport contains 1..N ExtractionResult entries
- Each ExtractionResult corresponds to exactly one data type file on disk
- MapDimensions are used to validate array lengths for all other data types
- MetalSpot coordinates are bounded by MapDimensions (converted to elmos)

## State Transitions

Not applicable — this is a single-pass extraction pipeline with no mutable state.
