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

            // Stack
            OC_PHA    = 0x48,
            OC_PLA    = 0x68
            ;
    }
}
