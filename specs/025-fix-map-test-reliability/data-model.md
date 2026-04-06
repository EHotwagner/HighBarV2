# Data Model: Fix Map Test Reliability

**Feature**: 025-fix-map-test-reliability  
**Date**: 2026-04-06

## Entities

This feature adds no new data entities. It exposes existing proxy-side data through F# client wrappers.

### Map Data Arrays (existing, newly exposed)

| Data Type | Callback ID | Return Type | Array Size | Source |
|-----------|-------------|-------------|------------|--------|
| Height Map | 52 | `float32 array` | W * H | Already exposed via `GetHeightMap()` |
| Slope Map | 53 | `float32 array` | (W/2) * (H/2) | **New wrapper: `GetSlopeMap()`** |
| LOS Map | 54 | `int array` | Varies (mip level) | **New wrapper: `GetLosMap()`** |
| Radar Map | 55 | `int array` | Varies (mip level) | **New wrapper: `GetRadarMap()`** |
| Resource Map | 56 | `int array` | (W/2) * (H/2) | **New wrapper: `GetResourceMap(resourceId)`** |

### Value Ranges

| Data Type | Min | Max | Notes |
|-----------|-----|-----|-------|
| Height | -5000.0f | 50000.0f | Elmo units (existing test range) |
| Slope | 0.0f | 1.0f | Normalized gradient |
| LOS | 0 | unbounded | Visibility values, non-negative |
| Radar | 0 | unbounded | Radar coverage values, non-negative |
| Resource | 0 | unbounded | Density values (metal=0, energy=1) |

### Callback Parameters

| Method | Parameters | Notes |
|--------|-----------|-------|
| `GetSlopeMap()` | None | |
| `GetLosMap()` | None | |
| `GetRadarMap()` | None | |
| `GetResourceMap(resourceId)` | `resourceId: int` (0=metal, 1=energy) | Maps to proxy's `get_int_param(request, 0, 0)` |
