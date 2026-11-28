public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        //long
        if(reading < int.MinValue)
        {
            buffer[0] = 256 - 8;
            BitConverter.GetBytes(reading).CopyTo(buffer, 1);
        }
        //int
        else if(reading < short.MinValue)
        {
            buffer[0] = 256 - 4;
            BitConverter.GetBytes((int)reading).CopyTo(buffer, 1);
        }
        //short
        else if(reading < ushort.MinValue)
        {
            buffer[0] = 256-2;
            BitConverter.GetBytes((short)reading).CopyTo(buffer, 1);
        }
        //ushort
        else if(reading <= ushort.MaxValue)
        {
            buffer[0] = 2;
            BitConverter.GetBytes((ushort)reading).CopyTo(buffer, 1);
        }
        else if(reading <= int.MaxValue)
        {
            buffer[0] = 256 - 4;
            BitConverter.GetBytes((int)reading).CopyTo(buffer, 1);
        }
        else if(reading <= uint.MaxValue)
        {
            buffer[0] = 4;
            BitConverter.GetBytes(((uint)reading)).CopyTo(buffer, 1);
        }
        else
        {
            buffer[0] = 256 - 8;
            BitConverter.GetBytes(reading).CopyTo(buffer, 1);
        }
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        byte perfix = buffer[0];
        if (perfix == (256 - 8))
            return BitConverter.ToInt64(buffer, 1);
        if (perfix == (4))
            return ((long)BitConverter.ToUInt64(buffer, 1));
        if (perfix == 256 - 4)
            return BitConverter.ToInt32(buffer, 1);
        if (perfix == 2)
            return BitConverter.ToUInt16(buffer, 1);
        if (perfix == 256 - 4)
            return BitConverter.ToUInt32(buffer, 1);
        if (perfix == 256 - 2)
            return BitConverter.ToInt16(buffer, 1);
        return 0;
    }
}
