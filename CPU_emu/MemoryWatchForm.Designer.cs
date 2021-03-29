
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
            this.richTextBoxLineNum = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMem = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
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
            this.richTextBoxLineNum.Size = new System.Drawing.Size(86, 397);
            this.richTextBoxLineNum.TabIndex = 7;
            this.richTextBoxLineNum.Text = "";
            // 
            // richTextBoxMem
            // 
            this.richTextBoxMem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMem.BackColor = System.Drawing.Color.Silver;
            this.richTextBoxMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMem.Location = new System.Drawing.Point(86, 0);
            this.richTextBoxMem.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.richTextBoxMem.Name = "richTextBoxMem";
            this.richTextBoxMem.ReadOnly = true;
            this.richTextBoxMem.Size = new System.Drawing.Size(622, 397);
            this.richTextBoxMem.TabIndex = 8;
            this.richTextBoxMem.Text = "";
            // 
            // MemoryWatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 397);
            this.Controls.Add(this.richTextBoxMem);
            this.Controls.Add(this.richTextBoxLineNum);
            this.MaximizeBox = false;
            this.Name = "MemoryWatchForm";
            this.ShowIcon = false;
            this.Text = "Stack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemoryWatchForm_FormClosing);
            this.Load += new System.EventHandler(this.MemoryWatchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLineNum;
        private System.Windows.Forms.RichTextBox richTextBoxMem;
    }
}