using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emulator
{
    public partial class CPU
    {
        #region addressig helper

        // #Immediate 
        private byte AddrImmediate()
        {
            return FetchByte();
        }

        // $zz – Zero Page 
        private ushort AddrZeroPage()
        {
            // return (ushort)(addr & 0x00FF); cast ushort
            return FetchByte(); // implicit ushort 
        }

        // Zero Page,X – 8-Bit-Baseaddress + X, Wrap at 0xFF → 0x00
        private ushort AddrZeroPageX()
        {
            byte baseAddr = FetchByte();
            byte effectiveAddr = (byte)(baseAddr + X); // automatic 8-Bit-Wrap
            return effectiveAddr;
        }

        // Absolute
        private ushort AddrAbsolute()
        {
            return FetchWord();
        }

        // Absolute,X (no page wrap taken into account)
        private ushort AddrAbsoluteX()
        {
            return (ushort)(AddrAbsolute() + X);
        }

        // Absolute,Y
        private ushort AddrAbsoluteY()
        {
            return (ushort)(AddrAbsolute() + Y);
        }

        // Indirect,X = ($zz,X)
        private ushort AddrIndirectX()
        {
            byte zpAddr = (byte)(FetchByte() + X);
            byte lo = ReadByteFromMemory(zpAddr);
            byte hi = ReadByteFromMemory((byte)(zpAddr + 1));
            return (ushort)(lo | (hi << 8));
        }

        // Indirect,Y = ($zz),Y
        private ushort AddrIndirectY()
        {
            byte zpAddr = FetchByte();
            byte lo = ReadByteFromMemory(zpAddr);
            byte hi = ReadByteFromMemory((byte)(zpAddr + 1));
            return (ushort)((lo | (hi << 8)) + Y);
        }



        #endregion
    }
}
