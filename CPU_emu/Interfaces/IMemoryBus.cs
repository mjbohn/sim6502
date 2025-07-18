using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emu;

internal interface IMemoryBus
{
    byte Read(ushort address);
    void Write(ushort address, byte value);
    void Load(ushort address, params byte[] data);
    byte[] Dump(ushort address, int length);


}
