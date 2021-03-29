using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_emulator
{
    

    public partial class MemoryWatchForm : Form
    {

        CPU Cpu;
        private uint _startAddress;
        private uint _endAddress;
        
        public uint StartAddress { get => _startAddress; set => _startAddress = value; }
        public uint EndAddress { get => _endAddress; set => _endAddress = value; }

        private delegate void CpuEventCallback(object sender, CPUEventArgs e);
      
        #region Constructors
        public MemoryWatchForm(CPU cpu)
        {
            InitializeComponent();
            Cpu = cpu;

            Cpu.OnMemoryUpdate += Cpu_OnMemoryUpdate;
            Cpu.OnStackPointerUpdate += Cpu_OnStackPointerUpdate;
                                   
        }
        public MemoryWatchForm(uint startAddress, uint endAddress, CPU cpu) : this(cpu)
        {
            StartAddress = startAddress;
            EndAddress = endAddress;
        }
        #endregion
        
        private void MemoryWatchForm_Load(object sender, EventArgs e)
        {
            FillRichTextBox(Cpu.ReadMemory());
        }
     
        #region CpuEventHandling
        private void Cpu_OnMemoryUpdate(object sender, CPUEventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnMemoryUpdate);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                FillRichTextBox(e.Memory);
            }
        }

        private void Cpu_OnStackPointerUpdate(object sender, CPUEventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnStackPointerUpdate);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                FillRichTextBox(e.Memory);
            }
        }
        #endregion
        
        private void FillRichTextBox(byte[] memory)
        {
            StringBuilder sbmem = new StringBuilder();
            StringBuilder sblinenum = new StringBuilder();
            string separator = " | ";

            for (uint i = StartAddress; i <= EndAddress; i++)
            {
                if (i == 0)
                {
                    //sbmem.Append("<" + i.ToString("X4") + "> ");
                    sblinenum.Append("<" + i.ToString("X4") + "> ");
                }
                if ((i % 16) == 0 && i > 0)
                {
                    //sbmem.Append("\n" + "<" + i.ToString("X4") + "> ");
                    sbmem.Append("\n");
                    sblinenum.Append("\n" + "<" + i.ToString("X4") + "> ");
                }

                sbmem.Append(memory[i].ToString("X2") + separator);
            }

            richTextBoxMem.Text = sbmem.ToString();
            richTextBoxLineNum.Text = sblinenum.ToString();

            int separatorLength = separator.Length;

            int PCposition = (int)Cpu.PC;
            int PClinecorrection = PCposition / 16;
            int PCselStart = (PCposition * 2) + (PCposition * separatorLength) + PClinecorrection;

            // Stackpointer Position
            int SPposition = (int)Cpu.SP - 256;
            int SPlinecorrection = SPposition / 16;
            int SPselStart = (SPposition * 2) + (SPposition * separatorLength) + SPlinecorrection +1;

            
            richTextBoxMem.SelectionStart = 0;
            richTextBoxMem.SelectionLength = richTextBoxMem.Text.Length;

            switch (this.Tag.ToString().ToUpper())
            {
                case "STACK":
                    richTextBoxMem.SelectionBackColor = Color.LightCoral;
                    // SP Marker
                    richTextBoxMem.SelectionStart = SPselStart;
                    richTextBoxMem.SelectionLength = 2;
                    richTextBoxMem.SelectionColor = Color.Lime;
                    richTextBoxMem.SelectionBackColor = Color.Black;
                    break;
                case "ZEROPAGE":
                    richTextBoxMem.SelectionBackColor = Color.MediumPurple;
                    break;
                default:
                    break;
            }
            

                      

            // PC Marker
            richTextBoxMem.SelectionStart = PCselStart;
            richTextBoxMem.SelectionLength = 2;
            richTextBoxMem.SelectionColor = Color.Red;
            richTextBoxMem.SelectionBackColor = Color.Yellow;
            //richTextBoxMem.SelectionFont = new Font("Courier New", 9 ,FontStyle.Bold);

            

            //this.Refresh();
        }

        private void MemoryWatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
