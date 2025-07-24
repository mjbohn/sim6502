using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emu;

public class IoDevice : IMemoryBus
{
    public byte[] Dump(ushort address, int length)
    {
        throw new NotImplementedException();
    }

    public void Load(ushort address, params byte[] data)
    {
        throw new NotImplementedException();
    }

    public byte Read(ushort address)
    {
        Console.WriteLine($"[IO READ] from ${address:X4}");
        return 0xFF; // Dummy-Value
    }

    public void Write(ushort address, byte value)
    {
        Console.WriteLine($"[IO WRITE] to ${address:X4} = ${value:X2}");
    }
}
