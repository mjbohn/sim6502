
using CPU_emu;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.DataCollection;
using NuGet.Frameworks;
using System.Reflection;
using System.Reflection.Emit;



namespace CPU_emulator; 

[TestFixture]
public class CPU_Tests
{
    private CPU cpu;
    private RamBus ram;
    private RomBus basicRom;
    private RomBus kernalRom;
    private IoDevice ioDevice;
    private byte[] _data = new byte[65536];

    [SetUp]
    public void Setup()
    {
        InitializeMemory();
        MappedBus memoryBus = new MappedBus(ram, basicRom, kernalRom, ioDevice);
        cpu = new CPU(memoryBus);
    }

    private void InitializeMemory()
    {
        ram = new RamBus(_data);
        //var basicRom = new RomBus(File.ReadAllBytes("basic.rom"), 0xA000);
        //var kernalRom = new RomBus(File.ReadAllBytes("kernal.rom"), 0xE000);
        basicRom = new RomBus(new byte[1024 * 8], 0xA000);
        kernalRom = new RomBus(new byte[1024 * 8], 0xE000);
        ioDevice = new IoDevice();
    }

    #region set registers

    [Test]
    public void SetRegister_A_Test()
    {
        byte value = 0xff;
        cpu.SetRegister("A", value);
        Assert.That(cpu.A, Is.EqualTo(0xff));

    }

    [Test]
    public void SetRegister_X_Test()
    {
        byte value = 0xff;
        cpu.SetRegister("X", value);
        Assert.That(cpu.X, Is.EqualTo(0xff));

    }

    [Test]
    public void SetRegister_Y_Test()
    {
        byte value = 0xff;
        cpu.SetRegister("Y", value);
        Assert.That(cpu.Y, Is.EqualTo(0xff));

    }
    
    #endregion set registers

    #region misc
    [Test]
    public void Reset_Test()
    {
        bool eventSetPCRaised = false;
        bool eventFlagsUpdateRaised = false;

        cpu.OnProgramCounterUpdate += (object? sender, CPUEventArgs e) => { eventSetPCRaised = true; };
        cpu.OnFlagsUpdate += (object? sender, CPUEventArgs e) => { eventFlagsUpdateRaised = true;  };

        cpu.Reset();

        Assert.IsTrue(eventSetPCRaised, "Event for PC update not raised");
        Assert.IsTrue(eventFlagsUpdateRaised, "Event for flags-update not raised");

        Assert.That(cpu.PC, Is.EqualTo(0x200));
        Assert.That(cpu.SP, Is.EqualTo(0x1FF));
        Assert.That(cpu.A, Is.EqualTo(0));
        Assert.That(cpu.X, Is.EqualTo(0)); 
        Assert.That(cpu.A, Is.EqualTo(0));
         
        Assert.That(cpu.flags["C"], Is.False);
        Assert.That(cpu.flags["Z"], Is.False);
        Assert.That(cpu.flags["I"], Is.False);
        Assert.That(cpu.flags["D"], Is.False);
        Assert.That(cpu.flags["B"], Is.False);
        Assert.That(cpu.flags["V"], Is.False);
        Assert.That(cpu.flags["N"], Is.False);

    }
    
    [Test]
    public void SetVectors_Test() 
    {
        TestHelper.GetPrivateMethod("SetVectors", cpu).Invoke(cpu, null);
        byte[] memory = cpu.ReadMemory();

        Assert.That(memory[0xFFFC], Is.EqualTo(0x00));
        Assert.That(memory[0xFFFD], Is.EqualTo(0x02));
    }

    #endregion misc

    #region set flags

    [TestCase(0xff, ExpectedResult = new bool[] { false, true })]
    [TestCase(0x00, ExpectedResult = new bool[] { true, false })]
    public bool[] SetZeroAndNegativeFlags_Test(byte b)
    {
        CPUEventArgs? cpuea = null;

        cpu.OnFlagsUpdate += delegate (object? sender, CPUEventArgs e)
        {
            cpuea = e;
        };

        bool[] result = new bool[2];
        TestHelper.GetPrivateMethod("SetZeroAndNegativeFlags",cpu).Invoke(cpu,new object[] {b});

        if (cpuea != null)
        {
            switch (b)
            {
                case 0xff:
                    Assert.That(cpuea.Flags["Z"], Is.EqualTo(false));
                    Assert.That(cpuea.Flags["N"], Is.EqualTo(true));
                    break;
                case 0x00:
                    Assert.That(cpuea.Flags["Z"], Is.EqualTo(true));
                    Assert.That(cpuea.Flags["N"], Is.EqualTo(false));
                    break;

                default:
                    break;
            }

            
        }
        else
        {
            Assert.Fail("Event not triggered");
        }

        result[0] = cpu.flags["Z"];
        result[1] = cpu.flags["N"];

        return result;
    }
    
    #endregion set flags

    #region fetch data
    [Test]
    public void FetchByte_Test()
    {
        byte value = 0xff;
        ulong cyc = 100;

        cpu.ResetMemory();
        cpu.WriteByteToMemory(value, 200);
        cpu.SetPC(200);

        Assert.That(TestHelper.GetPrivateMethod("FetchByte", cpu).Invoke(cpu,null), Is.EqualTo(0xff));
        Assert.That(cpu.PC, Is.EqualTo(201));

    }

    #endregion fetch data

    #region ProgramCounterTest

    [Test]
    public void SetPC_Test() 
    {
        CPUEventArgs? cpuea = null;

        cpu.OnProgramCounterUpdate += delegate (object? sender, CPUEventArgs e)
        {
            cpuea = e;
        };

        cpu.SetPC(0x200);
        Assert.That(cpu.PC, Is.EqualTo(0x200));

        if (cpuea != null)
        {
            Assert.That(cpuea.PC, Is.EqualTo(0x200));
        }
        else
        {
            Assert.Fail("Event not triggered");
        }
    }

    [Test] 
    public void IncrementPC_Test()
    {
        cpu.SetPC(0x200);

        CPUEventArgs? cpuea = null;

        cpu.OnProgramCounterUpdate += delegate (object? sender, CPUEventArgs e)
        {
            cpuea = e;
        };

        cpu.IncrementPC();
        Assert.That(cpu.PC, Is.EqualTo(0x201));

        if (cpuea != null)
        {
            Assert.That(cpuea.PC, Is.EqualTo(0x201));
        }
        else
        {
            Assert.Fail("Event not triggered");
        }

    }

    [Test]
    public void DecrementPC_Test()
    {
        cpu.SetPC(0x201);

        CPUEventArgs? cpuea = null;

        cpu.OnProgramCounterUpdate += delegate (object? sender, CPUEventArgs e)
        {
            cpuea = e;
        };

        cpu.DecrementPC();
        Assert.That(cpu.PC, Is.EqualTo(0x200));

        if (cpuea != null)
        {
            Assert.That(cpuea.PC, Is.EqualTo(0x200));
        }
        else
        {
            Assert.Fail("Event not triggered");
        }

    }

    #endregion ProgramCounterTest

    #region StackPointerTest
    [Test]
    public void SetSP_Test()
    {
        CPUEventArgs? cpuea = null;

        cpu.OnStackPointerUpdate += delegate (object? sender, CPUEventArgs e)
        {
            cpuea = e;
        };

        TestHelper.GetPrivateMethod("SetSP", cpu).Invoke(cpu, new object[] { (ushort)0x01e0 });
        Assert.That(cpu.SP, Is.EqualTo(0x01e0));
        
        if (cpuea != null) 
        { 
            Assert.That(cpuea.SP, Is.EqualTo(0x01e0));
        }
        else
        {
            Assert.Fail("Event not triggered");
        }
        
    }

    [Test]
    public void IncrementSP_Test()
    {
        ushort? expectedSPfromEventargs = null;

        TestHelper.GetPrivateMethod("SetSP", cpu).Invoke(cpu, new object[] { (ushort)0x01fc });

        cpu.OnStackPointerUpdate += delegate (object? sender, CPUEventArgs e)
        {
            expectedSPfromEventargs = e.SP;
        };
                    
        TestHelper.GetPrivateMethod("IncrementSP", cpu).Invoke(cpu, null);
        Assert.That(cpu.SP, Is.EqualTo(0x01fd));

        if (expectedSPfromEventargs != null)
        {
            Assert.That(expectedSPfromEventargs, Is.EqualTo(0x01fd));
        }
        else
        {
            Assert.Fail("Event not triggered");
        }

    }

    [Test]
    public void DecrementSP_Test()
    {
        ushort? expectedSPfromEventargs = null;

        TestHelper.GetPrivateMethod("SetSP", cpu).Invoke(cpu, new object[] { (ushort)0x01ff });

        cpu.OnStackPointerUpdate += delegate (object? sender, CPUEventArgs e)
        {
            expectedSPfromEventargs = e.SP;
        };

        TestHelper.GetPrivateMethod("DecrementSP", cpu).Invoke(cpu, null);
        
        Assert.That(cpu.SP, Is.EqualTo(0x01fe));

        if (expectedSPfromEventargs != null)
        {
            Assert.That(expectedSPfromEventargs, Is.EqualTo(0x01fe));
        }
        else
        {
            Assert.Fail("Event not triggered");
        }

    }

    #endregion StackPointerTest


}

public class CPU_Command_Tests
{
    private CPU cpu;
    private RamBus ram;
    private RomBus basicRom;
    private RomBus kernalRom;
    private IoDevice ioDevice;
    private byte[] _data = new byte[65536];

    [SetUp]
    public void Setup()
    {
        InitializeMemory();
        MappedBus memoryBus = new MappedBus(ram, basicRom, kernalRom, ioDevice);
        cpu = new CPU(memoryBus);
    }

    private void InitializeMemory()
    {
        ram = new RamBus(_data);
        //var basicRom = new RomBus(File.ReadAllBytes("basic.rom"), 0xA000);
        //var kernalRom = new RomBus(File.ReadAllBytes("kernal.rom"), 0xE000);
        basicRom = new RomBus(new byte[1024 * 8], 0xA000);
        kernalRom = new RomBus(new byte[1024 * 8], 0xE000);
        ioDevice = new IoDevice();
    }

    //public void RunSingleOpcodeTest(byte opcode, byte operand, ushort pcStart = 0x200)
    //{
    //    cpu.Reset();
    //    cpu.WriteByteToMemory(operand, pcStart);
    //    cpu.SetPC(pcStart);

    //    TestHelper.GetPrivateMethod("CallInstruction", cpu).Invoke(cpu, new object[] { cpu.GetType(), opcode });
    //}

    #region LDA

    // Test Load Accumulator immidiate A9
    [TestCase(0xff, false, true, 0xff, 3)]
    [TestCase(0x00, true, false, 0x00, 3)]
    public void Cmd_A9_Test(byte value, bool expectedZ, bool expectedN, byte expectedA, int expectedCycles)
    {
        cpu.WriteByteToMemory(value, 0x200);
        cpu.SetPC(0x200);

        TestHelper.GetPrivateMethod("CallInstruction", cpu).Invoke(cpu, new object[] { cpu.GetType(), (byte)0xA9 });

        Assert.Multiple(() =>
        {
            Assert.That(cpu.flags["Z"], Is.EqualTo(expectedZ), "Zero Flag");
            Assert.That(cpu.flags["N"], Is.EqualTo(expectedN), "Negative Flag");
            Assert.That(cpu.A, Is.EqualTo(expectedA), "Register A");
            Assert.That(cpu.CpuCycle, Is.EqualTo(expectedCycles), "CPU Cycles");
        });
    }


    // Test Load Accumulator zeropage A5
    [TestCase(0xff, false, true, 0xff, 3)]
    [TestCase(0x00, true, false, 0x00, 3)]
    public void Cmd_A5_Test(byte value, bool expectedZ, bool expectedN, byte expectedA, int expectedCycles)
    {
        cpu.WriteByteToMemory(value, 0x01); // set byte on zeropage adr. 0x01
        cpu.WriteByteToMemory(0x01, 0x200);
        cpu.SetPC(0x200);
        TestHelper.GetPrivateMethod("CallInstruction", cpu).Invoke(cpu, new object[] { cpu.GetType(), (byte)0xA5 });
        
        Assert.Multiple(() =>
        {
            Assert.That(cpu.flags["Z"], Is.EqualTo(expectedZ), "Zero Flag");
            Assert.That(cpu.flags["N"], Is.EqualTo(expectedN), "Negative Flag");
            Assert.That(cpu.A, Is.EqualTo(expectedA), "Register A");
            Assert.That(cpu.CpuCycle, Is.EqualTo(expectedCycles), "CPU Cycles");
        });

    }

    // Load Accumulator zeropage X B5
    [TestCase(0xff, false, true, 0xff, 5)]
    [TestCase(0x00, true, false, 0x00, 5)]
    public void Cmd_B5_Test(byte value, bool expectedZ, bool expectedN, byte expectedA, int expectedCycles)
    {
        cpu.Reset();
        cpu.SetRegister("X",0x06);        // load X with 0x06
        cpu.WriteByteToMemory(value, 0x07);     // set byte on zeropage adr. 0x07
        cpu.WriteByteToMemory(0x01, 0x200);  // set 0x01 on the next position of PC so value ox X (0x06) + 0x01 from instruction points to 0x07
        cpu.SetPC(0x200);
        
        TestHelper.GetPrivateMethod("CallInstruction", cpu).Invoke(cpu, new object[] { cpu.GetType(), (byte)0xB5 });

        Assert.Multiple(() =>
        {
            Assert.That(cpu.flags["Z"], Is.EqualTo(expectedZ), "Zero Flag");
            Assert.That(cpu.flags["N"], Is.EqualTo(expectedN), "Negative Flag");
            Assert.That(cpu.A, Is.EqualTo(expectedA), "Register A");
            Assert.That(cpu.CpuCycle, Is.EqualTo(expectedCycles), "CPU Cycles");
        });
    }

    // Load Accumulator absolute AD
    [TestCase(0xff, false, true, 0xff, 6)]
    [TestCase(0x00, true, false, 0x00, 6)]
    public void Cmd_AD_Test(byte value, bool expectedZ, bool expectedN, byte expectedA, int expectedCycles)
    {
        cpu.Reset();
        cpu.WriteByteToMemory(value, 0xFFEE);
        cpu.WriteByteToMemory(0xEE, 0x200);
        cpu.WriteByteToMemory(0xFF, 0x201);
        cpu.SetPC(0x200);

        TestHelper.GetPrivateMethod("CallInstruction", cpu).Invoke(cpu, new object[] { cpu.GetType(), (byte)0xAD });

        Assert.Multiple(() =>
        {
            Assert.That(cpu.flags["Z"], Is.EqualTo(expectedZ), "Zero Flag");
            Assert.That(cpu.flags["N"], Is.EqualTo(expectedN), "Negative Flag");
            Assert.That(cpu.A, Is.EqualTo(expectedA), "Register A");
            Assert.That(cpu.CpuCycle, Is.EqualTo(expectedCycles), "CPU Cycles");
        });

    }

        #endregion

    #region LDX

    // Test Load X immidiate A2
    [TestCase(0xff, ExpectedResult = new object[] { false, true, 0xff })]
    [TestCase(0x00, ExpectedResult = new object[] { true, false, 0x00 })]
    public object[] Cmd_A2_Test(byte b)
    {
        object[] result = new object[3];

        cpu.WriteByteToMemory(b, 0x200);
        cpu.SetPC(0x200);
        cpu.Cmd_A2();

        result[0] = cpu.flags["Z"];
        result[1] = cpu.flags["N"];
        result[2] = cpu.X;

        return result;

    }

    // Test Load X zeropage A6
    [TestCase(0xff, ExpectedResult = new object[] { false, true, 0xff })]
    [TestCase(0x00, ExpectedResult = new object[] { true, false, 0x00 })]
    public object[] Cmd_A6_Test(byte b)
    {
        object[] result = new object[3];

        cpu.WriteByteToMemory(b, 0x01); // set byte on zeropage adr. 0x01
        cpu.WriteByteToMemory(0x01, 0x200);
        cpu.SetPC(0x200);
        cpu.Cmd_A6();

        result[0] = cpu.flags["Z"];
        result[1] = cpu.flags["N"];
        result[2] = cpu.X;

        return result;

    }

    // Load X zeropage Y B6
    [TestCase(0xff, ExpectedResult = new object[] { false, true, 0xff })]
    [TestCase(0x00, ExpectedResult = new object[] { true, false, 0x00 })]
    public object[] Cmd_B6_Test(byte b)
    {
        object[] result = new object[3];
        cpu.SetRegister("Y", 0x06);
        cpu.WriteByteToMemory(b, 0x07); // set byte on zeropage adr. 0x01
        cpu.WriteByteToMemory(0x01, 0x200);
        cpu.SetPC(0x200);
        cpu.Cmd_B6();

        result[0] = cpu.flags["Z"];
        result[1] = cpu.flags["N"];
        result[2] = cpu.X;

        return result;

    }

    #endregion

    #region LDY

    // Test Load Y immidiate A0
    [TestCase(0xff, ExpectedResult = new object[] { false, true, 0xff })]
    [TestCase(0x00, ExpectedResult = new object[] { true, false, 0x00 })]
    public object[] Cmd_A0_Test(byte b)
    {
        object[] result = new object[3];

        cpu.WriteByteToMemory(b, 0x200);
        cpu.SetPC(0x200);
        cpu.Cmd_A0();

        result[0] = cpu.flags["Z"];
        result[1] = cpu.flags["N"];
        result[2] = cpu.Y;

        return result;

    }

    // Test Load Y zeropage A4
    [TestCase(0xff, ExpectedResult = new object[] { false, true, 0xff })]
    [TestCase(0x00, ExpectedResult = new object[] { true, false, 0x00 })]
    public object[] Cmd_A4_Test(byte b)
    {
        object[] result = new object[3];

        cpu.WriteByteToMemory(b, 0x01); // set byte on zeropage adr. 0x01
        cpu.WriteByteToMemory(0x01, 0x200);
        cpu.SetPC(0x200);
        cpu.Cmd_A4();

        result[0] = cpu.flags["Z"];
        result[1] = cpu.flags["N"];
        result[2] = cpu.Y;

        return result;

    }

    // Load Y zeropage X B4
    [TestCase(0xff, ExpectedResult = new object[] { false, true, 0xff })]
    [TestCase(0x00, ExpectedResult = new object[] { true, false, 0x00 })]
    public object[] Cmd_B4_Test(byte b)
    {
        object[] result = new object[3];
        cpu.SetRegister("X", 0x06);
        cpu.WriteByteToMemory(b, 0x07); // set byte on zeropage adr. 0x01
        cpu.WriteByteToMemory(0x01, 0x200);
        cpu.SetPC(0x200);
        cpu.Cmd_B4();

        result[0] = cpu.flags["Z"];
        result[1] = cpu.flags["N"];
        result[2] = cpu.Y;

        return result;

    }


    #endregion

    #region push pull

    // Test Push Accumulator on Stack
    [Test]
    public void Cmd_48_Test()
    {
        CPUEventArgs? cpuea = null;

        cpu.OnStackPointerUpdate += delegate (object? sender, CPUEventArgs e)
        {
            cpuea = e;
        };

        cpu.Reset();
        cpu.SetRegister("A", 0x42);
        cpu.Cmd_48();

        Assert.That(cpu.SP, Is.EqualTo(0x01fe));

        if (cpuea != null)
        {
            Assert.That(cpuea.SP, Is.EqualTo(0x01fe));
        }
        else
        {
            Assert.Fail("Event not triggered");
        }

        Assert.That(cpu.Memory[0x01ff], Is.EqualTo(0x42));

    }

    #endregion
}

static class TestHelper
{
    public static MethodInfo GetPrivateMethod(string methodName, object objectUnderTest)
    {
        if (string.IsNullOrWhiteSpace(methodName))
            Assert.Fail("methodName cannot be null or whitespace");

        MethodInfo? method = objectUnderTest.GetType()
            .GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);

        if (method == null)
            Assert.Fail(string.Format("{0} method not found", methodName));

        return method;
    }
    
}