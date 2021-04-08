using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_emulator
{
    

    public partial class MemoryWatchForm : Form
    {
        const int WM_USER = 0x400;
        const int EM_GETSCROLLPOS = WM_USER + 221;
        const int EM_SETSCROLLPOS = WM_USER + 222;

        [DllImport("User32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Point lParam);

        CPU Cpu;
        private uint _startAddress;
        private uint _endAddress;

        private int _startAddressSave = -1;
        private int _endAddressSave = -1;

        public uint StartAddress { get => _startAddress; set => _startAddress = value; }
        public uint EndAddress { get => _endAddress; set => _endAddress = value; }

        private delegate void CpuEventCallback(object sender, CPUEventArgs e);
      
        #region Constructors
        public MemoryWatchForm(CPU cpu)
        {
            InitializeComponent();
            Cpu = cpu;

            StartAddress = 0x200;
            EndAddress = 0x3FF;

            Cpu.OnMemoryUpdate += Cpu_OnMemoryUpdate;
            Cpu.OnStackPointerUpdate += Cpu_OnStackPointerUpdate;
            Cpu.OnProgramCounterUpdate += Cpu_OnProgramCounterUpdate;
                                   
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

        private void Cpu_OnProgramCounterUpdate(object sender, CPUEventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnProgramCounterUpdate);
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

            #region assemble lines and print
            StringBuilder sbmem = new StringBuilder();
            StringBuilder sblinenum = new StringBuilder();
            string separator = " | ";

            for (uint i = StartAddress; i <= EndAddress; i++)
            {
                if (i == 0)
                {
                    sblinenum.Append("<" + i.ToString("X4") + "> ");
                }
                if ((i % 16) == 0 && i > 0)
                {
                    sbmem.Append("\n");
                    sblinenum.Append("\n" + "<" + i.ToString("X4") + "> ");
                }

                sbmem.Append(memory[i].ToString("X2") + separator);
            }
            
            richTextBoxMem.Text = sbmem.ToString();
            richTextBoxLineNum.Text = sblinenum.ToString();
            #endregion

            int separatorLength = separator.Length;

            // ProgramCounter Position
            int PCposition = (int)Cpu.PC - (int)StartAddress;
            int PClinecorrection = PCposition / 16;
            int PCselStart = (PCposition * 2) + (PCposition * separatorLength) + PClinecorrection + 1;

            // Stackpointer Position
            int SPposition = (int)Cpu.SP - 256;
            int SPlinecorrection = SPposition / 16;
            int SPselStart = (SPposition * 2) + (SPposition * separatorLength) + SPlinecorrection + 1;

            
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
                case "MEMRANGE":
                    toolStrip1.Visible = true;
                    toolStripTextBoxStartAddress.Text = StartAddress.ToString("X4");
                    toolStripTextBoxEndAddress.Text = EndAddress.ToString("X4");
                    toolStripButtonLoad.Enabled = false;
                    toolStripButtonCancel.Enabled = false;
                    // PC Marker
                    if (PCselStart >= 0)
                    {
                        richTextBoxMem.SelectionStart = PCselStart;
                        richTextBoxMem.SelectionLength = 2;
                        richTextBoxMem.SelectionColor = Color.Red;
                        richTextBoxMem.SelectionBackColor = Color.Yellow; 
                    }
                    break;
                default:
                    break;
            }
   
        }

        private void MemoryWatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // unsubscribe events
            Cpu.OnMemoryUpdate -= Cpu_OnMemoryUpdate;
            Cpu.OnStackPointerUpdate -= Cpu_OnStackPointerUpdate;
            Cpu.OnProgramCounterUpdate -= Cpu_OnProgramCounterUpdate;
        }

        #region TextBox ScrollSync

        // Synchronize Textbox scrooling
        private void richTextBoxLineNum_VScroll(object sender, EventArgs e)
        {
            Point pt = new Point();
            SendMessage(richTextBoxLineNum.Handle, EM_GETSCROLLPOS, 0, ref pt);
            SendMessage(richTextBoxMem.Handle, EM_SETSCROLLPOS, 0, ref pt);
        }

        private void richTextBoxMem_VScroll(object sender, EventArgs e)
        {
            Point pt = new Point();
            SendMessage(richTextBoxMem.Handle, EM_GETSCROLLPOS, 0, ref pt);
            SendMessage(richTextBoxLineNum.Handle, EM_SETSCROLLPOS, 0, ref pt);
        }

        #endregion

        private void ToolStripTextBoxStartAddress_Enter(object sender, EventArgs e)
        {
            SaveStartAndEndAddresses();
        }

        private void ToolStripTextBoxEndAddress_Enter(object sender, EventArgs e)
        {
            SaveStartAndEndAddresses();
        }

        private void SaveStartAndEndAddresses()
        {
            if (_startAddressSave == -1)
            {
                _startAddressSave = Convert.ToInt32(toolStripTextBoxStartAddress.Text.ToString(), 16);
            }

            if (_endAddressSave == -1)
            {
                _endAddressSave = Convert.ToInt32(toolStripTextBoxEndAddress.Text.ToString(), 16);
            }
        }

        private void ToolStripTextBoxStartAddress_TextChanged(object sender, EventArgs e)
        {
            StartAddress = Convert.ToUInt32(toolStripTextBoxStartAddress.Text.ToString(), 16);
            toolStripButtonLoad.Enabled = true;
            toolStripButtonCancel.Enabled = true;
        }

        private void ToolStripTextBoxEndAddress_TextChanged(object sender, EventArgs e)
        {
            EndAddress = Convert.ToUInt32(toolStripTextBoxEndAddress.Text.ToString(), 16);
            toolStripButtonLoad.Enabled = true;
            toolStripButtonCancel.Enabled = true;
        }

        private void ToolStripButtonCancel_Click(object sender, EventArgs e)
        {
            if (_startAddressSave > -1)
            {
                toolStripTextBoxStartAddress.Text = _startAddressSave.ToString("X4");
                _startAddressSave = -1;
            }
            if (_endAddressSave > -1)
            {
                toolStripTextBoxEndAddress.Text = _endAddressSave.ToString("X4");
                _endAddressSave = -1;
            }

            toolStripButtonLoad.Enabled = false;
            toolStripButtonCancel.Enabled = false;
        }

        private void ToolStripButtonLoad_Click(object sender, EventArgs e)
        {
            FillRichTextBox(Cpu.ReadMemory());
            _startAddressSave = -1;
            _endAddressSave = -1;
        }
    }
}
