# Data Model: Remove Python and Upgrade to .NET 10

**Feature**: 019-remove-python-dotnet10 | **Date**: 2026-04-04

## Overview

This feature introduces no new data entities. It is a removal and migration task.

## Entities Affected

### .fsproj Project Files (11 files)

**Change**: `TargetFramework` property updated from `net8.0` to `net10.0`

No schema changes, no new fields, no data migration required. The .NET runtime version is a build configuration property, not a data model concern.

### Proto Code Generation (buf.gen.yaml)

**Change**: Remove `protoc-gen-python_betterproto` plugin entry and its `out: gen/python` output directory

The proto schema (`.proto` files) is unchanged. Only one code generation target is removed. Remaining targets:
- F#: Google.Protobuf (C# codegen consumed by F#)
- C: protobuf-c

### State Transitions

N/A — no stateful entities introduced or modified.
