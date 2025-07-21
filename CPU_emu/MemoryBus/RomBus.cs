using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emu;

public class RomBus : IMemoryBus
{

    private readonly byte[] _rom;
    private readonly ushort _base;

    public RomBus(byte[] rom, ushort baseAddress = 0)
    {
        _rom = rom;
        _base = baseAddress;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="address">Start dump at this address</param>
    /// <param name="length">Dump 'length' bytes</param>
    /// <returns>byte[]</returns>
    public byte[] Dump(ushort address, int length)
    {
        return _rom.Skip(address).Take(length).ToArray();
    }

    public void Load(ushort address, params byte[] data)
    {
        // No load. It's a ROM
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="address">Address t read</param>
    /// <returns>byte</returns>
    public byte Read(ushort address)
    {
        return _rom[address - _base];
    }

    public void Write(ushort address, byte value)
    {
        // No write. It's am ROM ;-)
    }
}
