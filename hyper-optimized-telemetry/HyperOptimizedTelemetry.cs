using System;
using System.Runtime;
using static System.BitConverter;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        //need to integrate numeric type
        //need to integrate the amount of bytes
        //need to ask if signed
        //need to look at prefix byte

        (int size, byte[] bytes) = reading switch 
        {
            < int.MinValue => (0xf8, GetBytes((long)reading)),
            < short.MinValue => (0xfc, GetBytes((int)reading)),
            < 0 => (0xfe, GetBytes((short)reading)),
            <= ushort.MaxValue => (0x02, GetBytes(reading)),
            <= int.MaxValue => (0xfc, GetBytes(reading)),
            <= uint.MaxValue => (0x04, GetBytes(reading)),
            _ => (0xf8, GetBytes(reading))
        };        
        var buffer = new byte[9];
        buffer[0] = (byte)size;
        bytes.CopyTo(buffer, 1);
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        return buffer[0] switch {
            0x02 => ToUInt16(buffer, 1),
            0x04 => ToUInt32(buffer, 1),
            0xfc => ToInt32(buffer, 1),
            0xf8 => ToInt64(buffer, 1),
            0xfe => ToInt16(buffer, 1),
            _ => 0
        };
    }
}
