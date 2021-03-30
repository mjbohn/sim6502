
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
            this.richTextBoxLineNum = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMem = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxStartAddress = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxEndAddress = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxLineNum
            // 
            this.richTextBoxLineNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLineNum.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBoxLineNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLineNum.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLineNum.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLineNum.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.richTextBoxLineNum.Name = "richTextBoxLineNum";
            this.richTextBoxLineNum.ReadOnly = true;
            this.richTextBoxLineNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBoxLineNum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxLineNum.Size = new System.Drawing.Size(61, 296);
            this.richTextBoxLineNum.TabIndex = 7;
            this.richTextBoxLineNum.Text = "";
            this.richTextBoxLineNum.VScroll += new System.EventHandler(this.richTextBoxLineNum_VScroll);
            // 
            // richTextBoxMem
            // 
            this.richTextBoxMem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMem.BackColor = System.Drawing.Color.Silver;
            this.richTextBoxMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMem.Location = new System.Drawing.Point(61, 0);
            this.richTextBoxMem.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.richTextBoxMem.Name = "richTextBoxMem";
            this.richTextBoxMem.ReadOnly = true;
            this.richTextBoxMem.Size = new System.Drawing.Size(573, 296);
            this.richTextBoxMem.TabIndex = 8;
            this.richTextBoxMem.Text = "";
            this.richTextBoxMem.VScroll += new System.EventHandler(this.richTextBoxMem_VScroll);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxStartAddress,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripTextBoxEndAddress,
            this.toolStripSeparator2,
            this.toolStripButtonLoad,
            this.toolStripButtonCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 299);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel1.Text = "Start:";
            // 
            // toolStripTextBoxStartAddress
            // 
            this.toolStripTextBoxStartAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxStartAddress.Name = "toolStripTextBoxStartAddress";
            this.toolStripTextBoxStartAddress.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxStartAddress.Enter += new System.EventHandler(this.toolStripTextBoxStartAddress_Enter);
            this.toolStripTextBoxStartAddress.TextChanged += new System.EventHandler(this.toolStripTextBoxStartAddress_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel2.Text = "End: ";
            // 
            // toolStripTextBoxEndAddress
            // 
            this.toolStripTextBoxEndAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxEndAddress.Name = "toolStripTextBoxEndAddress";
            this.toolStripTextBoxEndAddress.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxEndAddress.Enter += new System.EventHandler(this.toolStripTextBoxEndAddress_Enter);
            this.toolStripTextBoxEndAddress.TextChanged += new System.EventHandler(this.toolStripTextBoxEndAddress_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoad.Enabled = false;
            this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(34, 22);
            this.toolStripButtonLoad.Text = "load";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancel.Enabled = false;
            this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(45, 22);
            this.toolStripButtonCancel.Text = "cancel";
            this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
            // 
            // MemoryWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 324);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBoxMem);
            this.Controls.Add(this.richTextBoxLineNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MemoryWatchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemoryWatchForm_FormClosing);
            this.Load += new System.EventHandler(this.MemoryWatchForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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