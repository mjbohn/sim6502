using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emu
{
    internal class MemoryBus : IMemoryBus
    {
        private readonly byte[] _memory;

        public MemoryBus(int memSize = 1024 * 64)
        {
            _memory = new byte[memSize];
        }
        public MemoryBus(ref byte[] memory)
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
}
