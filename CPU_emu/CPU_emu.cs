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
    public partial class CPU_emu : Form
    {
        CPU Cpu ;

        const int WM_USER = 0x400;
        const int EM_GETSCROLLPOS = WM_USER + 221;
        const int EM_SETSCROLLPOS = WM_USER + 222;

        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        [DllImport("User32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Point lParam);


        private delegate void CpuEventCallback(object sender, CPUEventArgs e);

        private MemoryWatchForm MWFstack, MWFzeropage = null;

        public CPU_emu()
        {
            //CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            
            Cpu = new CPU();
            Cpu.OnFlagsUpdate += Cpu_onFlagsUpdate;
            Cpu.OnMemoryUpdate += Cpu_OnMemoryUpdate;
            Cpu.OnRegisterUpdate += Cpu_OnRegisterUpdate;
            Cpu.OnStackPointerUpdate += Cpu_OnStackPointerUpdate;
            Cpu.OnProgramCounterUpdate += Cpu_OnProgramCounterUpdate;
            Cpu.OnPCoverflow += Cpu_OnPCgtThenMaxMem;
            Cpu.OnBreak += Cpu_OnBreak;
                        
            Cpu.Reset();
            
        }

        private void Cpu_OnBreak(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnBreak);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                stopwatch.Stop();
                SetToolStripElapsedTime();
                toolStripStatusLabelBRK.Text = "BRK";
                toolStripStatusLabelBRK.ForeColor = Color.Red;
            }

        }

        private void SetToolStripElapsedTime(bool reset = false)
        {
            if (reset)
            {
                toolStripStatusElapsedTime.Text = string.Empty;
            }
            else
            {
                toolStripStatusElapsedTime.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
            }
            
        }

        private void Cpu_OnPCgtThenMaxMem(object sender, CPUEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Cpu_OnRefreshGraphics(object sender, CPUEventArgs e)
        {
            this.Refresh();
        }

        private void Cpu_OnProgramCounterUpdate(object sender, CPUEventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnProgramCounterUpdate);
                this.Invoke(cb,new object[] {sender ,e });
            }
            else
            {
                textBoxPC.Text = e.PC.ToString("X4");
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
                textBoxSP.Text = e.SP.ToString("X4");
                FillRichTextBox(e.Memory);
            }
            
        }

        private void Cpu_OnRegisterUpdate(object sender, CPUEventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnRegisterUpdate);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                textBoxRegA.Text = e.A.ToString("X2");
                textBoxRegX.Text = e.X.ToString("X2");
                textBoxRegY.Text = e.Y.ToString("X2");
            }
            
        }

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

        private void FillRichTextBox(byte[] data)
        {
            if (checkBoxLiveMemory.Checked)
            {
                StringBuilder sbmem = new StringBuilder();
                StringBuilder sblinenum = new StringBuilder();
                string separator = " | ";

                for (int i = 0; i < data.Length; i++)
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

                    sbmem.Append(data[i].ToString("X2") + separator);
                }

                richTextBoxMem.Text = sbmem.ToString();
                richTextBoxLineNum.Text = sblinenum.ToString();

                int separatorLength = separator.Length;

                int PCposition = (int)Cpu.PC;
                int PClinecorrection = PCposition / 16;
                int PCselStart = (PCposition * 2) + (PCposition * separatorLength) + PClinecorrection;

                int SPposition = (int)Cpu.SP;
                int SPlinecorrection = SPposition / 16;
                int SPselStart = (SPposition * 2) + (SPposition * separatorLength) + SPlinecorrection;

                //ZeroPage Marker
                richTextBoxMem.SelectionStart = 0;
                richTextBoxMem.SelectionLength = 1295;
                richTextBoxMem.SelectionBackColor = Color.MediumPurple;

                //Stack Marker
                richTextBoxMem.SelectionStart = 1296;
                richTextBoxMem.SelectionLength = 1295;
                richTextBoxMem.SelectionBackColor = Color.LightCoral;

                // PC Marker
                richTextBoxMem.SelectionStart = PCselStart;
                richTextBoxMem.SelectionLength = 2;
                richTextBoxMem.SelectionColor = Color.Red;
                richTextBoxMem.SelectionBackColor = Color.Yellow;
                //richTextBoxMem.SelectionFont = new Font("Courier New", 9 ,FontStyle.Bold);

                // SP Marker
                richTextBoxMem.SelectionStart = SPselStart;
                richTextBoxMem.SelectionLength = 2;
                richTextBoxMem.SelectionColor = Color.Lime;
                richTextBoxMem.SelectionBackColor = Color.Black; 
            }


        }

        private void Cpu_onFlagsUpdate(object sender, CPUEventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_onFlagsUpdate);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                DisplayFlags(e.Flags);
            }
                       
        }

        private void DisplayFlags(IDictionary<string, bool> flags)
        {
            foreach (CheckBox checkBox in groupBoxFlags.Controls)
            {
                checkBox.Checked = flags[checkBox.Tag.ToString()];
            }

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!checkBoxSlowDown.Checked)
            {
                stopwatch.Reset();
                stopwatch.Start(); 
            }
            Cpu.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            SetToolStripElapsedTime();
            Cpu.Stop(); 
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Cpu.Reset();
            stopwatch.Reset();
            SetToolStripElapsedTime(true);
            toolStripStatusLabelBRK.Text = string.Empty;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //StepMode
        {
            if (checkBox1.Checked)
            {
                buttonStart.Text = "Step";
                checkBoxSlowDown.Checked = false;
            }
            else
            {
                buttonStart.Text = "Start";
            }

            Cpu.SteppingMode = checkBox1.Checked;
        }
        
        private void checkBoxSlowDown_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            
            if (cb.Checked)
            {
                checkBox1.Checked = false;
            }

            Cpu.SlowDown = cb.Checked;
        }

        private void richTextBoxMem_VScroll(object sender, EventArgs e)
        {
            Point pt = new Point();

            SendMessage(richTextBoxMem.Handle, EM_GETSCROLLPOS, 0, ref pt);

            SendMessage(richTextBoxLineNum.Handle, EM_SETSCROLLPOS, 0, ref pt);
        }

        private void richTextBoxLineNum_VScroll(object sender, EventArgs e)
        {
            Point pt = new Point();

            SendMessage(richTextBoxLineNum.Handle, EM_GETSCROLLPOS, 0, ref pt);

            SendMessage(richTextBoxMem.Handle, EM_SETSCROLLPOS, 0, ref pt);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor fe = new FormEditor(Cpu);
            fe.ShowDialog();
        }

        private bool FormExists(string tagname)
        {
            bool ret = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Tag != null && form.Tag.ToString().ToUpper() == tagname.ToUpper())
                {
                    ret = true;
                }
            }

            return ret;
        }

        private void stackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormExists("stack"))
            {
                MWFstack = new MemoryWatchForm(0x100, 0x1FF, this.Cpu)
                {
                    Text = "Stack-Watch",
                    Tag = "stack"
                };

            }

            MWFstack.Show();
        }

        private void zeropageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormExists("zeropage"))
            {
                MWFzeropage = new MemoryWatchForm(0x0, 0x0FF, this.Cpu)
                {
                    Text = "ZeroPage-Watch",
                    Tag = "zeropage"
                };

            }

            MWFzeropage.Show();
        }
    }

    
}
