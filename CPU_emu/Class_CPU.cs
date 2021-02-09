using CPU_emulator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class CPU
{
	public ushort PC;  // ProgramCounter
	public ushort SP;  // StackPointer
	public byte A, X, Y; // registers
//	public bool C, Z, I, D, B, V, N; 
	
	//status Flags Carry, Zero, intDisable, Decimalmode, Break, Overflow, Negative flag 
	public IDictionary<string, bool> flags = new Dictionary<string, bool>();

	public const uint MAX_MEM = 1024 * 64;
	
	public byte[] Data = new byte[MAX_MEM];

	public event EventHandler onFlagsUpdate;

	struct Mem
    {
		
    }
	
	public CPU() { }
	
	public void reset()
    {
		PC = 0xFFFC;
		SP = 0x0100;
         
        A = X = Y = 0;

		// set all status flags to false
		flags["C"] = flags["Z"] = flags["I"] = flags["D"] = flags["B"] = flags["V"] = flags["N"] = false;

		onFlagsUpdate?.Invoke(this, EventArgs.Empty);
	}

}
