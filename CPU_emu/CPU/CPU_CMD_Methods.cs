using System;
using System.Windows.Forms;

namespace CPU_emulator;

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
    
    [Opcode(2)]
    public void Cmd_A9() // Load Accumulator immidiate A9
    {
        byte value = AddrImmediate();
        SetRegister("A", value);
        SetZeroAndNegativeFlags(A);
    }

    // LDA $zz
    [Opcode(2)]
    public void Cmd_A5() // Load Accumulator zeropage A5
    {
        ushort addr = AddrZeroPage();
        byte value = ReadByteFromMemory(addr);
        SetRegister("A", value);
        SetZeroAndNegativeFlags(A);
    }

    // LDA $zz,X
    [Opcode(2)]
    public void Cmd_B5() // Load Accumulator zeropage X B5
    {
        ushort addr = AddrZeroPageX();
        byte value = ReadByteFromMemory(addr);
        SetRegister("A", value);
        SetZeroAndNegativeFlags(A);
    }

    // LDA $nnnn (absolute)
    [Opcode(3)]
    public void Cmd_AD()
    {
        ushort addr = AddrAbsolute();
        byte value = ReadByteFromMemory(addr);
        SetRegister("A", value);
        SetZeroAndNegativeFlags(A);
    }

    // LDA $nnnn,X
    [Opcode(3)]
    public void Cmd_BD()
    {
        ushort addr = AddrAbsoluteX();
        byte value = ReadByteFromMemory(addr);
        SetRegister("A", value);
        SetZeroAndNegativeFlags(A);
    }

    // LDA $nnnn,Y
    [Opcode(3)]
    public void Cmd_B9()
    {
        ushort addr = AddrAbsoluteY();
        byte value = ReadByteFromMemory(addr);
        SetRegister("A", value);
        SetZeroAndNegativeFlags(A);
    }

    // LDA ($zz,X) – Indirect,X
    [Opcode(2)]
    public void Cmd_A1()
    {
        ushort addr = AddrIndirectX();
        byte value = ReadByteFromMemory(addr);
        SetRegister("A", value);
        SetZeroAndNegativeFlags(A);
    }

    // LDA ($zz),Y – Indirect,Y
    [Opcode(2)]
    public void Cmd_B1()
    {
        ushort addr = AddrIndirectY();
        byte value = ReadByteFromMemory(addr);
        SetRegister("A", value);
        SetZeroAndNegativeFlags(A);
    }

    #endregion

    #region LDX
    // Load X immidiate A2
    public void Cmd_A2()
    {
        byte b_tmp = FetchByte();
        SetRegister("X", b_tmp);
        SetZeroAndNegativeFlags(X);
    }

    // Load X zeropage A6
    public void Cmd_A6()
    {
        byte b_tmp = FetchByte();
        SetRegister("X", ReadByteFromMemory(b_tmp));
        SetZeroAndNegativeFlags(X);
    }

    // Load X zeropage Y B6
    public void Cmd_B6()
    {
        byte b_tmp = FetchByte(); // Get ZP address
        b_tmp += Y; // add regY to address
        SetRegister("X", ReadByteFromMemory(b_tmp));
        SetZeroAndNegativeFlags(X);
    }

    #endregion

    #region LDY
    // Load Y immidiate A0
    public void Cmd_A0()
    {
        byte b_tmp = FetchByte();
        SetRegister("Y", b_tmp);
        SetZeroAndNegativeFlags(Y);
    }

    // Load Y zeropage A4
    public void Cmd_A4()
    {
        byte b_tmp = FetchByte();
        SetRegister("Y", ReadByteFromMemory(b_tmp));
        SetZeroAndNegativeFlags(Y);
    }

    // Load Y zeropage X B4
    public void Cmd_B4()
    {
        byte b_tmp = FetchByte(); // Get ZP address
        b_tmp += X; // add regX to address
        SetRegister("Y", ReadByteFromMemory(b_tmp));
        SetZeroAndNegativeFlags(Y);
    }

    #endregion

    #region stack push pull

    // Push Accumulator on Stack PHA
    public void Cmd_48()
    {
        PushByteToStack(A,ref _CpuCycle);
    }

    #endregion


    
}