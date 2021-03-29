﻿using CPU_emulator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CPU_emulator
{
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

        private const uint MAX_MEM = 1024 * 64;
		private byte[] Data = new byte[MAX_MEM];

        private byte
            NegativeFlagBit = 0b10000000,
			OverflowFlagBit = 0b01000000,
			BreakFlagBit    = 0b000010000,
			UnusedFlagBit   = 0b000100000,
            InterruptDisableFlagBit = 0b000000100,
            ZeroBit = 0b00000001;

        public bool SteppingMode { get => _SteppingMode; set => _SteppingMode = value; }
        public bool ExitRequested { get => _ExitRequested; set => _ExitRequested = value; }
        public ulong InterruptPeriod { get => _InterruptPeriod; set => _InterruptPeriod = value; }
        //public uint PC { get => pC; set => pC = value; }
        //public uint InitialPC { get => _initialPC; set => _initialPC = value; }

        public event EventHandler<CPUEventArgs> OnFlagsUpdate;
		public event EventHandler<CPUEventArgs> OnMemoryUpdate;
		public event EventHandler<CPUEventArgs> OnRegisterUpdate;
		public event EventHandler<CPUEventArgs> OnProgramCounterUpdate;
		public event EventHandler<CPUEventArgs> OnStackPointerUpdate;
		public event EventHandler<CPUEventArgs> OnPCoverflow;
		public event EventHandler<CPUEventArgs> OnBreak;
		
		public CPU() 
		{
			SetVectors();
		}

        private void SetVectors()
        {
			//Data[0xFFFC] = 0x00; Data[0xFFFD] = 0x20;
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
			InterruptPeriod = 1000;
			ExitRequested = false;

			// set all status flags to false
			flags["C"] = flags["Z"] = flags["I"] = flags["D"] = flags["B"] = flags["V"] = flags["N"] = false;

			OnFlagsUpdate?.Invoke(this, new CPUEventArgs(this));

			ResetMemory();

			LoadInlineTestProg();
		}

        private void LoadInlineTestProg()
        {
            Data[PC] = 0xA9;
            Data[PC + 1] = 0x0b;
            Data[PC + 2] = 0x48;
            Data[PC + 3] = 0xA9;
            Data[PC + 4] = 0xac;
            Data[PC + 5] = 0x48;
            Data[PC + 6] = 0xA9;
            Data[PC + 7] = 0x00;
            Data[PC + 8] = 0x48;
            Data[PC + 9] = 0xA9;
            Data[PC + 10] = 0xae;
            Data[PC + 11] = 0x48;

			Data[PC + 12] = 0x48;
			Data[PC + 13] = 0x48;
            Data[PC + 14] = 0x48;
            Data[PC + 15] = 0x48;

			Data[PC + 16] = 0x48;
			Data[PC + 17] = 0x48;
			Data[PC + 18] = 0x48;
			Data[PC + 19] = 0x48;

			Data[PC + 20] = 0x48;
			Data[PC + 21] = 0x48;
			Data[PC + 22] = 0x48;
			Data[PC + 23] = 0x48;
			Data[PC + 24] = 0x48;
			Data[PC + 25] = 0x48;
			Data[PC + 26] = 0x48;
			Data[PC + 27] = 0x48;

			OnMemoryUpdate?.Invoke(this, new CPUEventArgs(this));
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
			ulong cycles = InterruptPeriod;
			byte b_tmp = 0;

			while (CpuIsRunning)
			{
				byte instruction = FetchByte(ref cycles);
				switch (instruction)
				{
					case OC_BRK:
						ExitRequested = true;
						OnBreak?.Invoke(this, new CPUEventArgs(this));
						break;
					case OC_LDA_IM: // Load Accumulator immidiate
                        b_tmp = FetchByte(ref cycles);
						SetRegister("A", b_tmp);
						SetZeroAndNegativeFlags(A); 
						break;
					case OC_PHA: // Push Accumulator on Stack
						PushByteToStack(A,ref cycles);
						break;
					case OC_PLA: // Pull Accumulator from Stack
                        b_tmp = PullByteFromStack(ref cycles);
						SetRegister("A", b_tmp);
						SetZeroAndNegativeFlags(A);
						break;
					default:
						
						break;
				}
				
                if (_SteppingMode)
                {
					break;
                }
				if (ExitRequested)
				{
					break;
				}
				if (PC >= MAX_MEM)
				{
					OnPCoverflow?.Invoke(this, new CPUEventArgs(this));
					break;
				}

				if (cycles <= 0)
				{
					cycles = InterruptPeriod;
				}

                if (SlowDown && !_SteppingMode)
                {
					System.Threading.Thread.Sleep(SlowDownTime);
				}
				

			}
		}

        private byte PullByteFromStack(ref ulong cycles)
        {
            IncrementSP();
			cycles--;
			byte b = ReadByteFromMemory(SP);
			cycles--;
			return b;
        }

        private void PushByteToStack(byte b,ref ulong cycles)
        {
			WriteByteToMemory(b, SP);
			cycles--;
			DecrementSP();
			cycles--;
			
        }

        public void Stop()
        {
			ExitRequested = true;
        }

        private void SetZeroAndNegativeFlags(byte register)
        {
			flags["Z"] = (register == 0);
			flags["N"] = (register & NegativeFlagBit) > 0;
			OnFlagsUpdate?.Invoke(this, new CPUEventArgs(this));
		}

        private byte FetchByte(ref ulong cycles)
		{
			byte data = Data[PC];
			IncrementPC();
			cycles--;
			return data;
		}

		private void WriteByteToMemory(byte b,ushort address)
        {
			Data[address] = b;
			OnMemoryUpdate?.Invoke(this, new CPUEventArgs(this));
		}

		private byte ReadByteFromMemory(ushort address)
        {
			return Data[address];
        }

		private ushort ReadWordFromMemory(ushort address)
        {
			//ushort tmpPC = ReadByteFromMemory(ResetVector);
			//ResetVector++;
			//tmpPC |= (ushort)(ReadByteFromMemory(ResetVector) << 8);


			ushort LoByte = ReadByteFromMemory(address);
			address++;
			ushort HiByte = (ushort)(ReadByteFromMemory(address) <<8);
			
			return LoByte |= HiByte;
        }

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
		public void SetPC(uint value)
		{
			PC = value;
			OnProgramCounterUpdate?.Invoke(this, new CPUEventArgs(this)
				);
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
			for (int i = 0; i < MAX_MEM; i++)
			{
				Data[i] = 0x00;
			}

			SetVectors();

			//OnMemoryUpdate?.Invoke(this, EventArgs.Empty);
			OnMemoryUpdate?.Invoke(this, new CPUEventArgs(this));
		}
		public byte[] ReadMemory()
		{
			return Data;
		}


	}

	public class CPUEventArgs : EventArgs
	{
		CPU cpu = new CPU();

		public string Message { get; set; }
		public byte[] Memory { get; set; }
		public uint PC { get; set; }
		public ushort SP { get; set; }
		public byte A { get; set; }
		public byte X { get; set; }
		public byte Y { get; set; }
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
		}

		
	}
}
