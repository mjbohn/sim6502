using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emu;

public class RamBus : IMemoryBus
{
    private readonly byte[] _memory;

    public int RamSize
    {
        get { return _memory.Length; }
    }

    public RamBus(byte[] memory)
    {
        _memory = memory;
    }
    public byte Read(ushort address)
    {
        return _memory[address];
    }

    public void Write(ushort address, byte value)
    {
        _memory[address] = value;
    }

    public void Load(ushort address, params byte[] data)
    {
        Array.Copy(data, 0, _memory, address, data.Length);
    }

    public byte[] Dump(ushort address, int length)
    {
        return _memory.Skip(address).Take(length).ToArray();
    }


}
