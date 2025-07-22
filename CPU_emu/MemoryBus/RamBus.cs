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
    
    /// <summary>
    /// Read data from random address
    /// </summary>
    /// <param name="address">address to read</param>
    /// <returns>byte</returns>
    public byte Read(ushort address)
    {
        return _memory[address];
    }

    /// <summary>
    /// Write data to random address
    /// </summary>
    /// <param name="address">Address to store data</param>
    /// <param name="value">data</param>
    public void Write(ushort address, byte value)
    {
        _memory[address] = value;
    }

    /// <summary>
    /// Load a chunk of data into RAM
    /// </summary>
    /// <param name="address">Startaddress</param>
    /// <param name="data">data byte[]</param>
    public void Load(ushort address, params byte[] data)
    {
        Array.Copy(data, 0, _memory, address, data.Length);
    }

    /// <summary>
    /// Reada range of RAM
    /// </summary>
    /// <param name="address">Startaddress</param>
    /// <param name="length">Lenght of data</param>
    /// <returns>byte[]</returns>
    public byte[] Dump(ushort address, int length)
    {
        return _memory.Skip(address).Take(length).ToArray();
    }


}
