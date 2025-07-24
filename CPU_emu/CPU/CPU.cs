using CPU_emu;
using CPU_emulator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CPU_emulator;

public partial class CPU
{

    public uint PC { get; set; } = 0xFFFC;   // ProgramCounter
    public bool SlowDown { get; set; } = false;
    public int SlowDownTime { get; set; } = 750; //

    public ushort SP;    // StackPointer
    public byte A, X, Y; // registers
    private ushort ResetVector = 0xFFFC;

    //status Flags Carry, Zero, intDisable, Decimalmode, Break, Overflow, Negative flag 
    public IDictionary<string, bool> flags = new Dictionary<string, bool>();
    public bool CpuIsRunning = true;
    private ulong _InterruptPeriod;
    private bool _ExitRequested;
    private bool _SteppingMode;
    internal ulong _CpuCycle;
    //private const uint MAX_MEM = 1024 * 64;
    //private byte[] Data = new byte[MAX_MEM];

    MappedBus _memoryBus;

    private byte
        NegativeFlagBit = 0b10000000,
        OverflowFlagBit = 0b01000000,
        BreakFlagBit = 0b000010000,
        UnusedFlagBit = 0b000100000,
        InterruptDisableFlagBit = 0b000000100,
        ZeroBit = 0b00000001;

    public bool SteppingMode { get => _SteppingMode; set => _SteppingMode = value; }
    public bool ExitRequested { get => _ExitRequested; set => _ExitRequested = value; }
    public ulong InterruptPeriod { get => _InterruptPeriod; set => _InterruptPeriod = value; }

    public ulong CpuCycle { get => _CpuCycle; }
    public byte[] Memory
    {
        get
        {
            return _memoryBus.Dump(0, _memoryBus.RamSize);
        }

        set
        {
            //Data = value;
            _memoryBus.Load(0, value);
            OnMemoryUpdate?.Invoke(this, new CPUEventArgs(this));
        }
    }

    //public uint PC { get => pC; set => pC = value; }
    //public uint InitialPC { get => _initialPC; set => _initialPC = value; }

    public event EventHandler<CPUEventArgs>? OnFlagsUpdate;
    public event EventHandler<CPUEventArgs>? OnMemoryUpdate;
    public event EventHandler<CPUEventArgs>? OnRegisterUpdate;
    public event EventHandler<CPUEventArgs>? OnCpuCycleIncrement;
    public event EventHandler<CPUEventArgs>? OnProgramCounterUpdate;
    public event EventHandler<CPUEventArgs>? OnStackPointerUpdate;
    public event EventHandler<CPUEventArgs>? OnPCoverflow;
    public event EventHandler<CPUEventArgs>? OnBreak;

    public CPU(MappedBus memoryBus)
    {
        //_memoryBus = new MemoryBus(ref Data);
        _memoryBus = memoryBus;
        SetVectors();
    }

    private void SetVectors()
    {
        // Reset-Vector
        WriteByteToMemory(0x00, 0xFFFC);
        WriteByteToMemory(0x02, 0xFFFD);

    }

    public void Reset()
    {
        ushort tmpPC = ReadWordFromMemory(ResetVector);

        SetPC(tmpPC);
        SetSP(0x01FF);

        SetRegister("A", 0);
        SetRegister("X", 0);
        SetRegister("Y", 0);

        ExitRequested = false;

        // set all status flags to false
        flags["C"] = flags["Z"] = flags["I"] = flags["D"] = flags["B"] = flags["V"] = flags["N"] = false;

        //LoadInlineTestProg();

        OnFlagsUpdate?.Invoke(this, new CPUEventArgs(this));
        OnProgramCounterUpdate?.Invoke(this, new CPUEventArgs(this));
        ResetCpuCycle();

    }



    public void Start()
    {
        ExitRequested = false;

        var CpuRunner = new BackgroundWorker();
        CpuRunner.DoWork += CpuRunner_DoWork;
        CpuRunner.RunWorkerAsync();
    }


    private void CpuRunner_DoWork(object sender, DoWorkEventArgs e)
    {

        Type thisType = this.GetType();


        while (CpuIsRunning)
        {
            byte instruction = FetchByte();

            CallInstruction(thisType, instruction);

            if (_SteppingMode)
            {
                break;
            }
            if (ExitRequested)
            {
                break;
            }
            if (PC >= _memoryBus.RamSize)
            {
                OnPCoverflow?.Invoke(this, new CPUEventArgs(this));
                break;
            }


            if (SlowDown && !_SteppingMode)
            {
                System.Threading.Thread.Sleep(SlowDownTime);
            }


        }
    }

    private void CallInstruction(Type thisType, byte instruction)
    {
        // Build method name from 'Cmd' + opcode
        string cmd = "Cmd_" + instruction.ToString("X2").ToUpper();

        MethodInfo theMethod2Call = thisType.GetMethod(cmd);
        // Check if method Cmd_<opcode> exists
        if (theMethod2Call != null)
        {
            // check for method attribute
            OpcodeAttribute? attribute = theMethod2Call.GetCustomAttribute<OpcodeAttribute>();

            theMethod2Call.Invoke(this, new object[] { });

            if (attribute != null)
            {
                IncrementCpuCycle((ulong)attribute.Cycles);
            }
        }
        else
        {
            MessageBox.Show(string.Format("Method {0} not found!", cmd), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private byte PullByteFromStack(ref ulong CpuCycle)
    {
        IncrementSP();
        IncrementCpuCycle(1);
        byte b = ReadByteFromMemory(SP);
        IncrementCpuCycle(1);
        return b;
    }

    private void PushByteToStack(byte b, ref ulong CpuCycle)
    {
        WriteByteToMemory(b, SP);
        IncrementCpuCycle(1);
        DecrementSP();
        IncrementCpuCycle(1);

    }

    public void Stop()
    {
        ExitRequested = true;
    }

    //UT
    private void SetZeroAndNegativeFlags(byte register)
    {
        flags["Z"] = (register == 0);
        flags["N"] = (register & NegativeFlagBit) > 0;
        OnFlagsUpdate?.Invoke(this, new CPUEventArgs(this));
    }

    private byte FetchByte()
    {
        byte data = _memoryBus.Read((ushort)PC);
        IncrementPC();
        IncrementCpuCycle(1);
        return data;
    }

    private ushort FetchWord()
    {
        ushort LoByte = ReadByteFromMemory((ushort)PC);
        IncrementPC();
        ushort HiByte = (ushort)(ReadByteFromMemory((ushort)PC) << 8);
        IncrementPC();

        IncrementCpuCycle(2);

        return LoByte |= HiByte;
    }

    public void WriteByteToMemory(byte b, ushort address)
    {
        _memoryBus.Write(address, b);
        OnMemoryUpdate?.Invoke(this, new CPUEventArgs(this));
    }

    private byte ReadByteFromMemory(ushort address)
    {
        return _memoryBus.Read(address);
    }

    private ushort ReadWordFromMemory(ushort address)
    {
        ushort LoByte = ReadByteFromMemory(address);
        address++;
        ushort HiByte = (ushort)(ReadByteFromMemory(address) << 8);

        return LoByte |= HiByte;
    }

    // Stackpointer SP
    //UT
    private void SetSP(ushort value)
    {
        SP = value;
        OnStackPointerUpdate?.Invoke(this, new CPUEventArgs(this));
    }
    private void IncrementSP()
    {
        SP++;
        OnStackPointerUpdate?.Invoke(this, new CPUEventArgs(this));
    }
    private void DecrementSP()
    {
        SP--;
        OnStackPointerUpdate?.Invoke(this, new CPUEventArgs(this));
    }

    private void IncrementCpuCycle(ulong count)
    {
        _CpuCycle += count;
        OnCpuCycleIncrement?.Invoke(this, new CPUEventArgs(this));
    }

    private void ResetCpuCycle()
    {
        _CpuCycle = 0;
        OnCpuCycleIncrement?.Invoke(this, new CPUEventArgs(this));
    }

    // Programcounter PC
    //UT
    public void SetPC(uint value)
    {
        PC = value;
        OnProgramCounterUpdate?.Invoke(this, new CPUEventArgs(this));
    }
    public void IncrementPC()
    {
        PC++;
        OnProgramCounterUpdate?.Invoke(this, new CPUEventArgs(this));
    }
    public void DecrementPC()
    {
        PC--;
        OnProgramCounterUpdate?.Invoke(this, new CPUEventArgs(this));
    }


    public void SetRegister(string regname, byte value)
    {
        switch (regname)
        {
            case "A":
                A = value;
                break;
            case "X":
                X = value;
                break;
            case "Y":
                Y = value;
                break;
            default:
                break;
        }
        OnRegisterUpdate?.Invoke(this, new CPUEventArgs(this));
    }

    public void ResetMemory()
    {
        _memoryBus.EraseRam();

        SetVectors();

        OnMemoryUpdate?.Invoke(this, new CPUEventArgs(this));
    }
    public byte[] ReadMemory()
    {
        return _memoryBus.DumpRam();
    }

    internal void UpdateMemoryRange(byte[] data, int startAddress)
    {
        for (int i = 0; i < data.Length; i++)
        {
            _memoryBus.Write((ushort)(startAddress + i), data[i]);
        }

        OnMemoryUpdate?.Invoke(this, new CPUEventArgs(this));
    }
}

public class CPUEventArgs : EventArgs
{
    CPU cpu;

    public string Message { get; set; }
    public byte[] Memory { get; set; }
    public uint PC { get; set; }
    public ushort SP { get; set; }
    public byte A { get; set; }
    public byte X { get; set; }
    public byte Y { get; set; }
    public ulong Cycles { get; set; }
    public IDictionary<string, bool> Flags { get; set; }

    public CPUEventArgs(CPU cpu)
    {
        this.cpu = cpu;
        SetProperties();
    }


    private void SetProperties()
    {
        Memory = cpu.ReadMemory();
        PC = cpu.PC;
        SP = cpu.SP;
        A = cpu.A;
        X = cpu.X;
        Y = cpu.Y;
        Flags = cpu.flags;
        Cycles = cpu._CpuCycle;
    }


}
