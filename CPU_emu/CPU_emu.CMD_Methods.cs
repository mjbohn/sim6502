using System;
using System.Windows.Forms;

namespace CPU_emulator
{
    public partial class CPU
    {
        #region BRK
        // BREAK
        public void Cmd_00()
        {
            ExitRequested = true;
            OnBreak?.Invoke(this, new CPUEventArgs(this));
        }
        #endregion

        #region LDA
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

        // Load Accumulator zeropage X B5
        public void Cmd_B5()
        {
            byte b_tmp = FetchByte(ref cycles);
            b_tmp += X; // add regX to address
            SetRegister("A", ReadByteFromMemory(b_tmp));
            SetZeroAndNegativeFlags(A);
        }
        #endregion

        #region LDX
        // Load X immidiate A2
        public void Cmd_A2()
        {
            byte b_tmp = FetchByte(ref cycles);
            SetRegister("X", b_tmp);
            SetZeroAndNegativeFlags(X);
        }

        // Load X zeropage A6
        public void Cmd_A6()
        {
            byte b_tmp = FetchByte(ref cycles);
            SetRegister("X", ReadByteFromMemory(b_tmp));
            SetZeroAndNegativeFlags(X);
        }

        // Load X zeropage Y B6
        public void Cmd_B6()
        {
            byte b_tmp = FetchByte(ref cycles); // Get ZP address
            b_tmp += Y; // add regY to address
            SetRegister("X", ReadByteFromMemory(b_tmp));
            SetZeroAndNegativeFlags(X);
        }
        
        #endregion
    }
}