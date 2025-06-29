using Bulb;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace CPU_emulator
{
    public partial class CPU_emu : Form
    {
        CPU Cpu;

        System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        private delegate void CpuEventCallback(object sender, CPUEventArgs e);
        private delegate void PropertyChangedEventCallback(object sender, PropertyChangedEventArgs e);

        private MemoryWatchForm MWFstack, MWFzeropage, MWFmemrange = null;

        private ConfigSettings config = new ConfigSettings();
        private string _configFilePath = Application.StartupPath + Path.DirectorySeparatorChar + "Data" + Path.DirectorySeparatorChar + "config.json";

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

            // config.OnPropertyChanged gets initialized @ CPU_emu_Load() due to race conditions

        }

        private void Config_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                PropertyChangedEventCallback cb = new PropertyChangedEventCallback(Config_OnPropertyChanged);
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                SetStatusStripLabels();
                SetMenuLabels();
            }
            
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
                this.Invoke(cb, new object[] { sender, e });
            }
            else
            {
                textBoxPC.Text = e.PC.ToString("X4");
                textBoxInstruction.Text = e.Memory[e.PC].ToString("X2");

                sevenSegmentPC.Value = e.PC.ToString("X4");
                sevenSegmentPCvalue.Value = e.Memory[e.PC].ToString("X2");
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
                sevenSegmentSP.Value = e.SP.ToString("X4");

                textBoxStackValue.Text = e.Memory[e.SP].ToString("X2");
                sevenSegmentSPvalue.Value = e.Memory[e.SP].ToString("X2");
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
                sevenSegmentRegA.Value = e.A.ToString("X2");

                textBoxRegX.Text = e.X.ToString("X2"); 
                sevenSegmentRegX.Value = e.X.ToString("X2");

                textBoxRegY.Text = e.Y.ToString("X2"); 
                sevenSegmentRegY.Value = e.Y.ToString("X2");
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

            foreach (Control c in groupBoxLedFlags.Controls)
            {
                if (c.GetType() == typeof(LedBulb))
                {
                    LedBulb lb = c as LedBulb;
                    lb.On = flags[lb.Tag.ToString()];
                }
            }

        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (!checkBoxSlowDown.Checked)
            {
                stopwatch.Reset();
                stopwatch.Start();
            }
            Cpu.Start();
        }
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            SetToolStripElapsedTime();
            Cpu.Stop();
        }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Cpu.Reset();
            stopwatch.Reset();
            SetToolStripElapsedTime(true);
            toolStripStatusLabelBRK.Text = string.Empty;
        }
        private void CheckBoxStepping_CheckedChanged(object sender, EventArgs e) //StepMode
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
        private void CheckBoxSlowDown_CheckedChanged(object sender, EventArgs e)
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

        private enum DisplayStyle { TXT,LED};

        #region File Menu

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItemOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Title = "Load Program from file";
            openFileDialog.DefaultExt = "hex";
            openFileDialog.Filter = "Hex files (*.hex)|*.hex|All files (*.*)|*.*";

            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string byteString = File.ReadAllText(filename);
                string[] bytes = byteString.Split(' ');
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = bytes.Length;
                toolStripProgressBar1.Visible = true;


                for (int i = 0; i < bytes.Length; i++)
                {
                    int b = Convert.ToInt32(bytes[i], 16);
                    Cpu.WriteByteToMemory((byte)b, (ushort)(config.ProgramStartAdress + i));
                    toolStripProgressBar1.Increment(1);
                }

                toolStripProgressBar1.Visible=false;

                
            }
        }

        private void ToolStripMenuItemSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Application.StartupPath.ToString();
            saveFileDialog.Title = "Save Program to File";
            saveFileDialog.DefaultExt = "hex";
            saveFileDialog.Filter = "Hex files (*.hex)|*.hex|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                string byteString = BitConverter.ToString(Cpu.ReadMemory(), 0x200, 0x200);
                byteString = byteString.Replace("-", " ");
                                
                File.WriteAllText(filename, byteString);
            }
        }

        private void ToolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            Form PropertyForm = new FormConfigSettings(ref config);
            PropertyForm.StartPosition = FormStartPosition.CenterParent;

            PropertyForm.ShowDialog();

        }
        #endregion

        #region Memory Menu

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor fe = new FormEditor(Cpu);
            fe.ShowDialog();
        }

        private void DumpToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Title = "Save Memorydump to File";
            saveFileDialog.DefaultExt = "dmp";
            saveFileDialog.Filter = "Dump files (*.dmp)|*.dmp|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveMemoryToFile(saveFileDialog.FileName);
            }
        }

        private void SaveMemoryToFile(string fileName)
        {
            FileStream fs = null;
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = 64;
            toolStripProgressBar1.Visible = true;
            
            UseWaitCursor = true;

            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Write(Cpu.Memory, 0, Cpu.Memory.Length);
                fs.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n---\n" , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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


        private void LoadFromDumpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Title = "Load Memorydump from file";
            openFileDialog.DefaultExt = "dmp";
            openFileDialog.Filter = "Dump files (*.dmp)|*.dmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadMemoryFromFile(openFileDialog.FileName);
            }
        }

        private void loadKernalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Title = "Load Kernal File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadMemoryFromFile(openFileDialog.FileName,config.KernalStartAdress);
            }
        }

        private void loadCharRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Title = "Load Character ROM";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadMemoryFromFile(openFileDialog.FileName, config.CharRomStartAddress);
            }
        }

        private void loadBasicRomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Title = "Load Basic ROM";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadMemoryFromFile(openFileDialog.FileName, config.BasicStartAddress);
            }
        }
        private void LoadMemoryFromFile(string fileName)
        {
            LoadMemoryFromFile(fileName, 0);
        }

        private void LoadMemoryFromFile(string fileName,int insertIndex)
        {
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = 64;
            toolStripProgressBar1.Visible = true;
            UseWaitCursor = true;

            FileStream fs = null;
            byte[] mem, tmpCpuMem = null;

            try
            {
                fs = File.OpenRead(fileName);
                //Debug.Print(fs.Length.ToString());
                //Debug.Print(Cpu.Memory.Length.ToString());
                if (fs.Length <= Cpu.Memory.Length)
                {
                    mem = new byte[fs.Length];
                    tmpCpuMem = new byte[Cpu.Memory.Length];
                    tmpCpuMem = Cpu.Memory;

                    fs.Read(mem, 0, (int)fs.Length);
                    fs.Close();
                    
                    Array.Copy(mem,0,tmpCpuMem,insertIndex,mem.Length);

                    // have to set Cpu.Memory this way, to get the update memory event triggered
                    Cpu.Memory = tmpCpuMem;
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
            catch (Exception e)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new FormSetAddress(ref Cpu);
            f.ShowDialog();
        }

        private void EraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure you want to clear memory?";
            if (MessageBox.Show(msg, "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cpu.ResetMemory();
            }
        }


        #endregion

        #region Watch-Menu 
        private void StackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormExists("stack"))
            {
                MWFstack = new MemoryWatchForm(0x100, 0x1FF, this.Cpu)
                {
                    Text = "Stack",
                    Tag = "stack"
                };

            }

            MWFstack.LocationChanged += MWFstack_LocationChanged;
            MWFstack.Location = config.MwfStackLocation;
            MWFstack.Show();
            this.Focus();
        }

        private void MWFstack_LocationChanged(object sender, EventArgs e)
        {
            Form f = sender as Form;
            config.MwfStackLocation = f.Location;
        }

        private void ZeropageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormExists("zeropage"))
            {
                MWFzeropage = new MemoryWatchForm(0x0, 0x0FF, this.Cpu)
                {
                    Text = "ZeroPage",
                    Tag = "zeropage"
                };

            }

            MWFzeropage.LocationChanged += MWFzeropage_LocationChanged;
            MWFzeropage.Location = config.MwfZeropageLocation;
            MWFzeropage.Show();
            this.Focus();
        }

        private void MWFzeropage_LocationChanged(object sender, EventArgs e)
        {
            Form f = sender as Form;
            config.MwfZeropageLocation = f.Location;
        }

        private void MemrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormExists("memrange"))
            {
                MWFmemrange = new MemoryWatchForm(this.Cpu)
                {
                    Text = "Memory-Range",
                    Tag = "memrange"
                };

            }

            MWFmemrange.LocationChanged += MWFmemrange_LocationChanged;
            MWFmemrange.Location = config.MwfMemoryRangeLocation;
            MWFmemrange.Show();
            this.Focus();
        }

        private void MWFmemrange_LocationChanged(object sender, EventArgs e)
        {
            Form f = sender as Form;
            config.MwfMemoryRangeLocation = f.Location;
        }

        #endregion

        #region Style-Menu
        private void toolStripMenuItemStyleTXT_Click(object sender, EventArgs e)
        {
            toolStripMenuItemStyleLED.Checked = false;
            SetDisplayControlsVisibility(DisplayStyle.TXT);
        }

        private void toolStripMenuItemStyleLED_Click(object sender, EventArgs e)
        {
            toolStripMenuItemStyleTXT.Checked = false;
            SetDisplayControlsVisibility(DisplayStyle.LED);
        }

        private void SetDisplayControlsVisibility(DisplayStyle style)
        {
            switch (style)
            {
                case DisplayStyle.TXT:
                    groupBoxPCSP.Visible = true;
                    groupBoxFlags.Visible = true;
                    groupBoxRegisters.Visible = true;

                    groupBoxLedRegs.Visible = false;
                    groupBoxLedPC.Visible = false;
                    groupBoxLedSP.Visible = false;
                    groupBoxLedFlags.Visible = false;
                    break;
                case DisplayStyle.LED:
                    groupBoxPCSP.Visible = false;
                    groupBoxFlags.Visible = false;
                    groupBoxRegisters.Visible = false;

                    groupBoxLedRegs.Visible = true;
                    groupBoxLedPC.Visible = true;
                    groupBoxLedSP.Visible = true;
                    groupBoxLedFlags.Visible = true;
                    break;
                default:
                    break;
            }
        }

       
        #endregion

        private void CPU_emu_Load(object sender, EventArgs e)
        {
            if (File.Exists(_configFilePath))
            {
                config = JsonConvert.DeserializeObject<ConfigSettings>(File.ReadAllText(_configFilePath));
                ApplyConfigsettings();
            }

            this.Size = new Size(660, 660);

            PositionLedControls();

            ShowMemoryWindows();

            config.OnPropertyChanged += Config_OnPropertyChanged;
        }

        private void ShowMemoryWindows()
        {
            if (config.ShowStackOnStartUP)
            {
                StackToolStripMenuItem_Click(null, EventArgs.Empty);
            }

            if (config.ShowMemoryRangeOnStartUp)
            {
                MemrangeToolStripMenuItem_Click(null, EventArgs.Empty);
            }

            if (config.ShowZeroPageOnstartUp)
            {
                ZeropageToolStripMenuItem_Click(null, EventArgs.Empty);
            }
        }

        private void PositionLedControls()
        {
            groupBoxLedRegs.Parent = panelMain;
            groupBoxLedRegs.Location = new Point(3, 15);
            groupBoxLedRegs.BringToFront();

            groupBoxLedPC.Parent = panelMain;
            groupBoxLedPC.Location = new Point(3, 170);

            groupBoxLedSP.Parent = panelMain;
            groupBoxLedSP.Location = new Point(3, 325);

            groupBoxLedFlags.Parent = panelMain;
            groupBoxLedFlags.Location = new Point(374, 251);
        }

        private void CPU_emu_LocationChanged(object sender, EventArgs e)
        {
            Form f = sender as Form;
            config.MainFormLocation = f.Location;
        }
                
        private void ApplyConfigsettings()
        {
            this.Location = config.MainFormLocation;
            checkBoxSlowDown.Checked = config.Slow;
            checkBoxStepping.Checked = config.Stepping;
            SetStatusStripLabels();
            SetMenuLabels();
        }

        private void SetStatusStripLabels()
        {
            toolStripStatusLabelKernal.Text = "0x" + config.KernalStartAdress.ToString("X");
            toolStripStatusLabelBasic.Text = "0x" + config.BasicStartAddress.ToString("X");
        }

        private void SetMenuLabels()
        {
            loadKernalToolStripMenuItem.Text = "load Kernal ROM 0x" + config.KernalStartAdress.ToString("X");
            loadCharRomToolStripMenuItem.Text = "load Character ROM 0x" + config.CharRomStartAddress.ToString("X");
            loadBasicRomToolStripMenuItem.Text= "load Basic ROM 0x" + config.BasicStartAddress.ToString("X");
        }

        private void CPU_emu_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(_configFilePath, JsonConvert.SerializeObject(config));
        }

    }


}
