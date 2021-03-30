using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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

        private delegate void CpuEventCallback(object sender, CPUEventArgs e);

        private MemoryWatchForm MWFstack, MWFzeropage, MWFmemrange = null;

        private ConfigSettings config = new ConfigSettings();

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



        #region CpuEventHandling
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

        #endregion


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

        private void checkBoxStepping_CheckedChanged(object sender, EventArgs e) //StepMode
        {
            if (checkBoxStepping.Checked)
            {
                buttonStart.Text = "Step";
                checkBoxSlowDown.Checked = false;
            }
            else
            {
                buttonStart.Text = "Start";
            }

            Cpu.SteppingMode = checkBoxStepping.Checked;
            config.Stepping = checkBoxStepping.Checked;
        }


        
        private void checkBoxSlowDown_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            
            if (cb.Checked)
            {
                checkBoxStepping.Checked = false;
            }

            Cpu.SlowDown = cb.Checked;
            config.Slow = cb.Checked;
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

        #region Watch-Menu Dropdown
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
            MWFstack.Focus();
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
            MWFzeropage.Focus();
        }
        private void memrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormExists("memrange"))
            {
                MWFmemrange = new MemoryWatchForm(this.Cpu)
                {
                    Text = "MemoryRange-Watch",
                    Tag = "memrange"
                };

            }

            MWFmemrange.Show();
            MWFmemrange.Focus();
        }


        #endregion


        private void CPU_emu_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + Path.DirectorySeparatorChar + "config.json"))
            {
                config = JsonConvert.DeserializeObject<ConfigSettings>(File.ReadAllText(Application.StartupPath + Path.DirectorySeparatorChar + "config.json"));
                ApplyConfigsettings();
            }
        }

        private void ApplyConfigsettings()
        {
            checkBoxSlowDown.Checked = config.Slow;
            checkBoxStepping.Checked = config.Stepping;
        }

        private void CPU_emu_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(Application.StartupPath + Path.DirectorySeparatorChar + "config.json", JsonConvert.SerializeObject(config));
        }

    }


}
