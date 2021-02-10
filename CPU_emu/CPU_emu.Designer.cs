
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxCarryFlag = new System.Windows.Forms.CheckBox();
            this.groupBoxFlags = new System.Windows.Forms.GroupBox();
            this.checkBoxNegativFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxOverflowFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxBreakFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxDecimalModeFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxIntDisableFlag = new System.Windows.Forms.CheckBox();
            this.checkBoxZeroFlag = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRegA = new System.Windows.Forms.Label();
            this.textBoxRegA = new System.Windows.Forms.TextBox();
            this.textBoxRegX = new System.Windows.Forms.TextBox();
            this.labelRegX = new System.Windows.Forms.Label();
            this.textBoxRegY = new System.Windows.Forms.TextBox();
            this.labelRegY = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPC = new System.Windows.Forms.TextBox();
            this.labelPC = new System.Windows.Forms.Label();
            this.textBoxSP = new System.Windows.Forms.TextBox();
            this.labelSP = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFlags.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1017, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.beendenToolStripMenuItem.Text = "beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // checkBoxCarryFlag
            // 
            this.checkBoxCarryFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxCarryFlag.AutoCheck = false;
            this.checkBoxCarryFlag.AutoSize = true;
            this.checkBoxCarryFlag.Checked = true;
            this.checkBoxCarryFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCarryFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarryFlag.Location = new System.Drawing.Point(6, 19);
            this.checkBoxCarryFlag.Name = "checkBoxCarryFlag";
            this.checkBoxCarryFlag.Size = new System.Drawing.Size(90, 26);
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
            this.groupBoxFlags.Location = new System.Drawing.Point(12, 27);
            this.groupBoxFlags.Name = "groupBoxFlags";
            this.groupBoxFlags.Size = new System.Drawing.Size(162, 220);
            this.groupBoxFlags.TabIndex = 2;
            this.groupBoxFlags.TabStop = false;
            this.groupBoxFlags.Text = "Flags";
            // 
            // checkBoxNegativFlag
            // 
            this.checkBoxNegativFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxNegativFlag.AutoCheck = false;
            this.checkBoxNegativFlag.AutoSize = true;
            this.checkBoxNegativFlag.Checked = true;
            this.checkBoxNegativFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNegativFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNegativFlag.Location = new System.Drawing.Point(6, 175);
            this.checkBoxNegativFlag.Name = "checkBoxNegativFlag";
            this.checkBoxNegativFlag.Size = new System.Drawing.Size(114, 26);
            this.checkBoxNegativFlag.TabIndex = 7;
            this.checkBoxNegativFlag.Tag = "N";
            this.checkBoxNegativFlag.Text = "Negativ  [N]";
            this.checkBoxNegativFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverflowFlag
            // 
            this.checkBoxOverflowFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxOverflowFlag.AutoCheck = false;
            this.checkBoxOverflowFlag.AutoSize = true;
            this.checkBoxOverflowFlag.Checked = true;
            this.checkBoxOverflowFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOverflowFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOverflowFlag.Location = new System.Drawing.Point(6, 149);
            this.checkBoxOverflowFlag.Name = "checkBoxOverflowFlag";
            this.checkBoxOverflowFlag.Size = new System.Drawing.Size(114, 26);
            this.checkBoxOverflowFlag.TabIndex = 6;
            this.checkBoxOverflowFlag.Tag = "V";
            this.checkBoxOverflowFlag.Text = "Overflow [V]";
            this.checkBoxOverflowFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxBreakFlag
            // 
            this.checkBoxBreakFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxBreakFlag.AutoCheck = false;
            this.checkBoxBreakFlag.AutoSize = true;
            this.checkBoxBreakFlag.Checked = true;
            this.checkBoxBreakFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBreakFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBreakFlag.Location = new System.Drawing.Point(6, 123);
            this.checkBoxBreakFlag.Name = "checkBoxBreakFlag";
            this.checkBoxBreakFlag.Size = new System.Drawing.Size(90, 26);
            this.checkBoxBreakFlag.TabIndex = 5;
            this.checkBoxBreakFlag.Tag = "B";
            this.checkBoxBreakFlag.Text = "Break [B]";
            this.checkBoxBreakFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxDecimalModeFlag
            // 
            this.checkBoxDecimalModeFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDecimalModeFlag.AutoCheck = false;
            this.checkBoxDecimalModeFlag.AutoSize = true;
            this.checkBoxDecimalModeFlag.Checked = true;
            this.checkBoxDecimalModeFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDecimalModeFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDecimalModeFlag.Location = new System.Drawing.Point(6, 97);
            this.checkBoxDecimalModeFlag.Name = "checkBoxDecimalModeFlag";
            this.checkBoxDecimalModeFlag.Size = new System.Drawing.Size(138, 26);
            this.checkBoxDecimalModeFlag.TabIndex = 4;
            this.checkBoxDecimalModeFlag.Tag = "D";
            this.checkBoxDecimalModeFlag.Text = "DecimalMode [D]";
            this.checkBoxDecimalModeFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxIntDisableFlag
            // 
            this.checkBoxIntDisableFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxIntDisableFlag.AutoCheck = false;
            this.checkBoxIntDisableFlag.AutoSize = true;
            this.checkBoxIntDisableFlag.Checked = true;
            this.checkBoxIntDisableFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIntDisableFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIntDisableFlag.Location = new System.Drawing.Point(6, 71);
            this.checkBoxIntDisableFlag.Name = "checkBoxIntDisableFlag";
            this.checkBoxIntDisableFlag.Size = new System.Drawing.Size(138, 26);
            this.checkBoxIntDisableFlag.TabIndex = 3;
            this.checkBoxIntDisableFlag.Tag = "I";
            this.checkBoxIntDisableFlag.Text = "intDisable  [I]";
            this.checkBoxIntDisableFlag.UseVisualStyleBackColor = true;
            // 
            // checkBoxZeroFlag
            // 
            this.checkBoxZeroFlag.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxZeroFlag.AutoCheck = false;
            this.checkBoxZeroFlag.AutoSize = true;
            this.checkBoxZeroFlag.Checked = true;
            this.checkBoxZeroFlag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxZeroFlag.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxZeroFlag.Location = new System.Drawing.Point(6, 45);
            this.checkBoxZeroFlag.Name = "checkBoxZeroFlag";
            this.checkBoxZeroFlag.Size = new System.Drawing.Size(90, 26);
            this.checkBoxZeroFlag.TabIndex = 2;
            this.checkBoxZeroFlag.Tag = "Z";
            this.checkBoxZeroFlag.Text = "Zero  [Z]";
            this.checkBoxZeroFlag.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(161, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(257, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(748, 561);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registers";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSP);
            this.groupBox2.Controls.Add(this.labelSP);
            this.groupBox2.Controls.Add(this.textBoxPC);
            this.groupBox2.Controls.Add(this.labelPC);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
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
            // CPU_emu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxFlags);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
    }
}

