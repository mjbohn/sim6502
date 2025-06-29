
namespace CPU_emulator
{
    partial class FormConfigSettings
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
            this.components = new System.ComponentModel.Container();
            this.configPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.PGcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PGcontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // configPropertyGrid
            // 
            this.configPropertyGrid.ContextMenuStrip = this.PGcontextMenuStrip;
            this.configPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.configPropertyGrid.Name = "configPropertyGrid";
            this.configPropertyGrid.Size = new System.Drawing.Size(388, 407);
            this.configPropertyGrid.TabIndex = 0;
            // 
            // PGcontextMenuStrip
            // 
            this.PGcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.PGcontextMenuStrip.Name = "PGcontextMenuStrip";
            this.PGcontextMenuStrip.Size = new System.Drawing.Size(103, 26);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // FormConfigSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 407);
            this.Controls.Add(this.configPropertyGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfigSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.PGcontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid configPropertyGrid;
        private System.Windows.Forms.ContextMenuStrip PGcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}