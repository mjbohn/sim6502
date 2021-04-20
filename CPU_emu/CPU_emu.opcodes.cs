using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_emulator
{
    public partial class CPU
    {
        private const byte 
            OC_BRK    = 0x00,
            // LDA
            OC_LDA_IM = 0xA9, 
            OC_LDA_ZP = 0xA5,
            OC_LDA_ZPX = 0xB5,
            // LDX
            OC_LDX_IM = 0xA2,
            OC_LDX_ZP = 0xA6,
            OC_LDX_ZPY = 0xB6,
            // LDY
            OC_LDY_IM = 0xA0,
            OC_LDY_ZP = 0xA4,
            OC_LDY_ZPX = 0xB4,

            // JMP
            CO_JMP_ABS = 0x4C,
            CO_JMP_IND = 0x6C,

            // Stack
            OC_PHA    = 0x48,
            OC_PLA    = 0x68
            ;

      
    }
}
