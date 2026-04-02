# Report: Connection and Handshake Tests

**Date**: 2026-04-02
**Iteration**: 2

## Context

Implementing the first user story (US1): proving the full communication chain from engine through the proxy socket to the F# client. Tests cover connect, handshake, frame reception, frame response, and graceful disconnect.

## Problem

The `Run()` method on `HighBarClient` is a blocking loop that processes frames until a Shutdown message. Integration tests need to capture a finite number of frames and then exit the loop.

## Investigation

- The `Run` callback (`onFrame: GameFrame -> AICommand list`) doesn't have a "stop" return value
- Options: (a) add a cancellation mechanism to the client, (b) throw an exception from the callback to break the loop, (c) use a separate thread with timeout

## Root Cause

The client API is designed for long-running AI processes, not test scenarios that need to inspect individual frames and stop.

## Solution

Used a controlled exception approach: the `onFrame` callback throws `failwith "CAPTURED_ENOUGH"` once sufficient frames are collected. The test catches this specific exception. This is pragmatic and doesn't require client API changes.

Helper function `runForFrames` encapsulates this pattern for reuse across tests.

## Hypotheses

- The handshake `ProtocolVersion` field should always be 1 (current protocol)
- The `MapName` in the handshake should match the startscript's `mapname` field
- The first frame should always contain an `Init` event before any `Update` events
- Frame numbers should be monotonically increasing

## Lessons Learned

- Using exception control flow for test termination is acceptable when the API doesn't provide a clean stop mechanism
- The F# `use` keyword ensures `Disconnect()` is called even if test assertions fail (via `IDisposable`)
- Frame numbers increment reliably -- the protocol maintains ordering guarantees
