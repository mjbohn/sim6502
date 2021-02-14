using CPU_emulator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CPU_emulator
{
	public partial class CPU
	{
		public ushort PC;    // ProgramCounter
		public ushort SP;    // StackPointer
		public byte A, X, Y; // registers

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

        public event EventHandler OnFlagsUpdate;
		public event EventHandler OnMemoryUpdate;
		public event EventHandler OnRegisterUpdate;
		public event EventHandler OnProgramCounterUpdate;
		public event EventHandler OnStackPointerUpdate;
		
		public CPU() { }

		public void Reset()
		{
			//var rand = new Random();
			//rand.NextBytes(Data);
			//OnMemoryUpdate?.Invoke(this, EventArgs.Empty);

			SetPC(0x0200);//(0xFFFC);
			SetSP(0x0100);

			SetRegister("A", 0);
			SetRegister("X", 0);
			SetRegister("Y", 0);
			InterruptPeriod = 1000;
			ExitRequested = false;

			// set all status flags to false
			flags["C"] = flags["Z"] = flags["I"] = flags["D"] = flags["B"] = flags["V"] = flags["N"] = false;

			OnFlagsUpdate?.Invoke(this, EventArgs.Empty);

			ResetMemory();

			LoadInlineTestProg();
		}

        private void LoadInlineTestProg()
        {
            Data[PC] = 0xA9;
			Data[PC + 1] = 0xab;
			Data[PC + 2] = 0xA9;
			Data[PC + 3] = 0xac;
			Data[PC + 4] = 0xA9;
			Data[PC + 5] = 0xad;
			Data[PC + 6] = 0xA9;
			Data[PC + 7] = 0xae;

			OnMemoryUpdate?.Invoke(this, EventArgs.Empty);
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

			while (CpuIsRunning)
			{
				byte instruction = FetchByte(ref cycles);
				switch (instruction)
				{
					case LDA_IM:
						byte b = FetchByte(ref cycles);
						SetRegister("A", b);
						SetZeroAndNegativeFlags(A); 
						break;
					default:
						
						break;
				}

                if (_SteppingMode)
                {
					break;
                }

				if (cycles <= 0)
				{
					cycles = InterruptPeriod;
					if (ExitRequested)
					{
						break;
					}

				}

			}
		}

        public void Stop()
        {
			ExitRequested = true;
        }

        private void SetZeroAndNegativeFlags(byte register)
        {
			flags["Z"] = (register == 0);
			flags["N"] = (register & NegativeFlagBit) > 0;
			OnFlagsUpdate?.Invoke(this, EventArgs.Empty);
		}

        private byte FetchByte(ref ulong cycles)
		{
			byte data = Data[PC];
			IncPC();
			cycles--;
			return data;
		}

		private void SetSP(ushort value)
		{
			SP = value;
			OnStackPointerUpdate?.Invoke(this, EventArgs.Empty);
		}
		private void IncSP()
		{
			SP++;
			OnStackPointerUpdate?.Invoke(this, EventArgs.Empty);
		}
		private void DecSP()
		{
			SP--;
			OnStackPointerUpdate?.Invoke(this, EventArgs.Empty);
		}
		private void SetPC(ushort value)
		{
			PC = value;
			OnProgramCounterUpdate?.Invoke(this, EventArgs.Empty);
		}
		public void IncPC()
		{
			PC++;
			OnProgramCounterUpdate?.Invoke(this, EventArgs.Empty);
		}
		public void DecPC()
		{
			PC--;
			OnProgramCounterUpdate?.Invoke(this, EventArgs.Empty);
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
			OnRegisterUpdate?.Invoke(this, EventArgs.Empty);
		}
		public void ResetMemory()
		{
			for (int i = 0; i < MAX_MEM; i++)
			{
				Data[i] = 0x00;
			}

			OnMemoryUpdate?.Invoke(this, EventArgs.Empty);
		}
		public byte[] ReadMemory()
		{
			return Data;
		}


	}
}
