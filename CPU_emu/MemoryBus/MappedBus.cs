using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emu;

public class MappedBus : IMemoryBus
{

    private readonly RamBus _ram;
    private readonly RomBus _basicRom;
    private readonly RomBus _kernalRom;
    private readonly IoDevice _io;

    public int RamSize
    {
        get { return _ram.RamSize; }
    }
        
    public MappedBus(RamBus ram, RomBus basicRom, RomBus kernalRom, IoDevice io)
    {
        _ram = ram;
        _basicRom = basicRom;
        _kernalRom = kernalRom;
        _io = io;
    }

    public void EraseRam()
    {
        _ram.Load(0,new byte[_ram.RamSize]);
    }

    public byte[] Dump(ushort address, int length)
    {
        return _ram.Dump(address, length);
    }

    public byte[] DumpRam()
    {
        return _ram.Dump(0, _ram.RamSize);
    }

    public void Load(ushort address, params byte[] data)
    {
        _ram.Load(0, data);
    }

    public byte Read(ushort address)
    {
        //if (address >= 0xA000 && address <= 0xBFFF)
        //    return _basicRom.Read(address);
        //else if (address >= 0xD000 && address <= 0xDFFF)
        //    return _io.Read(address);
        //else if (address >= 0xE000)
        //    return _kernalRom.Read(address);
        //else
            return _ram.Read(address);
    }

    public void Write(ushort address, byte value)
    {
        //if (address >= 0xD000 && address <= 0xDFFF)
        //    _io.Write(address, value);
        //else if (address < 0xA000 || (address >= 0xC000 && address < 0xD000))
            _ram.Write(address, value);
        // Writes to ROM are ignored
    }
}
