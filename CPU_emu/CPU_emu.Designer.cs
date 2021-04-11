
namespace CPU_emulator
{
    partial class CPU_emu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPU_emu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dumpToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.eraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeropageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStyleTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStyleLED = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxCarryFlag = new System.Windows.Forms.CheckBox();
            this.groupBoxFlags = new System.Windows.Forms.GroupBox();
            this.checkBoxNegativFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxOverflowFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxDecimalModeFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxIntDisableFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxZeroFlag = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxRegisters = new System.Windows.Forms.GroupBox();
            this.textBoxRegY = new System.Windows.Forms.TextBox();
            this.labelRegY = new System.Windows.Forms.Label();
            this.textBoxRegX = new System.Windows.Forms.TextBox();
            this.labelRegX = new System.Windows.Forms.Label();
            this.textBoxRegA = new System.Windows.Forms.TextBox();
            this.labelRegA = new System.Windows.Forms.Label();
            this.groupBoxPCSP = new System.Windows.Forms.GroupBox();
            this.textBoxStackValue = new System.Windows.Forms.TextBox();
            this.textBoxInstruction = new System.Windows.Forms.TextBox();
            this.textBoxSP = new System.Windows.Forms.TextBox();
            this.labelSP = new System.Windows.Forms.Label();
            this.textBoxPC = new System.Windows.Forms.TextBox();
            this.labelPC = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxStepping = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelBRK = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.checkBoxSlowDown = new System.Windows.Forms.CheckBox();
            this.groupBoxStartStop = new System.Windows.Forms.GroupBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxLedPC = new System.Windows.Forms.GroupBox();
            this.sevenSegmentPC = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenSegmentPCvalue = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.groupBoxLedRegs = new System.Windows.Forms.GroupBox();
            this.groupBoxRegY = new System.Windows.Forms.GroupBox();
            this.sevenSegmentRegY = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.groupRegA = new System.Windows.Forms.GroupBox();
            this.sevenSegmentRegA = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.groupBoxRegX = new System.Windows.Forms.GroupBox();
            this.sevenSegmentRegX = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenSegmentArray1 = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenSegment1 = new DmitryBrant.CustomControls.SevenSegment();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxLedSP = new System.Windows.Forms.GroupBox();
            this.sevenSegmentSP = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.sevenSegmentSPvalue = new DmitryBrant.CustomControls.SevenSegmentArray();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFlags.SuspendLayout();
            this.groupBoxRegisters.SuspendLayout();
            this.groupBoxPCSP.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxStartStop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBoxLedPC.SuspendLayout();
            this.groupBoxLedRegs.SuspendLayout();
            this.groupBoxRegY.SuspendLayout();
            this.groupRegA.SuspendLayout();
            this.groupBoxRegX.SuspendLayout();
            this.groupBoxLedSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.memoryToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.styleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpenFile,
            this.toolStripMenuItemSaveFile,
            this.toolStripSeparator1,
            this.ToolStripMenuItemClose,
            this.toolStripSeparator4,
            this.toolStripMenuItemSettings});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dateiToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItemOpenFile
            // 
            this.toolStripMenuItemOpenFile.Enabled = false;
            this.toolStripMenuItemOpenFile.Name = "toolStripMenuItemOpenFile";
            this.toolStripMenuItemOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItemOpenFile.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemOpenFile.Text = "open program";
            this.toolStripMenuItemOpenFile.ToolTipText = "Load program from file";
            this.toolStripMenuItemOpenFile.Click += new System.EventHandler(this.ToolStripMenuItemOpenFile_Click);
            // 
            // toolStripMenuItemSaveFile
            // 
            this.toolStripMenuItemSaveFile.Enabled = false;
            this.toolStripMenuItemSaveFile.Name = "toolStripMenuItemSaveFile";
            this.toolStripMenuItemSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemSaveFile.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemSaveFile.Text = "save program";
            this.toolStripMenuItemSaveFile.ToolTipText = "Save program to file";
            this.toolStripMenuItemSaveFile.Click += new System.EventHandler(this.ToolStripMenuItemSaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(195, 22);
            this.ToolStripMenuItemClose.Text = "&Close";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItemSettings.Text = "&Settings";
            this.toolStripMenuItemSettings.Click += new System.EventHandler(this.ToolStripMenuItemSettings_Click);
            // 
            // memoryToolStripMenuItem
            // 
            this.memoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripSeparator2,
            this.dumpToFileToolStripMenuItem,
            this.loadFromDumpToolStripMenuItem,
            this.toolStripSeparator3,
            this.eraseToolStripMenuItem});
            this.memoryToolStripMenuItem.Name = "memoryToolStripMenuItem";
            this.memoryToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.memoryToolStripMenuItem.Text = "&Memory";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // dumpToFileToolStripMenuItem
            // 
            this.dumpToFileToolStripMenuItem.Name = "dumpToFileToolStripMenuItem";
            this.dumpToFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.dumpToFileToolStripMenuItem.Text = "dump to file";
            this.dumpToFileToolStripMenuItem.ToolTipText = "Dump whole memory to file";
            this.dumpToFileToolStripMenuItem.Click += new System.EventHandler(this.DumpToFileToolStripMenuItem_Click);
            // 
            // loadFromDumpToolStripMenuItem
            // 
            this.loadFromDumpToolStripMenuItem.Name = "loadFromDumpToolStripMenuItem";
            this.loadFromDumpToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.loadFromDumpToolStripMenuItem.Text = "load from dump";
            this.loadFromDumpToolStripMenuItem.ToolTipText = "Load dumpfile into memory";
            this.loadFromDumpToolStripMenuItem.Click += new System.EventHandler(this.LoadFromDumpToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // eraseToolStripMenuItem
            // 
            this.eraseToolStripMenuItem.Name = "eraseToolStripMenuItem";
            this.eraseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.eraseToolStripMenuItem.Text = "erase";
            this.eraseToolStripMenuItem.Click += new System.EventHandler(this.EraseToolStripMenuItem_Click);
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stackToolStripMenuItem,
            this.zeropageToolStripMenuItem,
            this.memrangeToolStripMenuItem});
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.watchToolStripMenuItem.Text = "&Watch";
            // 
            // stackToolStripMenuItem
            // 
            this.stackToolStripMenuItem.Name = "stackToolStripMenuItem";
            this.stackToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.stackToolStripMenuItem.Text = "Stack";
            this.stackToolStripMenuItem.Click += new System.EventHandler(this.StackToolStripMenuItem_Click);
            // 
            // zeropageToolStripMenuItem
            // 
            this.zeropageToolStripMenuItem.Name = "zeropageToolStripMenuItem";
            this.zeropageToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zeropageToolStripMenuItem.Text = "Zeropage";
            this.zeropageToolStripMenuItem.Click += new System.EventHandler(this.ZeropageToolStripMenuItem_Click);
            // 
            // memrangeToolStripMenuItem
            // 
            this.memrangeToolStripMenuItem.Name = "memrangeToolStripMenuItem";
            this.memrangeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.memrangeToolStripMenuItem.Text = "Memory Range";
            this.memrangeToolStripMenuItem.Click += new System.EventHandler(this.MemrangeToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStyleTXT,
            this.toolStripMenuItemStyleLED});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.styleToolStripMenuItem.Text = "&Style";
            // 
            // toolStripMenuItemStyleTXT
            // 
            this.toolStripMenuItemStyleTXT.Checked = true;
            this.toolStripMenuItemStyleTXT.CheckOnClick = true;
            this.toolStripMenuItemStyleTXT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemStyleTXT.Name = "toolStripMenuItemStyleTXT";
            this.toolStripMenuItemStyleTXT.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItemStyleTXT.Text = "TXT";
            this.toolStripMenuItemStyleTXT.Click += new System.EventHandler(this.toolStripMenuItemStyleTXT_Click);
            // 
            // toolStripMenuItemStyleLED
            // 
            this.toolStripMenuItemStyleLED.CheckOnClick = true;
            this.toolStripMenuItemStyleLED.Name = "toolStripMenuItemStyleLED";
            this.toolStripMenuItemStyleLED.Size = new System.Drawing.Size(94, 22);
            this.toolStripMenuItemStyleLED.Text = "LED";
            this.toolStripMenuItemStyleLED.Click += new System.EventHandler(this.toolStripMenuItemStyleLED_Click);
            // 
            // checkBoxCarryFlag
            // 
            this.checkBoxCarryFlag.AutoCheck = false;
            this.checkBoxCarryFlag.AutoSize = true;
            this.checkBoxCarryFlag.Checked = true;
            this.checkBoxCarryFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCarryFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarryFlag.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCarryFlag.Name = "checkBoxCarryFlag";
            this.checkBoxCarryFlag.Size = new System.Drawing.Size(99, 20);
            this.checkBoxCarryFlag.TabIndex = 1;
            this.checkBoxCarryFlag.Tag = "C";
            this.checkBoxCarryFlag.Text = "Carry [C]";
            this.checkBoxCarryFlag.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlags
            // 
            this.groupBoxFlags.Controls.Add(this.checkBoxNegativFlag);
            this.groupBoxFlags.Controls.Add(this.checkBoxOverflowFlag);
            this.groupBoxFlags.Controls.Add(this.checkBoxBreakFlag);
            this.groupBoxFlags.Controls.Add(this.checkBoxDecimalModeFlag);
            this.groupBoxFlags.Controls.Add(this.checkBoxIntDisableFlag);
            this.groupBoxFlags.Controls.Add(this.checkBoxZeroFlag);
            this.groupBoxFlags.Controls.Add(this.checkBoxCarryFlag);
            this.groupBoxFlags.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFlags.Location = new System.Drawing.Point(12, 13);
            this.groupBoxFlags.Name = "groupBoxFlags";
            this.groupBoxFlags.Size = new System.Drawing.Size(162, 223);
            this.groupBoxFlags.TabIndex = 2;
            this.groupBoxFlags.TabStop = false;
            this.groupBoxFlags.Text = "Flags";
            // 
            // checkBoxNegativFlag
            // 
            this.checkBoxNegativFlag.AutoCheck = false;
            this.checkBoxNegativFlag.AutoSize = true;
            this.checkBoxNegativFlag.Checked = true;
            this.checkBoxNegativFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNegativFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNegativFlag.Location = new System.Drawing.Point(6, 175);
            this.checkBoxNegativFlag.Name = "checkBoxNegativFlag";
            this.checkBoxNegativFlag.Size = new System.Drawing.Size(123, 20);
            this.checkBoxNegativFlag.TabIndex = 7;
            this.checkBoxNegativFlag.Tag = "N";
            this.checkBoxNegativFlag.Text = "Negativ  [N]";
            this.checkBoxNegativFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverflowFlag
            // 
            this.checkBoxOverflowFlag.AutoCheck = false;
            this.checkBoxOverflowFlag.AutoSize = true;
            this.checkBoxOverflowFlag.Checked = true;
            this.checkBoxOverflowFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOverflowFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOverflowFlag.Location = new System.Drawing.Point(6, 149);
            this.checkBoxOverflowFlag.Name = "checkBoxOverflowFlag";
            this.checkBoxOverflowFlag.Size = new System.Drawing.Size(123, 20);
            this.checkBoxOverflowFlag.TabIndex = 6;
            this.checkBoxOverflowFlag.Tag = "V";
            this.checkBoxOverflowFlag.Text = "Overflow [V]";
            this.checkBoxOverflowFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakFlag
            // 
            this.checkBoxBreakFlag.AutoCheck = false;
            this.checkBoxBreakFlag.AutoSize = true;
            this.checkBoxBreakFlag.Checked = true;
            this.checkBoxBreakFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBreakFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBreakFlag.Location = new System.Drawing.Point(6, 123);
            this.checkBoxBreakFlag.Name = "checkBoxBreakFlag";
            this.checkBoxBreakFlag.Size = new System.Drawing.Size(99, 20);
            this.checkBoxBreakFlag.TabIndex = 5;
            this.checkBoxBreakFlag.Tag = "B";
            this.checkBoxBreakFlag.Text = "Break [B]";
            this.checkBoxBreakFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxDecimalModeFlag
            // 
            this.checkBoxDecimalModeFlag.AutoCheck = false;
            this.checkBoxDecimalModeFlag.AutoSize = true;
            this.checkBoxDecimalModeFlag.Checked = true;
            this.checkBoxDecimalModeFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDecimalModeFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDecimalModeFlag.Location = new System.Drawing.Point(6, 97);
            this.checkBoxDecimalModeFlag.Name = "checkBoxDecimalModeFlag";
            this.checkBoxDecimalModeFlag.Size = new System.Drawing.Size(147, 20);
            this.checkBoxDecimalModeFlag.TabIndex = 4;
            this.checkBoxDecimalModeFlag.Tag = "D";
            this.checkBoxDecimalModeFlag.Text = "DecimalMode [D]";
            this.checkBoxDecimalModeFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxIntDisableFlag
            // 
            this.checkBoxIntDisableFlag.AutoCheck = false;
            this.checkBoxIntDisableFlag.AutoSize = true;
            this.checkBoxIntDisableFlag.Checked = true;
            this.checkBoxIntDisableFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIntDisableFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIntDisableFlag.Location = new System.Drawing.Point(6, 71);
            this.checkBoxIntDisableFlag.Name = "checkBoxIntDisableFlag";
            this.checkBoxIntDisableFlag.Size = new System.Drawing.Size(147, 20);
            this.checkBoxIntDisableFlag.TabIndex = 3;
            this.checkBoxIntDisableFlag.Tag = "I";
            this.checkBoxIntDisableFlag.Text = "intDisable  [I]";
            this.checkBoxIntDisableFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxZeroFlag
            // 
            this.checkBoxZeroFlag.AutoCheck = false;
            this.checkBoxZeroFlag.AutoSize = true;
            this.checkBoxZeroFlag.Checked = true;
            this.checkBoxZeroFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxZeroFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxZeroFlag.Location = new System.Drawing.Point(6, 45);
            this.checkBoxZeroFlag.Name = "checkBoxZeroFlag";
            this.checkBoxZeroFlag.Size = new System.Drawing.Size(99, 20);
            this.checkBoxZeroFlag.TabIndex = 2;
            this.checkBoxZeroFlag.Tag = "Z";
            this.checkBoxZeroFlag.Text = "Zero  [Z]";
            this.checkBoxZeroFlag.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(6, 23);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(158, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.TabStop = false;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // groupBoxRegisters
            // 
            this.groupBoxRegisters.Controls.Add(this.textBoxRegY);
            this.groupBoxRegisters.Controls.Add(this.labelRegY);
            this.groupBoxRegisters.Controls.Add(this.textBoxRegX);
            this.groupBoxRegisters.Controls.Add(this.labelRegX);
            this.groupBoxRegisters.Controls.Add(this.textBoxRegA);
            this.groupBoxRegisters.Controls.Add(this.labelRegA);
            this.groupBoxRegisters.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegisters.Location = new System.Drawing.Point(180, 13);
            this.groupBoxRegisters.Name = "groupBoxRegisters";
            this.groupBoxRegisters.Size = new System.Drawing.Size(135, 117);
            this.groupBoxRegisters.TabIndex = 6;
            this.groupBoxRegisters.TabStop = false;
            this.groupBoxRegisters.Text = "Registers";
            // 
            // textBoxRegY
            // 
            this.textBoxRegY.Location = new System.Drawing.Point(38, 78);
            this.textBoxRegY.Name = "textBoxRegY";
            this.textBoxRegY.ReadOnly = true;
            this.textBoxRegY.Size = new System.Drawing.Size(58, 23);
            this.textBoxRegY.TabIndex = 5;
            this.textBoxRegY.Text = "FF";
            this.textBoxRegY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegY
            // 
            this.labelRegY.AutoSize = true;
            this.labelRegY.Location = new System.Drawing.Point(6, 81);
            this.labelRegY.Name = "labelRegY";
            this.labelRegY.Size = new System.Drawing.Size(18, 16);
            this.labelRegY.TabIndex = 4;
            this.labelRegY.Text = "Y";
            this.labelRegY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegX
            // 
            this.textBoxRegX.Location = new System.Drawing.Point(38, 49);
            this.textBoxRegX.Name = "textBoxRegX";
            this.textBoxRegX.ReadOnly = true;
            this.textBoxRegX.Size = new System.Drawing.Size(58, 23);
            this.textBoxRegX.TabIndex = 3;
            this.textBoxRegX.Text = "FF";
            this.textBoxRegX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegX
            // 
            this.labelRegX.AutoSize = true;
            this.labelRegX.Location = new System.Drawing.Point(6, 52);
            this.labelRegX.Name = "labelRegX";
            this.labelRegX.Size = new System.Drawing.Size(17, 16);
            this.labelRegX.TabIndex = 2;
            this.labelRegX.Text = "X";
            this.labelRegX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegA
            // 
            this.textBoxRegA.Location = new System.Drawing.Point(38, 20);
            this.textBoxRegA.Name = "textBoxRegA";
            this.textBoxRegA.ReadOnly = true;
            this.textBoxRegA.Size = new System.Drawing.Size(58, 23);
            this.textBoxRegA.TabIndex = 1;
            this.textBoxRegA.Text = "FF";
            this.textBoxRegA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegA
            // 
            this.labelRegA.AutoSize = true;
            this.labelRegA.Location = new System.Drawing.Point(6, 23);
            this.labelRegA.Name = "labelRegA";
            this.labelRegA.Size = new System.Drawing.Size(17, 16);
            this.labelRegA.TabIndex = 0;
            this.labelRegA.Text = "A";
            this.labelRegA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxPCSP
            // 
            this.groupBoxPCSP.Controls.Add(this.textBoxStackValue);
            this.groupBoxPCSP.Controls.Add(this.textBoxInstruction);
            this.groupBoxPCSP.Controls.Add(this.textBoxSP);
            this.groupBoxPCSP.Controls.Add(this.labelSP);
            this.groupBoxPCSP.Controls.Add(this.textBoxPC);
            this.groupBoxPCSP.Controls.Add(this.labelPC);
            this.groupBoxPCSP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPCSP.Location = new System.Drawing.Point(180, 136);
            this.groupBoxPCSP.Name = "groupBoxPCSP";
            this.groupBoxPCSP.Size = new System.Drawing.Size(135, 165);
            this.groupBoxPCSP.TabIndex = 7;
            this.groupBoxPCSP.TabStop = false;
            // 
            // textBoxStackValue
            // 
            this.textBoxStackValue.Location = new System.Drawing.Point(38, 123);
            this.textBoxStackValue.Name = "textBoxStackValue";
            this.textBoxStackValue.ReadOnly = true;
            this.textBoxStackValue.Size = new System.Drawing.Size(58, 23);
            this.textBoxStackValue.TabIndex = 11;
            this.textBoxStackValue.Text = "FF";
            this.textBoxStackValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInstruction
            // 
            this.textBoxInstruction.Location = new System.Drawing.Point(38, 48);
            this.textBoxInstruction.Name = "textBoxInstruction";
            this.textBoxInstruction.ReadOnly = true;
            this.textBoxInstruction.Size = new System.Drawing.Size(58, 23);
            this.textBoxInstruction.TabIndex = 10;
            this.textBoxInstruction.Text = "FF";
            this.textBoxInstruction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSP
            // 
            this.textBoxSP.Location = new System.Drawing.Point(38, 94);
            this.textBoxSP.Name = "textBoxSP";
            this.textBoxSP.ReadOnly = true;
            this.textBoxSP.Size = new System.Drawing.Size(58, 23);
            this.textBoxSP.TabIndex = 9;
            this.textBoxSP.Text = "FF";
            this.textBoxSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Location = new System.Drawing.Point(5, 110);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(26, 16);
            this.labelSP.TabIndex = 8;
            this.labelSP.Text = "SP";
            this.labelSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPC
            // 
            this.textBoxPC.Location = new System.Drawing.Point(38, 22);
            this.textBoxPC.Name = "textBoxPC";
            this.textBoxPC.ReadOnly = true;
            this.textBoxPC.Size = new System.Drawing.Size(58, 23);
            this.textBoxPC.TabIndex = 7;
            this.textBoxPC.Text = "FF";
            this.textBoxPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPC
            // 
            this.labelPC.AutoSize = true;
            this.labelPC.Location = new System.Drawing.Point(5, 39);
            this.labelPC.Name = "labelPC";
            this.labelPC.Size = new System.Drawing.Size(27, 16);
            this.labelPC.TabIndex = 6;
            this.labelPC.Text = "PC";
            this.labelPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(6, 52);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(158, 23);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(6, 81);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(158, 23);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // checkBoxStepping
            // 
            this.checkBoxStepping.AutoSize = true;
            this.checkBoxStepping.Location = new System.Drawing.Point(6, 118);
            this.checkBoxStepping.Name = "checkBoxStepping";
            this.checkBoxStepping.Size = new System.Drawing.Size(90, 20);
            this.checkBoxStepping.TabIndex = 10;
            this.checkBoxStepping.Text = "Stepping";
            this.checkBoxStepping.UseVisualStyleBackColor = true;
            this.checkBoxStepping.CheckedChanged += new System.EventHandler(this.CheckBoxStepping_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelBRK,
            this.toolStripStatusElapsedTime,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1135, 22);
            this.statusStrip1.TabIndex = 11;
            // 
            // toolStripStatusLabelBRK
            // 
            this.toolStripStatusLabelBRK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelBRK.Name = "toolStripStatusLabelBRK";
            this.toolStripStatusLabelBRK.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusElapsedTime
            // 
            this.toolStripStatusElapsedTime.Name = "toolStripStatusElapsedTime";
            this.toolStripStatusElapsedTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 16);
            this.toolStripProgressBar1.Step = 1;
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar1.Visible = false;
            // 
            // checkBoxSlowDown
            // 
            this.checkBoxSlowDown.AutoSize = true;
            this.checkBoxSlowDown.Location = new System.Drawing.Point(6, 144);
            this.checkBoxSlowDown.Name = "checkBoxSlowDown";
            this.checkBoxSlowDown.Size = new System.Drawing.Size(60, 20);
            this.checkBoxSlowDown.TabIndex = 14;
            this.checkBoxSlowDown.Text = "Slow";
            this.checkBoxSlowDown.UseVisualStyleBackColor = true;
            this.checkBoxSlowDown.CheckedChanged += new System.EventHandler(this.CheckBoxSlowDown_CheckedChanged);
            // 
            // groupBoxStartStop
            // 
            this.groupBoxStartStop.Controls.Add(this.buttonStart);
            this.groupBoxStartStop.Controls.Add(this.buttonStop);
            this.groupBoxStartStop.Controls.Add(this.checkBoxSlowDown);
            this.groupBoxStartStop.Controls.Add(this.buttonReset);
            this.groupBoxStartStop.Controls.Add(this.checkBoxStepping);
            this.groupBoxStartStop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStartStop.Location = new System.Drawing.Point(321, 13);
            this.groupBoxStartStop.Name = "groupBoxStartStop";
            this.groupBoxStartStop.Size = new System.Drawing.Size(169, 223);
            this.groupBoxStartStop.TabIndex = 16;
            this.groupBoxStartStop.TabStop = false;
            this.groupBoxStartStop.Text = "Start/Stop";
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.sevenSegmentArray1);
            this.panelMain.Controls.Add(this.sevenSegment1);
            this.panelMain.Controls.Add(this.groupBoxStartStop);
            this.panelMain.Controls.Add(this.groupBoxFlags);
            this.panelMain.Controls.Add(this.groupBoxRegisters);
            this.panelMain.Controls.Add(this.groupBoxPCSP);
            this.panelMain.Location = new System.Drawing.Point(12, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(530, 478);
            this.panelMain.TabIndex = 16;
            // 
            // groupBoxLedPC
            // 
            this.groupBoxLedPC.Controls.Add(this.sevenSegmentPC);
            this.groupBoxLedPC.Controls.Add(this.sevenSegmentPCvalue);
            this.groupBoxLedPC.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLedPC.Location = new System.Drawing.Point(595, 182);
            this.groupBoxLedPC.Name = "groupBoxLedPC";
            this.groupBoxLedPC.Size = new System.Drawing.Size(270, 135);
            this.groupBoxLedPC.TabIndex = 23;
            this.groupBoxLedPC.TabStop = false;
            this.groupBoxLedPC.Text = "Programcounter";
            this.groupBoxLedPC.Visible = false;
            // 
            // sevenSegmentPC
            // 
            this.sevenSegmentPC.ArrayCount = 4;
            this.sevenSegmentPC.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentPC.ColorDark = System.Drawing.Color.DarkRed;
            this.sevenSegmentPC.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentPC.DecimalShow = true;
            this.sevenSegmentPC.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentPC.ElementWidth = 8;
            this.sevenSegmentPC.ItalicFactor = 0F;
            this.sevenSegmentPC.Location = new System.Drawing.Point(11, 36);
            this.sevenSegmentPC.Name = "sevenSegmentPC";
            this.sevenSegmentPC.Size = new System.Drawing.Size(128, 64);
            this.sevenSegmentPC.TabIndex = 18;
            this.sevenSegmentPC.TabStop = false;
            this.sevenSegmentPC.Value = "0200";
            // 
            // sevenSegmentPCvalue
            // 
            this.sevenSegmentPCvalue.ArrayCount = 2;
            this.sevenSegmentPCvalue.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentPCvalue.ColorDark = System.Drawing.Color.DarkRed;
            this.sevenSegmentPCvalue.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentPCvalue.DecimalShow = true;
            this.sevenSegmentPCvalue.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentPCvalue.ElementWidth = 8;
            this.sevenSegmentPCvalue.ItalicFactor = 0F;
            this.sevenSegmentPCvalue.Location = new System.Drawing.Point(147, 36);
            this.sevenSegmentPCvalue.Name = "sevenSegmentPCvalue";
            this.sevenSegmentPCvalue.Size = new System.Drawing.Size(64, 64);
            this.sevenSegmentPCvalue.TabIndex = 18;
            this.sevenSegmentPCvalue.TabStop = false;
            this.sevenSegmentPCvalue.Value = "55";
            // 
            // groupBoxLedRegs
            // 
            this.groupBoxLedRegs.Controls.Add(this.groupBoxRegY);
            this.groupBoxLedRegs.Controls.Add(this.groupRegA);
            this.groupBoxLedRegs.Controls.Add(this.groupBoxRegX);
            this.groupBoxLedRegs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxLedRegs.Location = new System.Drawing.Point(595, 41);
            this.groupBoxLedRegs.Name = "groupBoxLedRegs";
            this.groupBoxLedRegs.Size = new System.Drawing.Size(270, 135);
            this.groupBoxLedRegs.TabIndex = 22;
            this.groupBoxLedRegs.TabStop = false;
            this.groupBoxLedRegs.Visible = false;
            // 
            // groupBoxRegY
            // 
            this.groupBoxRegY.Controls.Add(this.sevenSegmentRegY);
            this.groupBoxRegY.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegY.Location = new System.Drawing.Point(177, 12);
            this.groupBoxRegY.Name = "groupBoxRegY";
            this.groupBoxRegY.Size = new System.Drawing.Size(88, 117);
            this.groupBoxRegY.TabIndex = 21;
            this.groupBoxRegY.TabStop = false;
            this.groupBoxRegY.Text = "Reg Y";
            // 
            // sevenSegmentRegY
            // 
            this.sevenSegmentRegY.ArrayCount = 2;
            this.sevenSegmentRegY.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentRegY.ColorDark = System.Drawing.Color.DarkRed;
            this.sevenSegmentRegY.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentRegY.DecimalShow = true;
            this.sevenSegmentRegY.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentRegY.ElementWidth = 8;
            this.sevenSegmentRegY.ItalicFactor = 0F;
            this.sevenSegmentRegY.Location = new System.Drawing.Point(6, 32);
            this.sevenSegmentRegY.Name = "sevenSegmentRegY";
            this.sevenSegmentRegY.Size = new System.Drawing.Size(64, 64);
            this.sevenSegmentRegY.TabIndex = 21;
            this.sevenSegmentRegY.TabStop = false;
            this.sevenSegmentRegY.Value = "00";
            // 
            // groupRegA
            // 
            this.groupRegA.Controls.Add(this.sevenSegmentRegA);
            this.groupRegA.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRegA.Location = new System.Drawing.Point(7, 12);
            this.groupRegA.Name = "groupRegA";
            this.groupRegA.Size = new System.Drawing.Size(79, 117);
            this.groupRegA.TabIndex = 19;
            this.groupRegA.TabStop = false;
            this.groupRegA.Text = "Reg A";
            // 
            // sevenSegmentRegA
            // 
            this.sevenSegmentRegA.ArrayCount = 2;
            this.sevenSegmentRegA.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentRegA.ColorDark = System.Drawing.Color.DarkRed;
            this.sevenSegmentRegA.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentRegA.DecimalShow = true;
            this.sevenSegmentRegA.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentRegA.ElementWidth = 8;
            this.sevenSegmentRegA.ItalicFactor = 0F;
            this.sevenSegmentRegA.Location = new System.Drawing.Point(6, 31);
            this.sevenSegmentRegA.Name = "sevenSegmentRegA";
            this.sevenSegmentRegA.Size = new System.Drawing.Size(64, 64);
            this.sevenSegmentRegA.TabIndex = 17;
            this.sevenSegmentRegA.TabStop = false;
            this.sevenSegmentRegA.Value = "00";
            // 
            // groupBoxRegX
            // 
            this.groupBoxRegX.Controls.Add(this.sevenSegmentRegX);
            this.groupBoxRegX.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRegX.Location = new System.Drawing.Point(92, 12);
            this.groupBoxRegX.Name = "groupBoxRegX";
            this.groupBoxRegX.Size = new System.Drawing.Size(79, 117);
            this.groupBoxRegX.TabIndex = 20;
            this.groupBoxRegX.TabStop = false;
            this.groupBoxRegX.Text = "Reg X";
            // 
            // sevenSegmentRegX
            // 
            this.sevenSegmentRegX.ArrayCount = 2;
            this.sevenSegmentRegX.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentRegX.ColorDark = System.Drawing.Color.DarkRed;
            this.sevenSegmentRegX.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentRegX.DecimalShow = true;
            this.sevenSegmentRegX.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentRegX.ElementWidth = 8;
            this.sevenSegmentRegX.ItalicFactor = 0F;
            this.sevenSegmentRegX.Location = new System.Drawing.Point(6, 33);
            this.sevenSegmentRegX.Name = "sevenSegmentRegX";
            this.sevenSegmentRegX.Size = new System.Drawing.Size(64, 64);
            this.sevenSegmentRegX.TabIndex = 19;
            this.sevenSegmentRegX.TabStop = false;
            this.sevenSegmentRegX.Value = "00";
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.ArrayCount = 4;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.DarkGray;
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = 0F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(362, 251);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(128, 64);
            this.sevenSegmentArray1.TabIndex = 21;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = "ABCD";
            // 
            // sevenSegment1
            // 
            this.sevenSegment1.ColonOn = false;
            this.sevenSegment1.ColonShow = false;
            this.sevenSegment1.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegment1.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegment1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegment1.CustomPattern = 0;
            this.sevenSegment1.DecimalOn = false;
            this.sevenSegment1.DecimalShow = true;
            this.sevenSegment1.ElementWidth = 10;
            this.sevenSegment1.ItalicFactor = 0F;
            this.sevenSegment1.Location = new System.Drawing.Point(458, 332);
            this.sevenSegment1.Name = "sevenSegment1";
            this.sevenSegment1.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment1.Size = new System.Drawing.Size(32, 64);
            this.sevenSegment1.TabIndex = 20;
            this.sevenSegment1.TabStop = false;
            this.sevenSegment1.Value = null;
            // 
            // groupBoxLedSP
            // 
            this.groupBoxLedSP.Controls.Add(this.sevenSegmentSP);
            this.groupBoxLedSP.Controls.Add(this.sevenSegmentSPvalue);
            this.groupBoxLedSP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLedSP.Location = new System.Drawing.Point(595, 323);
            this.groupBoxLedSP.Name = "groupBoxLedSP";
            this.groupBoxLedSP.Size = new System.Drawing.Size(270, 135);
            this.groupBoxLedSP.TabIndex = 24;
            this.groupBoxLedSP.TabStop = false;
            this.groupBoxLedSP.Text = "Stackpointer";
            this.groupBoxLedSP.Visible = false;
            // 
            // sevenSegmentSP
            // 
            this.sevenSegmentSP.ArrayCount = 4;
            this.sevenSegmentSP.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentSP.ColorDark = System.Drawing.Color.DarkRed;
            this.sevenSegmentSP.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentSP.DecimalShow = true;
            this.sevenSegmentSP.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentSP.ElementWidth = 8;
            this.sevenSegmentSP.ItalicFactor = 0F;
            this.sevenSegmentSP.Location = new System.Drawing.Point(11, 36);
            this.sevenSegmentSP.Name = "sevenSegmentSP";
            this.sevenSegmentSP.Size = new System.Drawing.Size(128, 64);
            this.sevenSegmentSP.TabIndex = 18;
            this.sevenSegmentSP.TabStop = false;
            this.sevenSegmentSP.Value = "01ff";
            // 
            // sevenSegmentSPvalue
            // 
            this.sevenSegmentSPvalue.ArrayCount = 2;
            this.sevenSegmentSPvalue.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentSPvalue.ColorDark = System.Drawing.Color.DarkRed;
            this.sevenSegmentSPvalue.ColorLight = System.Drawing.Color.Red;
            this.sevenSegmentSPvalue.DecimalShow = true;
            this.sevenSegmentSPvalue.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentSPvalue.ElementWidth = 8;
            this.sevenSegmentSPvalue.ItalicFactor = 0F;
            this.sevenSegmentSPvalue.Location = new System.Drawing.Point(147, 36);
            this.sevenSegmentSPvalue.Name = "sevenSegmentSPvalue";
            this.sevenSegmentSPvalue.Size = new System.Drawing.Size(64, 64);
            this.sevenSegmentSPvalue.TabIndex = 18;
            this.sevenSegmentSPvalue.TabStop = false;
            this.sevenSegmentSPvalue.Value = "55";
            // 
            // CPU_emu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 531);
            this.Controls.Add(this.groupBoxLedSP);
            this.Controls.Add(this.groupBoxLedPC);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.groupBoxLedRegs);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CPU_emu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU emu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CPU_emu_FormClosing);
            this.Load += new System.EventHandler(this.CPU_emu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFlags.ResumeLayout(false);
            this.groupBoxFlags.PerformLayout();
            this.groupBoxRegisters.ResumeLayout(false);
            this.groupBoxRegisters.PerformLayout();
            this.groupBoxPCSP.ResumeLayout(false);
            this.groupBoxPCSP.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxStartStop.ResumeLayout(false);
            this.groupBoxStartStop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.groupBoxLedPC.ResumeLayout(false);
            this.groupBoxLedRegs.ResumeLayout(false);
            this.groupBoxRegY.ResumeLayout(false);
            this.groupRegA.ResumeLayout(false);
            this.groupBoxRegX.ResumeLayout(false);
            this.groupBoxLedSP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.CheckBox checkBoxCarryFlag;
        private System.Windows.Forms.GroupBox groupBoxFlags;
        private System.Windows.Forms.CheckBox checkBoxZeroFlag;
        private System.Windows.Forms.CheckBox checkBoxDecimalModeFlag;
        private System.Windows.Forms.CheckBox checkBoxIntDisableFlag;
        private System.Windows.Forms.CheckBox checkBoxBreakFlag;
        private System.Windows.Forms.CheckBox checkBoxNegativFlag;
        private System.Windows.Forms.CheckBox checkBoxOverflowFlag;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxRegisters;
        private System.Windows.Forms.TextBox textBoxRegA;
        private System.Windows.Forms.Label labelRegA;
        private System.Windows.Forms.TextBox textBoxRegY;
        private System.Windows.Forms.Label labelRegY;
        private System.Windows.Forms.TextBox textBoxRegX;
        private System.Windows.Forms.Label labelRegX;
        private System.Windows.Forms.GroupBox groupBoxPCSP;
        private System.Windows.Forms.TextBox textBoxPC;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.TextBox textBoxSP;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxStepping;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox checkBoxSlowDown;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBRK;
        private System.Windows.Forms.ToolStripMenuItem memoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusElapsedTime;
        private System.Windows.Forms.GroupBox groupBoxStartStop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeropageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem dumpToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromDumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem eraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.TextBox textBoxInstruction;
        private System.Windows.Forms.TextBox textBoxStackValue;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentRegA;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentRegY;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentRegX;
        private System.Windows.Forms.GroupBox groupRegA;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentArray1;
        private DmitryBrant.CustomControls.SevenSegment sevenSegment1;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleTXT;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStyleLED;
        private System.Windows.Forms.GroupBox groupBoxRegX;
        private System.Windows.Forms.GroupBox groupBoxRegY;
        private System.Windows.Forms.GroupBox groupBoxLedRegs;
        private System.Windows.Forms.GroupBox groupBoxLedPC;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentPC;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentPCvalue;
        private System.Windows.Forms.GroupBox groupBoxLedSP;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentSP;
        private DmitryBrant.CustomControls.SevenSegmentArray sevenSegmentSPvalue;
    }
}

