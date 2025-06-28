
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            dumpToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadFromDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            loadKernalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadCharRomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadBasicRomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            eraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            stackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            zeropageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            memrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemStyleTXT = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemStyleLED = new System.Windows.Forms.ToolStripMenuItem();
            checkBoxCarryFlag = new System.Windows.Forms.CheckBox();
            groupBoxFlags = new System.Windows.Forms.GroupBox();
            checkBoxNegativFlag = new System.Windows.Forms.CheckBox();
            checkBoxOverflowFlag = new System.Windows.Forms.CheckBox();
            checkBoxBreakFlag = new System.Windows.Forms.CheckBox();
            checkBoxDecimalModeFlag = new System.Windows.Forms.CheckBox();
            checkBoxIntDisableFlag = new System.Windows.Forms.CheckBox();
            checkBoxZeroFlag = new System.Windows.Forms.CheckBox();
            buttonStart = new System.Windows.Forms.Button();
            groupBoxRegisters = new System.Windows.Forms.GroupBox();
            textBoxRegY = new System.Windows.Forms.TextBox();
            labelRegY = new System.Windows.Forms.Label();
            textBoxRegX = new System.Windows.Forms.TextBox();
            labelRegX = new System.Windows.Forms.Label();
            textBoxRegA = new System.Windows.Forms.TextBox();
            labelRegA = new System.Windows.Forms.Label();
            groupBoxPCSP = new System.Windows.Forms.GroupBox();
            textBoxStackValue = new System.Windows.Forms.TextBox();
            textBoxInstruction = new System.Windows.Forms.TextBox();
            textBoxSP = new System.Windows.Forms.TextBox();
            labelSP = new System.Windows.Forms.Label();
            textBoxPC = new System.Windows.Forms.TextBox();
            labelPC = new System.Windows.Forms.Label();
            buttonStop = new System.Windows.Forms.Button();
            buttonReset = new System.Windows.Forms.Button();
            checkBoxStepping = new System.Windows.Forms.CheckBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabelBRK = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabelKernal = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabelBasic = new System.Windows.Forms.ToolStripStatusLabel();
            checkBoxSlowDown = new System.Windows.Forms.CheckBox();
            groupBoxStartStop = new System.Windows.Forms.GroupBox();
            panelMain = new System.Windows.Forms.Panel();
            groupBoxLedFlags = new System.Windows.Forms.GroupBox();
            label7 = new System.Windows.Forms.Label();
            ledBulbFnegativ = new Bulb.LedBulb();
            label6 = new System.Windows.Forms.Label();
            ledBulbFoverflow = new Bulb.LedBulb();
            label5 = new System.Windows.Forms.Label();
            ledBulbFbreak = new Bulb.LedBulb();
            label4 = new System.Windows.Forms.Label();
            ledBulbFdecimalmode = new Bulb.LedBulb();
            label3 = new System.Windows.Forms.Label();
            ledBulbFintdisable = new Bulb.LedBulb();
            label2 = new System.Windows.Forms.Label();
            ledBulbFzero = new Bulb.LedBulb();
            label1 = new System.Windows.Forms.Label();
            ledBulbFcarry = new Bulb.LedBulb();
            groupBoxLedPC = new System.Windows.Forms.GroupBox();
            sevenSegmentPC = new DmitryBrant.CustomControls.SevenSegmentArray();
            sevenSegmentPCvalue = new DmitryBrant.CustomControls.SevenSegmentArray();
            groupBoxLedRegs = new System.Windows.Forms.GroupBox();
            groupBoxRegY = new System.Windows.Forms.GroupBox();
            sevenSegmentRegY = new DmitryBrant.CustomControls.SevenSegmentArray();
            groupRegA = new System.Windows.Forms.GroupBox();
            sevenSegmentRegA = new DmitryBrant.CustomControls.SevenSegmentArray();
            groupBoxRegX = new System.Windows.Forms.GroupBox();
            sevenSegmentRegX = new DmitryBrant.CustomControls.SevenSegmentArray();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            groupBoxLedSP = new System.Windows.Forms.GroupBox();
            sevenSegmentSP = new DmitryBrant.CustomControls.SevenSegmentArray();
            sevenSegmentSPvalue = new DmitryBrant.CustomControls.SevenSegmentArray();
            menuStrip1.SuspendLayout();
            groupBoxFlags.SuspendLayout();
            groupBoxRegisters.SuspendLayout();
            groupBoxPCSP.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBoxStartStop.SuspendLayout();
            panelMain.SuspendLayout();
            groupBoxLedFlags.SuspendLayout();
            groupBoxLedPC.SuspendLayout();
            groupBoxLedRegs.SuspendLayout();
            groupBoxRegY.SuspendLayout();
            groupRegA.SuspendLayout();
            groupBoxRegX.SuspendLayout();
            groupBoxLedSP.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dateiToolStripMenuItem, memoryToolStripMenuItem, watchToolStripMenuItem, styleToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1306, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemOpenFile, toolStripMenuItemSaveFile, toolStripSeparator1, ToolStripMenuItemClose, toolStripSeparator4, toolStripMenuItemSettings });
            dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            dateiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            dateiToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItemOpenFile
            // 
            toolStripMenuItemOpenFile.Name = "toolStripMenuItemOpenFile";
            toolStripMenuItemOpenFile.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            toolStripMenuItemOpenFile.Size = new System.Drawing.Size(194, 22);
            toolStripMenuItemOpenFile.Text = "Load program";
            toolStripMenuItemOpenFile.ToolTipText = "Load program from file";
            toolStripMenuItemOpenFile.Click += ToolStripMenuItemOpenFile_Click;
            // 
            // toolStripMenuItemSaveFile
            // 
            toolStripMenuItemSaveFile.Name = "toolStripMenuItemSaveFile";
            toolStripMenuItemSaveFile.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            toolStripMenuItemSaveFile.Size = new System.Drawing.Size(194, 22);
            toolStripMenuItemSaveFile.Text = "Save program";
            toolStripMenuItemSaveFile.ToolTipText = "Save program to file";
            toolStripMenuItemSaveFile.Click += ToolStripMenuItemSaveFile_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // ToolStripMenuItemClose
            // 
            ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            ToolStripMenuItemClose.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            ToolStripMenuItemClose.Size = new System.Drawing.Size(194, 22);
            ToolStripMenuItemClose.Text = "&Close";
            ToolStripMenuItemClose.Click += CloseToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // toolStripMenuItemSettings
            // 
            toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            toolStripMenuItemSettings.Size = new System.Drawing.Size(194, 22);
            toolStripMenuItemSettings.Text = "&Settings";
            toolStripMenuItemSettings.Click += ToolStripMenuItemSettings_Click;
            // 
            // memoryToolStripMenuItem
            // 
            memoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { editToolStripMenuItem, toolStripSeparator2, dumpToFileToolStripMenuItem, loadFromDumpToolStripMenuItem, toolStripSeparator3, loadKernalToolStripMenuItem, loadCharRomToolStripMenuItem, loadBasicRomToolStripMenuItem, toolStripSeparator6, toolStripMenuItem1, toolStripSeparator5, eraseToolStripMenuItem });
            memoryToolStripMenuItem.Name = "memoryToolStripMenuItem";
            memoryToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            memoryToolStripMenuItem.Text = "&Memory";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // dumpToFileToolStripMenuItem
            // 
            dumpToFileToolStripMenuItem.Name = "dumpToFileToolStripMenuItem";
            dumpToFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            dumpToFileToolStripMenuItem.Text = "dump to file";
            dumpToFileToolStripMenuItem.ToolTipText = "Dump whole memory to file";
            dumpToFileToolStripMenuItem.Click += DumpToFileToolStripMenuItem_Click;
            // 
            // loadFromDumpToolStripMenuItem
            // 
            loadFromDumpToolStripMenuItem.Name = "loadFromDumpToolStripMenuItem";
            loadFromDumpToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            loadFromDumpToolStripMenuItem.Text = "load from dump";
            loadFromDumpToolStripMenuItem.ToolTipText = "Load dumpfile into memory";
            loadFromDumpToolStripMenuItem.Click += LoadFromDumpToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // loadKernalToolStripMenuItem
            // 
            loadKernalToolStripMenuItem.Name = "loadKernalToolStripMenuItem";
            loadKernalToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            loadKernalToolStripMenuItem.Text = "load Kernal ROM";
            loadKernalToolStripMenuItem.Click += loadKernalToolStripMenuItem_Click;
            // 
            // loadCharRomToolStripMenuItem
            // 
            loadCharRomToolStripMenuItem.Name = "loadCharRomToolStripMenuItem";
            loadCharRomToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            loadCharRomToolStripMenuItem.Text = "load Character ROM";
            loadCharRomToolStripMenuItem.Click += loadCharRomToolStripMenuItem_Click;
            // 
            // loadBasicRomToolStripMenuItem
            // 
            loadBasicRomToolStripMenuItem.Name = "loadBasicRomToolStripMenuItem";
            loadBasicRomToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            loadBasicRomToolStripMenuItem.Text = "load Basic ROM";
            loadBasicRomToolStripMenuItem.Click += loadBasicRomToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(198, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2;
            toolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            toolStripMenuItem1.Text = "set address / register";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(198, 6);
            // 
            // eraseToolStripMenuItem
            // 
            eraseToolStripMenuItem.Name = "eraseToolStripMenuItem";
            eraseToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            eraseToolStripMenuItem.Text = "erase";
            eraseToolStripMenuItem.Click += EraseToolStripMenuItem_Click;
            // 
            // watchToolStripMenuItem
            // 
            watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { stackToolStripMenuItem, zeropageToolStripMenuItem, memrangeToolStripMenuItem });
            watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            watchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            watchToolStripMenuItem.Text = "&Watch";
            // 
            // stackToolStripMenuItem
            // 
            stackToolStripMenuItem.Name = "stackToolStripMenuItem";
            stackToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            stackToolStripMenuItem.Text = "Stack";
            stackToolStripMenuItem.Click += StackToolStripMenuItem_Click;
            // 
            // zeropageToolStripMenuItem
            // 
            zeropageToolStripMenuItem.Name = "zeropageToolStripMenuItem";
            zeropageToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            zeropageToolStripMenuItem.Text = "Zeropage";
            zeropageToolStripMenuItem.Click += ZeropageToolStripMenuItem_Click;
            // 
            // memrangeToolStripMenuItem
            // 
            memrangeToolStripMenuItem.Name = "memrangeToolStripMenuItem";
            memrangeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            memrangeToolStripMenuItem.Text = "Memory Range";
            memrangeToolStripMenuItem.Click += MemrangeToolStripMenuItem_Click;
            // 
            // styleToolStripMenuItem
            // 
            styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemStyleTXT, toolStripMenuItemStyleLED });
            styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            styleToolStripMenuItem.Text = "&Style";
            // 
            // toolStripMenuItemStyleTXT
            // 
            toolStripMenuItemStyleTXT.Checked = true;
            toolStripMenuItemStyleTXT.CheckOnClick = true;
            toolStripMenuItemStyleTXT.CheckState = System.Windows.Forms.CheckState.Checked;
            toolStripMenuItemStyleTXT.Name = "toolStripMenuItemStyleTXT";
            toolStripMenuItemStyleTXT.Size = new System.Drawing.Size(95, 22);
            toolStripMenuItemStyleTXT.Text = "TXT";
            toolStripMenuItemStyleTXT.Click += toolStripMenuItemStyleTXT_Click;
            // 
            // toolStripMenuItemStyleLED
            // 
            toolStripMenuItemStyleLED.CheckOnClick = true;
            toolStripMenuItemStyleLED.Name = "toolStripMenuItemStyleLED";
            toolStripMenuItemStyleLED.Size = new System.Drawing.Size(95, 22);
            toolStripMenuItemStyleLED.Text = "LED";
            toolStripMenuItemStyleLED.Click += toolStripMenuItemStyleLED_Click;
            // 
            // checkBoxCarryFlag
            // 
            checkBoxCarryFlag.AutoCheck = false;
            checkBoxCarryFlag.AutoSize = true;
            checkBoxCarryFlag.Checked = true;
            checkBoxCarryFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxCarryFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxCarryFlag.Location = new System.Drawing.Point(7, 22);
            checkBoxCarryFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxCarryFlag.Name = "checkBoxCarryFlag";
            checkBoxCarryFlag.Size = new System.Drawing.Size(98, 20);
            checkBoxCarryFlag.TabIndex = 1;
            checkBoxCarryFlag.Tag = "C";
            checkBoxCarryFlag.Text = "Carry [C]";
            checkBoxCarryFlag.UseVisualStyleBackColor = true;
            // 
            // groupBoxFlags
            // 
            groupBoxFlags.Controls.Add(checkBoxNegativFlag);
            groupBoxFlags.Controls.Add(checkBoxOverflowFlag);
            groupBoxFlags.Controls.Add(checkBoxBreakFlag);
            groupBoxFlags.Controls.Add(checkBoxDecimalModeFlag);
            groupBoxFlags.Controls.Add(checkBoxIntDisableFlag);
            groupBoxFlags.Controls.Add(checkBoxZeroFlag);
            groupBoxFlags.Controls.Add(checkBoxCarryFlag);
            groupBoxFlags.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBoxFlags.Location = new System.Drawing.Point(14, 15);
            groupBoxFlags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxFlags.Name = "groupBoxFlags";
            groupBoxFlags.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxFlags.Size = new System.Drawing.Size(189, 257);
            groupBoxFlags.TabIndex = 2;
            groupBoxFlags.TabStop = false;
            groupBoxFlags.Text = "Flags";
            // 
            // checkBoxNegativFlag
            // 
            checkBoxNegativFlag.AutoCheck = false;
            checkBoxNegativFlag.AutoSize = true;
            checkBoxNegativFlag.Checked = true;
            checkBoxNegativFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxNegativFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxNegativFlag.Location = new System.Drawing.Point(7, 202);
            checkBoxNegativFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxNegativFlag.Name = "checkBoxNegativFlag";
            checkBoxNegativFlag.Size = new System.Drawing.Size(122, 20);
            checkBoxNegativFlag.TabIndex = 7;
            checkBoxNegativFlag.Tag = "N";
            checkBoxNegativFlag.Text = "Negativ  [N]";
            checkBoxNegativFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverflowFlag
            // 
            checkBoxOverflowFlag.AutoCheck = false;
            checkBoxOverflowFlag.AutoSize = true;
            checkBoxOverflowFlag.Checked = true;
            checkBoxOverflowFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxOverflowFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxOverflowFlag.Location = new System.Drawing.Point(7, 172);
            checkBoxOverflowFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxOverflowFlag.Name = "checkBoxOverflowFlag";
            checkBoxOverflowFlag.Size = new System.Drawing.Size(122, 20);
            checkBoxOverflowFlag.TabIndex = 6;
            checkBoxOverflowFlag.Tag = "V";
            checkBoxOverflowFlag.Text = "Overflow [V]";
            checkBoxOverflowFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakFlag
            // 
            checkBoxBreakFlag.AutoCheck = false;
            checkBoxBreakFlag.AutoSize = true;
            checkBoxBreakFlag.Checked = true;
            checkBoxBreakFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxBreakFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxBreakFlag.Location = new System.Drawing.Point(7, 142);
            checkBoxBreakFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxBreakFlag.Name = "checkBoxBreakFlag";
            checkBoxBreakFlag.Size = new System.Drawing.Size(98, 20);
            checkBoxBreakFlag.TabIndex = 5;
            checkBoxBreakFlag.Tag = "B";
            checkBoxBreakFlag.Text = "Break [B]";
            checkBoxBreakFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxDecimalModeFlag
            // 
            checkBoxDecimalModeFlag.AutoCheck = false;
            checkBoxDecimalModeFlag.AutoSize = true;
            checkBoxDecimalModeFlag.Checked = true;
            checkBoxDecimalModeFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxDecimalModeFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxDecimalModeFlag.Location = new System.Drawing.Point(7, 112);
            checkBoxDecimalModeFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxDecimalModeFlag.Name = "checkBoxDecimalModeFlag";
            checkBoxDecimalModeFlag.Size = new System.Drawing.Size(146, 20);
            checkBoxDecimalModeFlag.TabIndex = 4;
            checkBoxDecimalModeFlag.Tag = "D";
            checkBoxDecimalModeFlag.Text = "DecimalMode [D]";
            checkBoxDecimalModeFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxIntDisableFlag
            // 
            checkBoxIntDisableFlag.AutoCheck = false;
            checkBoxIntDisableFlag.AutoSize = true;
            checkBoxIntDisableFlag.Checked = true;
            checkBoxIntDisableFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxIntDisableFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxIntDisableFlag.Location = new System.Drawing.Point(7, 82);
            checkBoxIntDisableFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxIntDisableFlag.Name = "checkBoxIntDisableFlag";
            checkBoxIntDisableFlag.Size = new System.Drawing.Size(146, 20);
            checkBoxIntDisableFlag.TabIndex = 3;
            checkBoxIntDisableFlag.Tag = "I";
            checkBoxIntDisableFlag.Text = "intDisable  [I]";
            checkBoxIntDisableFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxZeroFlag
            // 
            checkBoxZeroFlag.AutoCheck = false;
            checkBoxZeroFlag.AutoSize = true;
            checkBoxZeroFlag.Checked = true;
            checkBoxZeroFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBoxZeroFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            checkBoxZeroFlag.Location = new System.Drawing.Point(7, 52);
            checkBoxZeroFlag.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxZeroFlag.Name = "checkBoxZeroFlag";
            checkBoxZeroFlag.Size = new System.Drawing.Size(98, 20);
            checkBoxZeroFlag.TabIndex = 2;
            checkBoxZeroFlag.Tag = "Z";
            checkBoxZeroFlag.Text = "Zero  [Z]";
            checkBoxZeroFlag.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            buttonStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            buttonStart.Location = new System.Drawing.Point(7, 27);
            buttonStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(184, 27);
            buttonStart.TabIndex = 4;
            buttonStart.TabStop = false;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += ButtonStart_Click;
            // 
            // groupBoxRegisters
            // 
            groupBoxRegisters.Controls.Add(textBoxRegY);
            groupBoxRegisters.Controls.Add(labelRegY);
            groupBoxRegisters.Controls.Add(textBoxRegX);
            groupBoxRegisters.Controls.Add(labelRegX);
            groupBoxRegisters.Controls.Add(textBoxRegA);
            groupBoxRegisters.Controls.Add(labelRegA);
            groupBoxRegisters.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBoxRegisters.Location = new System.Drawing.Point(210, 15);
            groupBoxRegisters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxRegisters.Name = "groupBoxRegisters";
            groupBoxRegisters.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxRegisters.Size = new System.Drawing.Size(158, 135);
            groupBoxRegisters.TabIndex = 6;
            groupBoxRegisters.TabStop = false;
            groupBoxRegisters.Text = "Registers";
            // 
            // textBoxRegY
            // 
            textBoxRegY.Location = new System.Drawing.Point(44, 90);
            textBoxRegY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxRegY.Name = "textBoxRegY";
            textBoxRegY.ReadOnly = true;
            textBoxRegY.Size = new System.Drawing.Size(67, 23);
            textBoxRegY.TabIndex = 5;
            textBoxRegY.Text = "FF";
            textBoxRegY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegY
            // 
            labelRegY.AutoSize = true;
            labelRegY.Location = new System.Drawing.Point(7, 93);
            labelRegY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelRegY.Name = "labelRegY";
            labelRegY.Size = new System.Drawing.Size(17, 16);
            labelRegY.TabIndex = 4;
            labelRegY.Text = "Y";
            labelRegY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegX
            // 
            textBoxRegX.Location = new System.Drawing.Point(44, 57);
            textBoxRegX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxRegX.Name = "textBoxRegX";
            textBoxRegX.ReadOnly = true;
            textBoxRegX.Size = new System.Drawing.Size(67, 23);
            textBoxRegX.TabIndex = 3;
            textBoxRegX.Text = "FF";
            textBoxRegX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegX
            // 
            labelRegX.AutoSize = true;
            labelRegX.Location = new System.Drawing.Point(7, 60);
            labelRegX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelRegX.Name = "labelRegX";
            labelRegX.Size = new System.Drawing.Size(16, 16);
            labelRegX.TabIndex = 2;
            labelRegX.Text = "X";
            labelRegX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegA
            // 
            textBoxRegA.Location = new System.Drawing.Point(44, 23);
            textBoxRegA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxRegA.Name = "textBoxRegA";
            textBoxRegA.ReadOnly = true;
            textBoxRegA.Size = new System.Drawing.Size(67, 23);
            textBoxRegA.TabIndex = 1;
            textBoxRegA.Text = "FF";
            textBoxRegA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegA
            // 
            labelRegA.AutoSize = true;
            labelRegA.Location = new System.Drawing.Point(7, 27);
            labelRegA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelRegA.Name = "labelRegA";
            labelRegA.Size = new System.Drawing.Size(16, 16);
            labelRegA.TabIndex = 0;
            labelRegA.Text = "A";
            labelRegA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxPCSP
            // 
            groupBoxPCSP.Controls.Add(textBoxStackValue);
            groupBoxPCSP.Controls.Add(textBoxInstruction);
            groupBoxPCSP.Controls.Add(textBoxSP);
            groupBoxPCSP.Controls.Add(labelSP);
            groupBoxPCSP.Controls.Add(textBoxPC);
            groupBoxPCSP.Controls.Add(labelPC);
            groupBoxPCSP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBoxPCSP.Location = new System.Drawing.Point(210, 157);
            groupBoxPCSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxPCSP.Name = "groupBoxPCSP";
            groupBoxPCSP.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxPCSP.Size = new System.Drawing.Size(158, 190);
            groupBoxPCSP.TabIndex = 7;
            groupBoxPCSP.TabStop = false;
            // 
            // textBoxStackValue
            // 
            textBoxStackValue.Location = new System.Drawing.Point(44, 142);
            textBoxStackValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxStackValue.Name = "textBoxStackValue";
            textBoxStackValue.ReadOnly = true;
            textBoxStackValue.Size = new System.Drawing.Size(67, 23);
            textBoxStackValue.TabIndex = 11;
            textBoxStackValue.Text = "FF";
            textBoxStackValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInstruction
            // 
            textBoxInstruction.Location = new System.Drawing.Point(44, 55);
            textBoxInstruction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxInstruction.Name = "textBoxInstruction";
            textBoxInstruction.ReadOnly = true;
            textBoxInstruction.Size = new System.Drawing.Size(67, 23);
            textBoxInstruction.TabIndex = 10;
            textBoxInstruction.Text = "FF";
            textBoxInstruction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSP
            // 
            textBoxSP.Location = new System.Drawing.Point(44, 108);
            textBoxSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxSP.Name = "textBoxSP";
            textBoxSP.ReadOnly = true;
            textBoxSP.Size = new System.Drawing.Size(67, 23);
            textBoxSP.TabIndex = 9;
            textBoxSP.Text = "FF";
            textBoxSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSP
            // 
            labelSP.AutoSize = true;
            labelSP.Location = new System.Drawing.Point(6, 127);
            labelSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelSP.Name = "labelSP";
            labelSP.Size = new System.Drawing.Size(25, 16);
            labelSP.TabIndex = 8;
            labelSP.Text = "SP";
            labelSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPC
            // 
            textBoxPC.Location = new System.Drawing.Point(44, 25);
            textBoxPC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxPC.Name = "textBoxPC";
            textBoxPC.ReadOnly = true;
            textBoxPC.Size = new System.Drawing.Size(67, 23);
            textBoxPC.TabIndex = 7;
            textBoxPC.Text = "FF";
            textBoxPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPC
            // 
            labelPC.AutoSize = true;
            labelPC.Location = new System.Drawing.Point(6, 45);
            labelPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPC.Name = "labelPC";
            labelPC.Size = new System.Drawing.Size(26, 16);
            labelPC.TabIndex = 6;
            labelPC.Text = "PC";
            labelPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStop
            // 
            buttonStop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            buttonStop.Location = new System.Drawing.Point(7, 60);
            buttonStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new System.Drawing.Size(184, 27);
            buttonStop.TabIndex = 8;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += ButtonStop_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            buttonReset.Location = new System.Drawing.Point(7, 93);
            buttonReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new System.Drawing.Size(184, 27);
            buttonReset.TabIndex = 9;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += ButtonReset_Click;
            // 
            // checkBoxStepping
            // 
            checkBoxStepping.AutoSize = true;
            checkBoxStepping.Location = new System.Drawing.Point(7, 136);
            checkBoxStepping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxStepping.Name = "checkBoxStepping";
            checkBoxStepping.Size = new System.Drawing.Size(89, 20);
            checkBoxStepping.TabIndex = 10;
            checkBoxStepping.Text = "Stepping";
            checkBoxStepping.UseVisualStyleBackColor = true;
            checkBoxStepping.CheckedChanged += CheckBoxStepping_CheckedChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabelBRK, toolStripStatusElapsedTime, toolStripProgressBar1, toolStripStatusLabel1, toolStripStatusLabelKernal, toolStripStatusLabel2, toolStripStatusLabelBasic });
            statusStrip1.Location = new System.Drawing.Point(0, 599);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(1306, 22);
            statusStrip1.TabIndex = 11;
            // 
            // toolStripStatusLabelBRK
            // 
            toolStripStatusLabelBRK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            toolStripStatusLabelBRK.Name = "toolStripStatusLabelBRK";
            toolStripStatusLabelBRK.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusElapsedTime
            // 
            toolStripStatusElapsedTime.Name = "toolStripStatusElapsedTime";
            toolStripStatusElapsedTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new System.Drawing.Size(233, 18);
            toolStripProgressBar1.Step = 1;
            toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            toolStripProgressBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            toolStripStatusLabel1.Text = "KERNAL: ";
            // 
            // toolStripStatusLabelKernal
            // 
            toolStripStatusLabelKernal.Name = "toolStripStatusLabelKernal";
            toolStripStatusLabelKernal.Size = new System.Drawing.Size(24, 17);
            toolStripStatusLabelKernal.Text = "0x0";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(45, 17);
            toolStripStatusLabel2.Text = "BASIC: ";
            // 
            // toolStripStatusLabelBasic
            // 
            toolStripStatusLabelBasic.Name = "toolStripStatusLabelBasic";
            toolStripStatusLabelBasic.Size = new System.Drawing.Size(24, 17);
            toolStripStatusLabelBasic.Text = "0x0";
            // 
            // checkBoxSlowDown
            // 
            checkBoxSlowDown.AutoSize = true;
            checkBoxSlowDown.Location = new System.Drawing.Point(7, 166);
            checkBoxSlowDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxSlowDown.Name = "checkBoxSlowDown";
            checkBoxSlowDown.Size = new System.Drawing.Size(59, 20);
            checkBoxSlowDown.TabIndex = 14;
            checkBoxSlowDown.Text = "Slow";
            checkBoxSlowDown.UseVisualStyleBackColor = true;
            checkBoxSlowDown.CheckedChanged += CheckBoxSlowDown_CheckedChanged;
            // 
            // groupBoxStartStop
            // 
            groupBoxStartStop.Controls.Add(buttonStart);
            groupBoxStartStop.Controls.Add(buttonStop);
            groupBoxStartStop.Controls.Add(checkBoxSlowDown);
            groupBoxStartStop.Controls.Add(buttonReset);
            groupBoxStartStop.Controls.Add(checkBoxStepping);
            groupBoxStartStop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBoxStartStop.Location = new System.Drawing.Point(374, 15);
            groupBoxStartStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStartStop.Name = "groupBoxStartStop";
            groupBoxStartStop.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxStartStop.Size = new System.Drawing.Size(197, 225);
            groupBoxStartStop.TabIndex = 16;
            groupBoxStartStop.TabStop = false;
            groupBoxStartStop.Text = "Start/Stop";
            // 
            // panelMain
            // 
            panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelMain.Controls.Add(groupBoxStartStop);
            panelMain.Controls.Add(groupBoxFlags);
            panelMain.Controls.Add(groupBoxRegisters);
            panelMain.Controls.Add(groupBoxPCSP);
            panelMain.Location = new System.Drawing.Point(14, 32);
            panelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(618, 551);
            panelMain.TabIndex = 16;
            // 
            // groupBoxLedFlags
            // 
            groupBoxLedFlags.Controls.Add(label7);
            groupBoxLedFlags.Controls.Add(ledBulbFnegativ);
            groupBoxLedFlags.Controls.Add(label6);
            groupBoxLedFlags.Controls.Add(ledBulbFoverflow);
            groupBoxLedFlags.Controls.Add(label5);
            groupBoxLedFlags.Controls.Add(ledBulbFbreak);
            groupBoxLedFlags.Controls.Add(label4);
            groupBoxLedFlags.Controls.Add(ledBulbFdecimalmode);
            groupBoxLedFlags.Controls.Add(label3);
            groupBoxLedFlags.Controls.Add(ledBulbFintdisable);
            groupBoxLedFlags.Controls.Add(label2);
            groupBoxLedFlags.Controls.Add(ledBulbFzero);
            groupBoxLedFlags.Controls.Add(label1);
            groupBoxLedFlags.Controls.Add(ledBulbFcarry);
            groupBoxLedFlags.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBoxLedFlags.Location = new System.Drawing.Point(1060, 274);
            groupBoxLedFlags.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLedFlags.Name = "groupBoxLedFlags";
            groupBoxLedFlags.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLedFlags.Size = new System.Drawing.Size(233, 291);
            groupBoxLedFlags.TabIndex = 23;
            groupBoxLedFlags.TabStop = false;
            groupBoxLedFlags.Text = "Flags";
            groupBoxLedFlags.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(43, 240);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 16);
            label7.TabIndex = 35;
            label7.Tag = "";
            label7.Text = "Negativ  [N]";
            label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ledBulbFnegativ
            // 
            ledBulbFnegativ.BackColor = System.Drawing.Color.Transparent;
            ledBulbFnegativ.Color = System.Drawing.Color.Red;
            ledBulbFnegativ.Location = new System.Drawing.Point(7, 237);
            ledBulbFnegativ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ledBulbFnegativ.Name = "ledBulbFnegativ";
            ledBulbFnegativ.On = false;
            ledBulbFnegativ.Size = new System.Drawing.Size(29, 35);
            ledBulbFnegativ.TabIndex = 34;
            ledBulbFnegativ.Tag = "N";
            ledBulbFnegativ.Text = "ledBulb1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(43, 209);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(103, 16);
            label6.TabIndex = 33;
            label6.Tag = "";
            label6.Text = "Overflow [V]";
            label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ledBulbFoverflow
            // 
            ledBulbFoverflow.BackColor = System.Drawing.Color.Transparent;
            ledBulbFoverflow.Color = System.Drawing.Color.Red;
            ledBulbFoverflow.Location = new System.Drawing.Point(7, 205);
            ledBulbFoverflow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ledBulbFoverflow.Name = "ledBulbFoverflow";
            ledBulbFoverflow.On = false;
            ledBulbFoverflow.Size = new System.Drawing.Size(29, 35);
            ledBulbFoverflow.TabIndex = 32;
            ledBulbFoverflow.Tag = "V";
            ledBulbFoverflow.Text = "ledBulb1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(43, 174);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 16);
            label5.TabIndex = 31;
            label5.Tag = "";
            label5.Text = "Break [B]";
            label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ledBulbFbreak
            // 
            ledBulbFbreak.BackColor = System.Drawing.Color.Transparent;
            ledBulbFbreak.Color = System.Drawing.Color.Red;
            ledBulbFbreak.Location = new System.Drawing.Point(7, 171);
            ledBulbFbreak.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ledBulbFbreak.Name = "ledBulbFbreak";
            ledBulbFbreak.On = false;
            ledBulbFbreak.Size = new System.Drawing.Size(29, 35);
            ledBulbFbreak.TabIndex = 30;
            ledBulbFbreak.Tag = "B";
            ledBulbFbreak.Text = "ledBulb1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(43, 140);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(127, 16);
            label4.TabIndex = 29;
            label4.Tag = "";
            label4.Text = "DecimalMode [D]";
            label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ledBulbFdecimalmode
            // 
            ledBulbFdecimalmode.BackColor = System.Drawing.Color.Transparent;
            ledBulbFdecimalmode.Color = System.Drawing.Color.Red;
            ledBulbFdecimalmode.Location = new System.Drawing.Point(7, 136);
            ledBulbFdecimalmode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ledBulbFdecimalmode.Name = "ledBulbFdecimalmode";
            ledBulbFdecimalmode.On = false;
            ledBulbFdecimalmode.Size = new System.Drawing.Size(29, 35);
            ledBulbFdecimalmode.TabIndex = 28;
            ledBulbFdecimalmode.Tag = "D";
            ledBulbFdecimalmode.Text = "ledBulb1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(44, 105);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 16);
            label3.TabIndex = 27;
            label3.Tag = "";
            label3.Text = "intDisable  [I]";
            label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ledBulbFintdisable
            // 
            ledBulbFintdisable.BackColor = System.Drawing.Color.Transparent;
            ledBulbFintdisable.Color = System.Drawing.Color.Red;
            ledBulbFintdisable.Location = new System.Drawing.Point(7, 102);
            ledBulbFintdisable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ledBulbFintdisable.Name = "ledBulbFintdisable";
            ledBulbFintdisable.On = false;
            ledBulbFintdisable.Size = new System.Drawing.Size(29, 35);
            ledBulbFintdisable.TabIndex = 26;
            ledBulbFintdisable.Tag = "I";
            ledBulbFintdisable.Text = "ledBulb1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(44, 70);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 16);
            label2.TabIndex = 25;
            label2.Tag = "";
            label2.Text = "Zero  [Z]";
            label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ledBulbFzero
            // 
            ledBulbFzero.BackColor = System.Drawing.Color.Transparent;
            ledBulbFzero.Color = System.Drawing.Color.Red;
            ledBulbFzero.Location = new System.Drawing.Point(7, 67);
            ledBulbFzero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ledBulbFzero.Name = "ledBulbFzero";
            ledBulbFzero.On = false;
            ledBulbFzero.Size = new System.Drawing.Size(29, 35);
            ledBulbFzero.TabIndex = 24;
            ledBulbFzero.Tag = "Z";
            ledBulbFzero.Text = "ledBulb1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(44, 36);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 16);
            label1.TabIndex = 23;
            label1.Text = "Carry [C]";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ledBulbFcarry
            // 
            ledBulbFcarry.BackColor = System.Drawing.Color.Transparent;
            ledBulbFcarry.Color = System.Drawing.Color.Red;
            ledBulbFcarry.Location = new System.Drawing.Point(7, 32);
            ledBulbFcarry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ledBulbFcarry.Name = "ledBulbFcarry";
            ledBulbFcarry.On = false;
            ledBulbFcarry.Size = new System.Drawing.Size(29, 35);
            ledBulbFcarry.TabIndex = 22;
            ledBulbFcarry.Tag = "C";
            ledBulbFcarry.Text = "ledBulb1";
            // 
            // groupBoxLedPC
            // 
            groupBoxLedPC.Controls.Add(sevenSegmentPC);
            groupBoxLedPC.Controls.Add(sevenSegmentPCvalue);
            groupBoxLedPC.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBoxLedPC.Location = new System.Drawing.Point(694, 265);
            groupBoxLedPC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLedPC.Name = "groupBoxLedPC";
            groupBoxLedPC.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLedPC.Size = new System.Drawing.Size(315, 156);
            groupBoxLedPC.TabIndex = 23;
            groupBoxLedPC.TabStop = false;
            groupBoxLedPC.Text = "Programcounter";
            groupBoxLedPC.Visible = false;
            // 
            // sevenSegmentPC
            // 
            sevenSegmentPC.ArrayCount = 4;
            sevenSegmentPC.ColorBackground = System.Drawing.Color.Black;
            sevenSegmentPC.ColorDark = System.Drawing.Color.DarkRed;
            sevenSegmentPC.ColorLight = System.Drawing.Color.Red;
            sevenSegmentPC.DecimalShow = true;
            sevenSegmentPC.ElementPadding = new System.Windows.Forms.Padding(4);
            sevenSegmentPC.ElementWidth = 8;
            sevenSegmentPC.ItalicFactor = 0F;
            sevenSegmentPC.Location = new System.Drawing.Point(13, 42);
            sevenSegmentPC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sevenSegmentPC.Name = "sevenSegmentPC";
            sevenSegmentPC.Size = new System.Drawing.Size(149, 74);
            sevenSegmentPC.TabIndex = 18;
            sevenSegmentPC.TabStop = false;
            sevenSegmentPC.Value = "0200";
            // 
            // sevenSegmentPCvalue
            // 
            sevenSegmentPCvalue.ArrayCount = 2;
            sevenSegmentPCvalue.ColorBackground = System.Drawing.Color.Black;
            sevenSegmentPCvalue.ColorDark = System.Drawing.Color.DarkRed;
            sevenSegmentPCvalue.ColorLight = System.Drawing.Color.Red;
            sevenSegmentPCvalue.DecimalShow = true;
            sevenSegmentPCvalue.ElementPadding = new System.Windows.Forms.Padding(4);
            sevenSegmentPCvalue.ElementWidth = 8;
            sevenSegmentPCvalue.ItalicFactor = 0F;
            sevenSegmentPCvalue.Location = new System.Drawing.Point(172, 42);
            sevenSegmentPCvalue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sevenSegmentPCvalue.Name = "sevenSegmentPCvalue";
            sevenSegmentPCvalue.Size = new System.Drawing.Size(75, 74);
            sevenSegmentPCvalue.TabIndex = 18;
            sevenSegmentPCvalue.TabStop = false;
            sevenSegmentPCvalue.Value = "55";
            // 
            // groupBoxLedRegs
            // 
            groupBoxLedRegs.Controls.Add(groupBoxRegY);
            groupBoxLedRegs.Controls.Add(groupRegA);
            groupBoxLedRegs.Controls.Add(groupBoxRegX);
            groupBoxLedRegs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            groupBoxLedRegs.Location = new System.Drawing.Point(694, 47);
            groupBoxLedRegs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLedRegs.Name = "groupBoxLedRegs";
            groupBoxLedRegs.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLedRegs.Size = new System.Drawing.Size(315, 156);
            groupBoxLedRegs.TabIndex = 22;
            groupBoxLedRegs.TabStop = false;
            groupBoxLedRegs.Visible = false;
            // 
            // groupBoxRegY
            // 
            groupBoxRegY.Controls.Add(sevenSegmentRegY);
            groupBoxRegY.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBoxRegY.Location = new System.Drawing.Point(206, 14);
            groupBoxRegY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxRegY.Name = "groupBoxRegY";
            groupBoxRegY.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxRegY.Size = new System.Drawing.Size(103, 135);
            groupBoxRegY.TabIndex = 21;
            groupBoxRegY.TabStop = false;
            groupBoxRegY.Text = "Reg Y";
            // 
            // sevenSegmentRegY
            // 
            sevenSegmentRegY.ArrayCount = 2;
            sevenSegmentRegY.ColorBackground = System.Drawing.Color.Black;
            sevenSegmentRegY.ColorDark = System.Drawing.Color.DarkRed;
            sevenSegmentRegY.ColorLight = System.Drawing.Color.Red;
            sevenSegmentRegY.DecimalShow = true;
            sevenSegmentRegY.ElementPadding = new System.Windows.Forms.Padding(4);
            sevenSegmentRegY.ElementWidth = 8;
            sevenSegmentRegY.ItalicFactor = 0F;
            sevenSegmentRegY.Location = new System.Drawing.Point(7, 37);
            sevenSegmentRegY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sevenSegmentRegY.Name = "sevenSegmentRegY";
            sevenSegmentRegY.Size = new System.Drawing.Size(75, 74);
            sevenSegmentRegY.TabIndex = 21;
            sevenSegmentRegY.TabStop = false;
            sevenSegmentRegY.Value = "00";
            // 
            // groupRegA
            // 
            groupRegA.Controls.Add(sevenSegmentRegA);
            groupRegA.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupRegA.Location = new System.Drawing.Point(8, 14);
            groupRegA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupRegA.Name = "groupRegA";
            groupRegA.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupRegA.Size = new System.Drawing.Size(92, 135);
            groupRegA.TabIndex = 19;
            groupRegA.TabStop = false;
            groupRegA.Text = "Reg A";
            // 
            // sevenSegmentRegA
            // 
            sevenSegmentRegA.ArrayCount = 2;
            sevenSegmentRegA.ColorBackground = System.Drawing.Color.Black;
            sevenSegmentRegA.ColorDark = System.Drawing.Color.DarkRed;
            sevenSegmentRegA.ColorLight = System.Drawing.Color.Red;
            sevenSegmentRegA.DecimalShow = true;
            sevenSegmentRegA.ElementPadding = new System.Windows.Forms.Padding(4);
            sevenSegmentRegA.ElementWidth = 8;
            sevenSegmentRegA.ItalicFactor = 0F;
            sevenSegmentRegA.Location = new System.Drawing.Point(7, 36);
            sevenSegmentRegA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sevenSegmentRegA.Name = "sevenSegmentRegA";
            sevenSegmentRegA.Size = new System.Drawing.Size(75, 74);
            sevenSegmentRegA.TabIndex = 17;
            sevenSegmentRegA.TabStop = false;
            sevenSegmentRegA.Value = "00";
            // 
            // groupBoxRegX
            // 
            groupBoxRegX.Controls.Add(sevenSegmentRegX);
            groupBoxRegX.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBoxRegX.Location = new System.Drawing.Point(107, 14);
            groupBoxRegX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxRegX.Name = "groupBoxRegX";
            groupBoxRegX.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxRegX.Size = new System.Drawing.Size(92, 135);
            groupBoxRegX.TabIndex = 20;
            groupBoxRegX.TabStop = false;
            groupBoxRegX.Text = "Reg X";
            // 
            // sevenSegmentRegX
            // 
            sevenSegmentRegX.ArrayCount = 2;
            sevenSegmentRegX.ColorBackground = System.Drawing.Color.Black;
            sevenSegmentRegX.ColorDark = System.Drawing.Color.DarkRed;
            sevenSegmentRegX.ColorLight = System.Drawing.Color.Red;
            sevenSegmentRegX.DecimalShow = true;
            sevenSegmentRegX.ElementPadding = new System.Windows.Forms.Padding(4);
            sevenSegmentRegX.ElementWidth = 8;
            sevenSegmentRegX.ItalicFactor = 0F;
            sevenSegmentRegX.Location = new System.Drawing.Point(7, 38);
            sevenSegmentRegX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sevenSegmentRegX.Name = "sevenSegmentRegX";
            sevenSegmentRegX.Size = new System.Drawing.Size(75, 74);
            sevenSegmentRegX.TabIndex = 19;
            sevenSegmentRegX.TabStop = false;
            sevenSegmentRegX.Value = "00";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "hex";
            saveFileDialog.Filter = "HexFiles|*.hex|all files|*.*";
            // 
            // groupBoxLedSP
            // 
            groupBoxLedSP.Controls.Add(sevenSegmentSP);
            groupBoxLedSP.Controls.Add(sevenSegmentSPvalue);
            groupBoxLedSP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            groupBoxLedSP.Location = new System.Drawing.Point(694, 427);
            groupBoxLedSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLedSP.Name = "groupBoxLedSP";
            groupBoxLedSP.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxLedSP.Size = new System.Drawing.Size(315, 156);
            groupBoxLedSP.TabIndex = 24;
            groupBoxLedSP.TabStop = false;
            groupBoxLedSP.Text = "Stackpointer";
            groupBoxLedSP.Visible = false;
            // 
            // sevenSegmentSP
            // 
            sevenSegmentSP.ArrayCount = 4;
            sevenSegmentSP.ColorBackground = System.Drawing.Color.Black;
            sevenSegmentSP.ColorDark = System.Drawing.Color.DarkRed;
            sevenSegmentSP.ColorLight = System.Drawing.Color.Red;
            sevenSegmentSP.DecimalShow = true;
            sevenSegmentSP.ElementPadding = new System.Windows.Forms.Padding(4);
            sevenSegmentSP.ElementWidth = 8;
            sevenSegmentSP.ItalicFactor = 0F;
            sevenSegmentSP.Location = new System.Drawing.Point(13, 42);
            sevenSegmentSP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sevenSegmentSP.Name = "sevenSegmentSP";
            sevenSegmentSP.Size = new System.Drawing.Size(149, 74);
            sevenSegmentSP.TabIndex = 18;
            sevenSegmentSP.TabStop = false;
            sevenSegmentSP.Value = "01ff";
            // 
            // sevenSegmentSPvalue
            // 
            sevenSegmentSPvalue.ArrayCount = 2;
            sevenSegmentSPvalue.ColorBackground = System.Drawing.Color.Black;
            sevenSegmentSPvalue.ColorDark = System.Drawing.Color.DarkRed;
            sevenSegmentSPvalue.ColorLight = System.Drawing.Color.Red;
            sevenSegmentSPvalue.DecimalShow = true;
            sevenSegmentSPvalue.ElementPadding = new System.Windows.Forms.Padding(4);
            sevenSegmentSPvalue.ElementWidth = 8;
            sevenSegmentSPvalue.ItalicFactor = 0F;
            sevenSegmentSPvalue.Location = new System.Drawing.Point(172, 42);
            sevenSegmentSPvalue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sevenSegmentSPvalue.Name = "sevenSegmentSPvalue";
            sevenSegmentSPvalue.Size = new System.Drawing.Size(75, 74);
            sevenSegmentSPvalue.TabIndex = 18;
            sevenSegmentSPvalue.TabStop = false;
            sevenSegmentSPvalue.Value = "55";
            // 
            // CPU_emu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1306, 621);
            Controls.Add(groupBoxLedFlags);
            Controls.Add(groupBoxLedSP);
            Controls.Add(groupBoxLedPC);
            Controls.Add(panelMain);
            Controls.Add(groupBoxLedRegs);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CPU_emu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sim6502";
            FormClosing += CPU_emu_FormClosing;
            Load += CPU_emu_Load;
            LocationChanged += CPU_emu_LocationChanged;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxFlags.ResumeLayout(false);
            groupBoxFlags.PerformLayout();
            groupBoxRegisters.ResumeLayout(false);
            groupBoxRegisters.PerformLayout();
            groupBoxPCSP.ResumeLayout(false);
            groupBoxPCSP.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBoxStartStop.ResumeLayout(false);
            groupBoxStartStop.PerformLayout();
            panelMain.ResumeLayout(false);
            groupBoxLedFlags.ResumeLayout(false);
            groupBoxLedFlags.PerformLayout();
            groupBoxLedPC.ResumeLayout(false);
            groupBoxLedRegs.ResumeLayout(false);
            groupBoxRegY.ResumeLayout(false);
            groupRegA.ResumeLayout(false);
            groupBoxRegX.ResumeLayout(false);
            groupBoxLedSP.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
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
        private Bulb.LedBulb ledBulbFcarry;
        private System.Windows.Forms.GroupBox groupBoxLedFlags;
        private System.Windows.Forms.Label label7;
        private Bulb.LedBulb ledBulbFnegativ;
        private System.Windows.Forms.Label label6;
        private Bulb.LedBulb ledBulbFoverflow;
        private System.Windows.Forms.Label label5;
        private Bulb.LedBulb ledBulbFbreak;
        private System.Windows.Forms.Label label4;
        private Bulb.LedBulb ledBulbFdecimalmode;
        private System.Windows.Forms.Label label3;
        private Bulb.LedBulb ledBulbFintdisable;
        private System.Windows.Forms.Label label2;
        private Bulb.LedBulb ledBulbFzero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelKernal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBasic;
        private System.Windows.Forms.ToolStripMenuItem loadKernalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCharRomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem loadBasicRomToolStripMenuItem;
    }
}

