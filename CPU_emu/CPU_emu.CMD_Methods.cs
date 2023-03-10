using System;
using System.Windows.Forms;

namespace CPU_emulator
{
    public partial class CPU
    {
        // BREAK
        public void Cmd_00()
        {
            ExitRequested = true;
            OnBreak?.Invoke(this, new CPUEventArgs(this));
        }

        // Load Accumulator immidiate A9
        public void Cmd_A9()
        {
            SetRegister("A", FetchByte(ref cycles));
            SetZeroAndNegativeFlags(A);
        }

        // Load Accumulator zeropage A5
        public void Cmd_A5()
        {
            SetRegister("A", ReadByteFromMemory(FetchByte(ref cycles)));
            SetZeroAndNegativeFlags(A);
        }

        //    case OC_LDA_ZP: // Load Accumulator zeropage A5

        //        break;


    }
}