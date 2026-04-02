namespace HighBar.Replay

open System
open System.IO

/// Replay file format:
/// Header: [4 bytes magic "HBRP"][4 bytes version][8 bytes timestamp]
/// Records: [4 bytes frame_number][1 byte direction (0=sent,1=recv)][4 bytes msg_len][msg_len bytes payload]

module ReplayFormat =
    let Magic = "HBRP"B
    let Version = 1u

    type ReplayHeader = {
        Version: uint32
        Timestamp: DateTimeOffset
    }

    type ReplayRecord = {
        FrameNumber: uint32
        Direction: byte  // 0 = proxy→AI, 1 = AI→proxy
        Data: byte[]
    }

    let writeHeader (writer: BinaryWriter) =
        writer.Write(Magic)
        writer.Write(Version)
        writer.Write(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds())

    let readHeader (reader: BinaryReader) : ReplayHeader =
        let magic = reader.ReadBytes(4)
        if magic <> Magic then failwith "Invalid replay file magic"
        let version = reader.ReadUInt32()
        let timestamp = reader.ReadInt64()
        {
            Version = version
            Timestamp = DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
        }

    let writeRecord (writer: BinaryWriter) (record: ReplayRecord) =
        writer.Write(record.FrameNumber)
        writer.Write(record.Direction)
        writer.Write(uint32 record.Data.Length)
        writer.Write(record.Data)

    let readRecord (reader: BinaryReader) : ReplayRecord option =
        try
            let frame = reader.ReadUInt32()
            let direction = reader.ReadByte()
            let len = reader.ReadUInt32()
            let data = reader.ReadBytes(int len)
            Some { FrameNumber = frame; Direction = direction; Data = data }
        with
        | :? EndOfStreamException -> None
