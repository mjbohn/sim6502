
namespace CPU_emulator
{
    partial class FormEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVmemory = new System.Windows.Forms.DataGridView();
            this.buttonLoadRange = new System.Windows.Forms.Button();
            this.numericUpDown_StartAddress = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_EndAddress = new System.Windows.Forms.NumericUpDown();
            this.labelStartAddress = new System.Windows.Forms.Label();
            this.labelEndAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StartAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EndAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVmemory
            // 
            this.DGVmemory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVmemory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVmemory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVmemory.Location = new System.Drawing.Point(12, 12);
            this.DGVmemory.Name = "DGVmemory";
            this.DGVmemory.Size = new System.Drawing.Size(1135, 600);
            this.DGVmemory.TabIndex = 1;
            // 
            // buttonLoadRange
            // 
            this.buttonLoadRange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadRange.Location = new System.Drawing.Point(12, 686);
            this.buttonLoadRange.Name = "buttonLoadRange";
            this.buttonLoadRange.Size = new System.Drawing.Size(212, 23);
            this.buttonLoadRange.TabIndex = 2;
            this.buttonLoadRange.Text = "Load Range";
            this.buttonLoadRange.UseVisualStyleBackColor = true;
            this.buttonLoadRange.Click += new System.EventHandler(this.buttonLoadRange_Click);
            // 
            // numericUpDown_StartAddress
            // 
            this.numericUpDown_StartAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_StartAddress.Hexadecimal = true;
            this.numericUpDown_StartAddress.Increment = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDown_StartAddress.Location = new System.Drawing.Point(104, 628);
            this.numericUpDown_StartAddress.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_StartAddress.Name = "numericUpDown_StartAddress";
            this.numericUpDown_StartAddress.ReadOnly = true;
            this.numericUpDown_StartAddress.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_StartAddress.TabIndex = 3;
            this.numericUpDown_StartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_StartAddress.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // numericUpDown_EndAddress
            // 
            this.numericUpDown_EndAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_EndAddress.Hexadecimal = true;
            this.numericUpDown_EndAddress.Increment = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDown_EndAddress.Location = new System.Drawing.Point(104, 654);
            this.numericUpDown_EndAddress.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_EndAddress.Name = "numericUpDown_EndAddress";
            this.numericUpDown_EndAddress.ReadOnly = true;
            this.numericUpDown_EndAddress.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_EndAddress.TabIndex = 4;
            this.numericUpDown_EndAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_EndAddress.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            // 
            // labelStartAddress
            // 
            this.labelStartAddress.AutoSize = true;
            this.labelStartAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartAddress.Location = new System.Drawing.Point(12, 628);
            this.labelStartAddress.Name = "labelStartAddress";
            this.labelStartAddress.Size = new System.Drawing.Size(86, 15);
            this.labelStartAddress.TabIndex = 5;
            this.labelStartAddress.Text = "Start Address";
            // 
            // labelEndAddress
            // 
            this.labelEndAddress.AutoSize = true;
            this.labelEndAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndAddress.Location = new System.Drawing.Point(12, 655);
            this.labelEndAddress.Name = "labelEndAddress";
            this.labelEndAddress.Size = new System.Drawing.Size(79, 15);
            this.labelEndAddress.TabIndex = 6;
            this.labelEndAddress.Text = "End Address";
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 721);
            this.Controls.Add(this.labelEndAddress);
            this.Controls.Add(this.labelStartAddress);
            this.Controls.Add(this.numericUpDown_EndAddress);
            this.Controls.Add(this.numericUpDown_StartAddress);
            this.Controls.Add(this.buttonLoadRange);
            this.Controls.Add(this.DGVmemory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.DGVmemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StartAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EndAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVmemory;
        private System.Windows.Forms.Button buttonLoadRange;
        private System.Windows.Forms.NumericUpDown numericUpDown_StartAddress;
        private System.Windows.Forms.NumericUpDown numericUpDown_EndAddress;
        private System.Windows.Forms.Label labelStartAddress;
        private System.Windows.Forms.Label labelEndAddress;
    }
}