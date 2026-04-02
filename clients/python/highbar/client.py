"""HighBar V2 client connection manager and frame loop."""

import asyncio
import socket
import struct
from typing import Callable, Optional

PROTOCOL_VERSION = 1
DEFAULT_SOCKET_PATH = "/tmp/highbar.sock"


class HighBarClient:
    """Synchronous client for connecting to the HighBar proxy."""

    def __init__(self, socket_path: str = DEFAULT_SOCKET_PATH):
        self.socket_path = socket_path
        self._sock: Optional[socket.socket] = None
        self._frame_handler: Optional[Callable] = None

    def connect(self):
        """Connect to the proxy Unix domain socket."""
        self._sock = socket.socket(socket.AF_UNIX, socket.SOCK_STREAM)
        self._sock.connect(self.socket_path)

    def _send(self, data: bytes):
        """Send length-prefixed message."""
        header = struct.pack("<I", len(data))
        self._sock.sendall(header + data)

    def _recv(self) -> bytes:
        """Receive length-prefixed message."""
        header = self._recv_exact(4)
        (length,) = struct.unpack("<I", header)
        return self._recv_exact(length)

    def _recv_exact(self, n: int) -> bytes:
        """Read exactly n bytes from socket."""
        buf = bytearray()
        while len(buf) < n:
            chunk = self._sock.recv(n - len(buf))
            if not chunk:
                raise ConnectionError("Connection closed")
            buf.extend(chunk)
        return bytes(buf)

    def handshake(self) -> dict:
        """Perform protocol handshake. Returns handshake info."""
        # Import generated protobuf code
        from proto.gen.python.highbar import messages_pb2 as msgs

        data = self._recv()
        proxy_msg = msgs.ProxyMessage()
        proxy_msg.ParseFromString(data)

        if not proxy_msg.HasField("handshake"):
            raise RuntimeError("Expected Handshake message")

        hs = proxy_msg.handshake
        accepted = hs.protocol_version == PROTOCOL_VERSION

        resp = msgs.AIMessage()
        resp.handshake_response.accepted = accepted
        resp.handshake_response.protocol_version = PROTOCOL_VERSION
        self._send(resp.SerializeToString())

        if not accepted:
            raise RuntimeError(
                f"Protocol version mismatch: expected {PROTOCOL_VERSION}, "
                f"got {hs.protocol_version}"
            )

        return {
            "engine_version": hs.engine_version,
            "game_id": hs.game_id,
            "map_name": hs.map_name,
            "team_id": hs.team_id,
            "ally_team_id": hs.ally_team_id,
        }

    def on_frame(self, handler: Callable):
        """Decorator to register a frame handler."""
        self._frame_handler = handler
        return handler

    def run(self):
        """Run the synchronous frame loop."""
        from proto.gen.python.highbar import messages_pb2 as msgs
        from highbar.events import parse_event

        while True:
            data = self._recv()
            proxy_msg = msgs.ProxyMessage()
            proxy_msg.ParseFromString(data)

            if proxy_msg.HasField("frame"):
                frame = proxy_msg.frame
                events = [parse_event(e) for e in frame.events]

                commands = []
                if self._frame_handler:
                    result = self._frame_handler(
                        type("Frame", (), {
                            "frame_number": frame.frame_number,
                            "events": events,
                        })()
                    )
                    if result:
                        commands = result

                resp = msgs.AIMessage()
                # Commands would be converted to protobuf AICommand here
                self._send(resp.SerializeToString())

            elif proxy_msg.HasField("shutdown"):
                break

            elif proxy_msg.HasField("save_request"):
                resp = msgs.AIMessage()
                resp.save_response.state_data = b""
                self._send(resp.SerializeToString())

    def disconnect(self):
        """Close the connection."""
        if self._sock:
            self._sock.close()
            self._sock = None

    def __enter__(self):
        self.connect()
        self.handshake()
        return self

    def __exit__(self, *args):
        self.disconnect()


class AsyncHighBarClient:
    """Async client for connecting to the HighBar proxy."""

    def __init__(self, socket_path: str = DEFAULT_SOCKET_PATH):
        self.socket_path = socket_path
        self._reader: Optional[asyncio.StreamReader] = None
        self._writer: Optional[asyncio.StreamWriter] = None

    async def connect(self):
        """Connect to the proxy Unix domain socket."""
        self._reader, self._writer = await asyncio.open_unix_connection(
            self.socket_path
        )

    async def _send(self, data: bytes):
        header = struct.pack("<I", len(data))
        self._writer.write(header + data)
        await self._writer.drain()

    async def _recv(self) -> bytes:
        header = await self._reader.readexactly(4)
        (length,) = struct.unpack("<I", header)
        return await self._reader.readexactly(length)

    async def handshake(self) -> dict:
        from proto.gen.python.highbar import messages_pb2 as msgs

        data = await self._recv()
        proxy_msg = msgs.ProxyMessage()
        proxy_msg.ParseFromString(data)

        if not proxy_msg.HasField("handshake"):
            raise RuntimeError("Expected Handshake message")

        hs = proxy_msg.handshake
        accepted = hs.protocol_version == PROTOCOL_VERSION

        resp = msgs.AIMessage()
        resp.handshake_response.accepted = accepted
        resp.handshake_response.protocol_version = PROTOCOL_VERSION
        await self._send(resp.SerializeToString())

        if not accepted:
            raise RuntimeError(f"Protocol version mismatch")

        return {
            "engine_version": hs.engine_version,
            "map_name": hs.map_name,
            "team_id": hs.team_id,
        }

    async def frames(self):
        """Async generator yielding frames."""
        from proto.gen.python.highbar import messages_pb2 as msgs
        from highbar.events import parse_event

        while True:
            data = await self._recv()
            proxy_msg = msgs.ProxyMessage()
            proxy_msg.ParseFromString(data)

            if proxy_msg.HasField("frame"):
                frame = proxy_msg.frame
                events = [parse_event(e) for e in frame.events]
                yield type("Frame", (), {
                    "frame_number": frame.frame_number,
                    "events": events,
                })()
            elif proxy_msg.HasField("shutdown"):
                break

    async def send_response(self, commands=None):
        from proto.gen.python.highbar import messages_pb2 as msgs
        resp = msgs.AIMessage()
        await self._send(resp.SerializeToString())

    async def disconnect(self):
        if self._writer:
            self._writer.close()
            await self._writer.wait_closed()
