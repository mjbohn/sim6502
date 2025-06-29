
namespace CPU_emulator
{
    partial class MemoryWatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoryWatchForm));
            richTextBoxLineNum = new System.Windows.Forms.RichTextBox();
            richTextBoxMem = new System.Windows.Forms.RichTextBox();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            toolStripTextBoxStartAddress = new System.Windows.Forms.ToolStripTextBox();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            toolStripTextBoxEndAddress = new System.Windows.Forms.ToolStripTextBox();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxLineNum
            // 
            richTextBoxLineNum.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBoxLineNum.BackColor = System.Drawing.Color.LightSteelBlue;
            richTextBoxLineNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBoxLineNum.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            richTextBoxLineNum.Location = new System.Drawing.Point(0, 0);
            richTextBoxLineNum.Margin = new System.Windows.Forms.Padding(4, 3, 0, 3);
            richTextBoxLineNum.Name = "richTextBoxLineNum";
            richTextBoxLineNum.ReadOnly = true;
            richTextBoxLineNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            richTextBoxLineNum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            richTextBoxLineNum.Size = new System.Drawing.Size(61, 317);
            richTextBoxLineNum.TabIndex = 7;
            richTextBoxLineNum.Text = "";
            richTextBoxLineNum.VScroll += richTextBoxLineNum_VScroll;
            // 
            // richTextBoxMem
            // 
            richTextBoxMem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBoxMem.BackColor = System.Drawing.Color.Silver;
            richTextBoxMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            richTextBoxMem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            richTextBoxMem.Location = new System.Drawing.Point(71, 0);
            richTextBoxMem.Margin = new System.Windows.Forms.Padding(0, 3, 4, 3);
            richTextBoxMem.Name = "richTextBoxMem";
            richTextBoxMem.ReadOnly = true;
            richTextBoxMem.Size = new System.Drawing.Size(572, 317);
            richTextBoxMem.TabIndex = 8;
            richTextBoxMem.Text = "";
            richTextBoxMem.VScroll += richTextBoxMem_VScroll;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripLabel1, toolStripTextBoxStartAddress, toolStripSeparator1, toolStripLabel2, toolStripTextBoxEndAddress, toolStripSeparator2, toolStripButtonLoad, toolStripButtonCancel });
            toolStrip1.Location = new System.Drawing.Point(0, 345);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(740, 29);
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.Visible = false;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(34, 26);
            toolStripLabel1.Text = "Start:";
            // 
            // toolStripTextBoxStartAddress
            // 
            toolStripTextBoxStartAddress.Name = "toolStripTextBoxStartAddress";
            toolStripTextBoxStartAddress.Size = new System.Drawing.Size(116, 29);
            toolStripTextBoxStartAddress.Enter += ToolStripTextBoxStartAddress_Enter;
            toolStripTextBoxStartAddress.TextChanged += ToolStripTextBoxStartAddress_TextChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new System.Drawing.Size(33, 26);
            toolStripLabel2.Text = "End: ";
            // 
            // toolStripTextBoxEndAddress
            // 
            toolStripTextBoxEndAddress.Name = "toolStripTextBoxEndAddress";
            toolStripTextBoxEndAddress.Size = new System.Drawing.Size(116, 29);
            toolStripTextBoxEndAddress.Enter += ToolStripTextBoxEndAddress_Enter;
            toolStripTextBoxEndAddress.TextChanged += ToolStripTextBoxEndAddress_TextChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripButtonLoad
            // 
            toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButtonLoad.Enabled = false;
            toolStripButtonLoad.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonLoad.Image");
            toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonLoad.Name = "toolStripButtonLoad";
            toolStripButtonLoad.Size = new System.Drawing.Size(34, 26);
            toolStripButtonLoad.Text = "load";
            toolStripButtonLoad.Click += ToolStripButtonLoad_Click;
            // 
            // toolStripButtonCancel
            // 
            toolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripButtonCancel.Enabled = false;
            toolStripButtonCancel.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonCancel.Image");
            toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonCancel.Name = "toolStripButtonCancel";
            toolStripButtonCancel.Size = new System.Drawing.Size(45, 26);
            toolStripButtonCancel.Text = "cancel";
            toolStripButtonCancel.Click += ToolStripButtonCancel_Click;
            // 
            // MemoryWatchForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(644, 349);
            Controls.Add(toolStrip1);
            Controls.Add(richTextBoxMem);
            Controls.Add(richTextBoxLineNum);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MemoryWatchForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Stack";
            FormClosing += MemoryWatchForm_FormClosing;
            Load += MemoryWatchForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLineNum;
        private System.Windows.Forms.RichTextBox richTextBoxMem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxStartAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxEndAddress;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
    }
}