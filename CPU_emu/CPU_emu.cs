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

        [DllImport("User32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Point lParam);


        private delegate void CpuEventCallback(object sender, EventArgs e);

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
                toolStripStatusLabelBRK.Text = "BRK";
                toolStripStatusLabelBRK.ForeColor = Color.Red;
            }
            
        }

        private void Cpu_OnPCgtThenMaxMem(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Cpu_OnRefreshGraphics(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Cpu_OnProgramCounterUpdate(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnProgramCounterUpdate);
                this.Invoke(cb,new object[] {sender ,e });
            }
            else
            {
                textBoxPC.Text = Cpu.PC.ToString("X4");
                FillRichTextBox(Cpu.ReadMemory());
            }
                        
        }

        private void Cpu_OnStackPointerUpdate(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnStackPointerUpdate);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                textBoxSP.Text = Cpu.SP.ToString("X4");
                FillRichTextBox(Cpu.ReadMemory());
            }
            
        }

        private void Cpu_OnRegisterUpdate(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnRegisterUpdate);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                textBoxRegA.Text = Cpu.A.ToString("X2");
                textBoxRegX.Text = Cpu.X.ToString("X2");
                textBoxRegY.Text = Cpu.Y.ToString("X2");
                //textBoxRegA.Refresh();
            }
            
        }

        private void Cpu_OnMemoryUpdate(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_OnMemoryUpdate);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                FillRichTextBox(Cpu.ReadMemory());
            }
            
        }

        private void FillRichTextBox(byte[] data)
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

        private void Cpu_onFlagsUpdate(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                CpuEventCallback cb = new CpuEventCallback(Cpu_onFlagsUpdate);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                GetCpuFlags();
            }
                       
        }

        private void GetCpuFlags()
        {
            foreach (CheckBox checkBox in groupBoxFlags.Controls)
            {
                checkBox.Checked = Cpu.flags[checkBox.Tag.ToString()];
            }

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cpu.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cpu.Stop(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SetCpuInitialPC();
            Cpu.Reset();
            toolStripStatusLabelBRK.Text = string.Empty;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //StepMode
        {
            if (checkBox1.Checked)
            {
                button1.Text = "Step";
                checkBoxSlowDown.Checked = false;
            }
            else
            {
                button1.Text = "Start";
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
    }

    //public static class FormInvokeExtension
    //{
    //    static public void UIThreadAsync(this Control control, Action code)
    //    {
    //        if (control.InvokeRequired)
    //        {
    //            control.BeginInvoke(code);
    //            return;
    //        }
    //        code.Invoke();
    //    }

    //    static public void UIThreadSync(this Control control, Action code)
    //    {
    //        if (control.InvokeRequired)
    //        {
    //            control.Invoke(code);
    //            return;
    //        }
    //        code.Invoke();
    //    }
    //}
}
