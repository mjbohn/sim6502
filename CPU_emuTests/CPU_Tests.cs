
using System.Reflection;

namespace CPU_emulator 
{
    [TestFixture]
    public class CPU_Tests
    {
        private CPU cpu;
        
        [SetUp]
        public void Setup()
        {
            cpu = new CPU();
        }
        #region set registers
        [Test]
        public void Test_SetRegister_A()
        {
            byte value = 0xff;
            cpu.SetRegister("A", value);
            Assert.That(cpu.A, Is.EqualTo(0xff));

        }

        [Test]
        public void Test_SetRegister_X()
        {
            byte value = 0xff;
            cpu.SetRegister("X", value);
            Assert.That(cpu.X, Is.EqualTo(0xff));

        }

        [Test]
        public void Test_SetRegister_Y()
        {
            byte value = 0xff;
            cpu.SetRegister("Y", value);
            Assert.That(cpu.Y, Is.EqualTo(0xff));

        }
        #endregion

        [Test]
        public void Test_Reset()
        {
            
            cpu.Reset();
           
            
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

        #region fetch data
        [Test]
        public void Test_FetchByte()
        {
            byte value = 0xff;
            ulong cyc = 100;

            cpu.ResetMemory();
            cpu.WriteByteToMemory(value, 200);
            cpu.SetPC(200);

            Assert.That(GetPrivateMethod("FetchByte",cpu).Invoke(cpu,new object[] {cyc}), Is.EqualTo(0xff));
            Assert.That(cpu.PC, Is.EqualTo(201));

        }

        #endregion

        #region helper
        private MethodInfo GetPrivateMethod(string methodName,object objectUnderTest)
        {
            if (string.IsNullOrWhiteSpace(methodName))
                Assert.Fail("methodName cannot be null or whitespace");

            var method = objectUnderTest.GetType()
                .GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);

            if (method == null)
                Assert.Fail(string.Format("{0} method not found", methodName));

            return method;
        }

        #endregion
    }

    //public class CPU_Tests2
    //{
    //    private CPU cpu;

    //    [SetUp] 
    //    public void SetUp() 
    //    {
    //        cpu= new CPU();    
    //    }

        
    //}
}