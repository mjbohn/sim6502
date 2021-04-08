﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
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
    

        #region File Menu
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemOpenFile_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemSaveFile_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region Memory Menu

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor fe = new FormEditor(Cpu);
            fe.ShowDialog();
        }

        private void dumpToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.Title = "Save Memory";
            saveFileDialog1.DefaultExt = "hex";
            saveFileDialog1.Filter = "Hex files (*.hex)|*.hex|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveMemoryToFile(saveFileDialog1.FileName);
            }
        }

        private void SaveMemoryToFile(string fileName)
        {
            FileStream fs= null;
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = 64;
            toolStripProgressBar1.Visible = true;
            StreamWriter sw = new StreamWriter(fileName);

            UseWaitCursor = true;

            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(Cpu.Memory, 0, Cpu.Memory.Length);
                fs.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n---\n" + e.InnerException.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UseWaitCursor = false;
                throw;
                throw;
            }
            finally
            {
                fs.Dispose();
                UseWaitCursor = false;
                toolStripProgressBar1.Visible = false;
            }
        }

        
        private void loadFromDumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Title = "Load Memordump from file";
            openFileDialog1.DefaultExt = "hex";
            openFileDialog1.Filter = "Hex files (*.hex)|*.hex|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadMemoryFromFile(openFileDialog1.FileName);
            }
        }

        private void LoadMemoryFromFile(string fileName)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = 64;
            toolStripProgressBar1.Visible = true;
            UseWaitCursor = true;

            FileStream fs = null;
            byte[] mem = null;

            try
            {
                fs = File.OpenRead(fileName);
                Debug.Print(fs.Length.ToString());
                Debug.Print(Cpu.Memory.Length.ToString());
                if (fs.Length <= Cpu.Memory.Length)
                {
                    mem = new byte[fs.Length];
                    fs.Read(mem, 0, (int)fs.Length);
                    fs.Close();
                    Cpu.Memory = mem;
                }
                else
                {
                    StringBuilder ErrorMessage = new StringBuilder();
                    ErrorMessage.AppendLine("File is too large");
                    ErrorMessage.AppendLine("File has " + fs.Length.ToString() + "bytes.");
                    ErrorMessage.AppendLine("Max allowed size is  " + Cpu.Memory.Length.ToString() + " bytes.");

                    MessageBox.Show(ErrorMessage.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception  e)
            {
                MessageBox.Show(e.Message + "\n---\n" + e.InnerException.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UseWaitCursor = false;
                throw;
            }
            finally
            {
                fs.Dispose();
                UseWaitCursor = false;
                toolStripProgressBar1.Visible = false;
            }

           

        }

        private void eraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure you want to clear memory?";
            if (MessageBox.Show(msg,"Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes )
            {
                Cpu.ResetMemory();
            }           
        }


        #endregion

        #region Watch-Menu 
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

            MWFstack.LocationChanged += MWFstack_LocationChanged;
            MWFstack.Location = config.MwfStackLocation;
            MWFstack.Show();
            MWFstack.Focus();
        }

        private void MWFstack_LocationChanged(object sender, EventArgs e)
        {
            Form f = sender as Form;
            config.MwfStackLocation = f.Location;
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

            MWFzeropage.LocationChanged += MWFzeropage_LocationChanged;
            MWFzeropage.Location = config.MwfZeropageLocation;
            MWFzeropage.Show();
            MWFzeropage.Focus();
        }

        private void MWFzeropage_LocationChanged(object sender, EventArgs e)
        {
            Form f = sender as Form;
            config.MwfZeropageLocation = f.Location;
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

            MWFmemrange.LocationChanged += MWFmemrange_LocationChanged;
            MWFmemrange.Location = config.MwfMemoryRangeLocation;
            MWFmemrange.Show();
            MWFmemrange.Focus();
        }

        private void MWFmemrange_LocationChanged(object sender, EventArgs e)
        {
            Form f = sender as Form;
            config.MwfMemoryRangeLocation = f.Location;
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
