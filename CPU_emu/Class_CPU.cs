using CPU_emulator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class CPU
{
	public ushort PC;    // ProgramCounter
	public ushort SP;    // StackPointer
	public byte A, X, Y; // registers
	
	//status Flags Carry, Zero, intDisable, Decimalmode, Break, Overflow, Negative flag 
	public IDictionary<string, bool> flags = new Dictionary<string, bool>();

	private const uint MAX_MEM = 1024 * 64;
	private byte[] Data = new byte[MAX_MEM];

	public event EventHandler OnFlagsUpdate;
	public event EventHandler OnMemoryUpdate;	
	public CPU() { }
	
	public void Reset()
    {
		var rand = new Random();
		rand.NextBytes(Data);
		OnMemoryUpdate?.Invoke(this, EventArgs.Empty);

		PC = 0xFFFC;
		SP = 0x0100;
         
        A = X = Y = 0;

		// set all status flags to false
		flags["C"] = flags["Z"] = flags["I"] = flags["D"] = flags["B"] = flags["V"] = flags["N"] = false;
		
		OnFlagsUpdate?.Invoke(this, EventArgs.Empty);
	}

	public void ResetMemory()
	{
		for (int i = 0; i < MAX_MEM; i++)
        {
            Data[i] = 0x00;
        }

        //Data[0] = 0xff;
        //Data[1] = 0x0a;
        //Data[2] = 0x0b;
        //Data[3] = 0x0c;
        //Data[15] = 0xff;

        OnMemoryUpdate?.Invoke(this, EventArgs.Empty);
	}

	public byte[] ReadMemory()
    {
		return Data;
    }

	
}
