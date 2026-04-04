#!/usr/bin/env python3
"""Minimal socket listener that accepts the proxy connection, does a basic
handshake, then reads frames and sends empty responses forever.
Used to keep the proxy alive so handleEvent gets called."""

import socket, struct, sys, os

SOCK_PATH = sys.argv[1] if len(sys.argv) > 1 else "/tmp/highbar-live-test.sock"

# Clean up stale socket
if os.path.exists(SOCK_PATH):
    os.unlink(SOCK_PATH)

srv = socket.socket(socket.AF_UNIX, socket.SOCK_STREAM)
srv.bind(SOCK_PATH)
srv.listen(1)
print(f"Listening on {SOCK_PATH} ...")

conn, _ = srv.accept()
print("Proxy connected!")

def recv_msg(s):
    hdr = b""
    while len(hdr) < 4:
        hdr += s.recv(4 - len(hdr))
    length = struct.unpack("<I", hdr)[0]
    data = b""
    while len(data) < length:
        data += s.recv(length - len(data))
    return data

def send_msg(s, data):
    s.sendall(struct.pack("<I", len(data)) + data)

# Import protobuf messages
sys.path.insert(0, os.path.join(os.path.dirname(__file__), "../../proto/gen/python"))
try:
    from highbar import (
        ProxyMessage, AIMessage, HandshakeResponse, FrameResponse
    )

    # Handshake
    raw = recv_msg(conn)
    pm = ProxyMessage().parse(raw)
    print(f"Got handshake: protocol_version={pm.handshake.protocol_version}")

    resp = AIMessage(handshake_response=HandshakeResponse(accepted=True, protocol_version=1))
    send_msg(conn, bytes(resp))
    print("Handshake done, entering frame loop...")

    frame_count = 0
    while True:
        raw = recv_msg(conn)
        pm = ProxyMessage().parse(raw)

        if pm.frame:
            frame_count += 1
            evts = [str(e) for e in pm.frame.events if not str(e).startswith("update")]
            if evts:
                print(f"Frame {pm.frame.frame_number}: {len(pm.frame.events)} events")
                for e in evts[:5]:
                    print(f"  {e[:120]}")

            # Send empty frame response
            resp = AIMessage(frame_response=FrameResponse())
            send_msg(conn, bytes(resp))

            if frame_count % 100 == 0:
                print(f"  ... {frame_count} frames processed")

        elif pm.shutdown:
            print("Shutdown received")
            break
        elif pm.save_request:
            from highbar import SaveResponse
            resp = AIMessage(save_response=SaveResponse(state_data=b""))
            send_msg(conn, bytes(resp))
        else:
            print(f"Unknown message type")

except Exception as e:
    print(f"Error: {e}")
    import traceback
    traceback.print_exc()
finally:
    conn.close()
    srv.close()
    if os.path.exists(SOCK_PATH):
        os.unlink(SOCK_PATH)
    print(f"Done. Processed {frame_count if 'frame_count' in dir() else '?'} frames")
