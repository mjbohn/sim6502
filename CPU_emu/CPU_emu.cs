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
    public partial class CPU_emu : Form
    {
        CPU Cpu ;

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
            
            Cpu.Reset();
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
                byte[] Data = Cpu.ReadMemory();
                FillRichTextBox(Data);
            }
            
        }

        private void FillRichTextBox(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                if (i == 0)
                {
                    sb.Append("<" + i.ToString("X4") + "> ");
                }
                if ((i % 16) == 0 && i > 0)
                {
                    sb.Append("\n" + "<" + i.ToString("X4") + "> ");
                }
                                
                sb.Append(data[i].ToString("X2") + " | ");
            }

            richTextBox1.Text = sb.ToString();
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
            Cpu.Reset();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Text = "Step";
            }
            else
            {
                button1.Text = "Start";
            }

            Cpu.SteppingMode = checkBox1.Checked;
        }
    }

    public static class FormInvokeExtension
    {
        static public void UIThreadAsync(this Control control, Action code)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(code);
                return;
            }
            code.Invoke();
        }

        static public void UIThreadSync(this Control control, Action code)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(code);
                return;
            }
            code.Invoke();
        }
    }
}
