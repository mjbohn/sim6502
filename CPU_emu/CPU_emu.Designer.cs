﻿
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
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeropageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxCarryFlag = new System.Windows.Forms.CheckBox();
            this.groupBoxFlags = new System.Windows.Forms.GroupBox();
            this.checkBoxNegativFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxOverflowFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxDecimalModeFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxIntDisableFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxZeroFlag = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.richTextBoxMem = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRegY = new System.Windows.Forms.TextBox();
            this.labelRegY = new System.Windows.Forms.Label();
            this.textBoxRegX = new System.Windows.Forms.TextBox();
            this.labelRegX = new System.Windows.Forms.Label();
            this.textBoxRegA = new System.Windows.Forms.TextBox();
            this.labelRegA = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSP = new System.Windows.Forms.TextBox();
            this.labelSP = new System.Windows.Forms.Label();
            this.textBoxPC = new System.Windows.Forms.TextBox();
            this.labelPC = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelBRK = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxSlowDown = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxLineNum = new System.Windows.Forms.RichTextBox();
            this.groupBoxStartStop = new System.Windows.Forms.GroupBox();
            this.checkBoxLiveMemory = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFlags.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxStartStop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.memoryToolStripMenuItem,
            this.watchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1345, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dateiToolStripMenuItem.Text = "File";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.beendenToolStripMenuItem.Text = "close";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // memoryToolStripMenuItem
            // 
            this.memoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.memoryToolStripMenuItem.Name = "memoryToolStripMenuItem";
            this.memoryToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.memoryToolStripMenuItem.Text = "Memory";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stackToolStripMenuItem,
            this.zeropageToolStripMenuItem,
            this.memrangeToolStripMenuItem});
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.watchToolStripMenuItem.Text = "Watch";
            // 
            // stackToolStripMenuItem
            // 
            this.stackToolStripMenuItem.Name = "stackToolStripMenuItem";
            this.stackToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.stackToolStripMenuItem.Text = "Stack";
            this.stackToolStripMenuItem.Click += new System.EventHandler(this.stackToolStripMenuItem_Click);
            // 
            // zeropageToolStripMenuItem
            // 
            this.zeropageToolStripMenuItem.Name = "zeropageToolStripMenuItem";
            this.zeropageToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.zeropageToolStripMenuItem.Text = "Zeropage";
            this.zeropageToolStripMenuItem.Click += new System.EventHandler(this.zeropageToolStripMenuItem_Click);
            // 
            // memrangeToolStripMenuItem
            // 
            this.memrangeToolStripMenuItem.Name = "memrangeToolStripMenuItem";
            this.memrangeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.memrangeToolStripMenuItem.Text = "Memrange";
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
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // richTextBoxMem
            // 
            this.richTextBoxMem.BackColor = System.Drawing.Color.Silver;
            this.richTextBoxMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMem.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBoxMem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMem.Location = new System.Drawing.Point(117, 0);
            this.richTextBoxMem.Name = "richTextBoxMem";
            this.richTextBoxMem.ReadOnly = true;
            this.richTextBoxMem.Size = new System.Drawing.Size(691, 795);
            this.richTextBoxMem.TabIndex = 5;
            this.richTextBoxMem.Text = "";
            this.richTextBoxMem.VScroll += new System.EventHandler(this.richTextBoxMem_VScroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRegY);
            this.groupBox1.Controls.Add(this.labelRegY);
            this.groupBox1.Controls.Add(this.textBoxRegX);
            this.groupBox1.Controls.Add(this.labelRegX);
            this.groupBox1.Controls.Add(this.textBoxRegA);
            this.groupBox1.Controls.Add(this.labelRegA);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(180, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSP);
            this.groupBox2.Controls.Add(this.labelSP);
            this.groupBox2.Controls.Add(this.textBoxPC);
            this.groupBox2.Controls.Add(this.labelPC);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(180, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // textBoxSP
            // 
            this.textBoxSP.Location = new System.Drawing.Point(38, 51);
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
            this.labelSP.Location = new System.Drawing.Point(6, 54);
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
            this.labelPC.Location = new System.Drawing.Point(6, 25);
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
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
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
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Stepping";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelBRK,
            this.toolStripStatusElapsedTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 827);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1345, 22);
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
            // checkBoxSlowDown
            // 
            this.checkBoxSlowDown.AutoSize = true;
            this.checkBoxSlowDown.Location = new System.Drawing.Point(6, 144);
            this.checkBoxSlowDown.Name = "checkBoxSlowDown";
            this.checkBoxSlowDown.Size = new System.Drawing.Size(60, 20);
            this.checkBoxSlowDown.TabIndex = 14;
            this.checkBoxSlowDown.Text = "Slow";
            this.checkBoxSlowDown.UseVisualStyleBackColor = true;
            this.checkBoxSlowDown.CheckedChanged += new System.EventHandler(this.checkBoxSlowDown_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBoxMem);
            this.panel1.Controls.Add(this.richTextBoxLineNum);
            this.panel1.Location = new System.Drawing.Point(523, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 797);
            this.panel1.TabIndex = 15;
            // 
            // richTextBoxLineNum
            // 
            this.richTextBoxLineNum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBoxLineNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLineNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxLineNum.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLineNum.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLineNum.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.richTextBoxLineNum.Name = "richTextBoxLineNum";
            this.richTextBoxLineNum.ReadOnly = true;
            this.richTextBoxLineNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBoxLineNum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxLineNum.Size = new System.Drawing.Size(114, 795);
            this.richTextBoxLineNum.TabIndex = 6;
            this.richTextBoxLineNum.Text = "";
            this.richTextBoxLineNum.VScroll += new System.EventHandler(this.richTextBoxLineNum_VScroll);
            // 
            // groupBoxStartStop
            // 
            this.groupBoxStartStop.Controls.Add(this.checkBoxLiveMemory);
            this.groupBoxStartStop.Controls.Add(this.buttonStart);
            this.groupBoxStartStop.Controls.Add(this.buttonStop);
            this.groupBoxStartStop.Controls.Add(this.checkBoxSlowDown);
            this.groupBoxStartStop.Controls.Add(this.buttonReset);
            this.groupBoxStartStop.Controls.Add(this.checkBox1);
            this.groupBoxStartStop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStartStop.Location = new System.Drawing.Point(321, 13);
            this.groupBoxStartStop.Name = "groupBoxStartStop";
            this.groupBoxStartStop.Size = new System.Drawing.Size(169, 223);
            this.groupBoxStartStop.TabIndex = 16;
            this.groupBoxStartStop.TabStop = false;
            this.groupBoxStartStop.Text = "Start/Stop";
            // 
            // checkBoxLiveMemory
            // 
            this.checkBoxLiveMemory.AutoSize = true;
            this.checkBoxLiveMemory.Checked = true;
            this.checkBoxLiveMemory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLiveMemory.Location = new System.Drawing.Point(6, 169);
            this.checkBoxLiveMemory.Name = "checkBoxLiveMemory";
            this.checkBoxLiveMemory.Size = new System.Drawing.Size(91, 20);
            this.checkBoxLiveMemory.TabIndex = 15;
            this.checkBoxLiveMemory.Text = "LiveMem";
            this.checkBoxLiveMemory.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBoxStartStop);
            this.panel2.Controls.Add(this.groupBoxFlags);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 795);
            this.panel2.TabIndex = 16;
            // 
            // CPU_emu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 849);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CPU_emu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU emu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFlags.ResumeLayout(false);
            this.groupBoxFlags.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxStartStop.ResumeLayout(false);
            this.groupBoxStartStop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxCarryFlag;
        private System.Windows.Forms.GroupBox groupBoxFlags;
        private System.Windows.Forms.CheckBox checkBoxZeroFlag;
        private System.Windows.Forms.CheckBox checkBoxDecimalModeFlag;
        private System.Windows.Forms.CheckBox checkBoxIntDisableFlag;
        private System.Windows.Forms.CheckBox checkBoxBreakFlag;
        private System.Windows.Forms.CheckBox checkBoxNegativFlag;
        private System.Windows.Forms.CheckBox checkBoxOverflowFlag;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox richTextBoxMem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRegA;
        private System.Windows.Forms.Label labelRegA;
        private System.Windows.Forms.TextBox textBoxRegY;
        private System.Windows.Forms.Label labelRegY;
        private System.Windows.Forms.TextBox textBoxRegX;
        private System.Windows.Forms.Label labelRegX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPC;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.TextBox textBoxSP;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox checkBoxSlowDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxLineNum;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBRK;
        private System.Windows.Forms.ToolStripMenuItem memoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusElapsedTime;
        private System.Windows.Forms.GroupBox groupBoxStartStop;
        private System.Windows.Forms.CheckBox checkBoxLiveMemory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeropageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memrangeToolStripMenuItem;
    }
}

