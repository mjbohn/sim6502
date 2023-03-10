
namespace CPU_emulator
{
    partial class FormSetAddress
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
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.labelRegA = new System.Windows.Forms.Label();
            this.textBoxDataRegA = new System.Windows.Forms.TextBox();
            this.buttonSetRegA = new System.Windows.Forms.Button();
            this.buttonSetRegX = new System.Windows.Forms.Button();
            this.textBoxDataRegX = new System.Windows.Forms.TextBox();
            this.labelRegX = new System.Windows.Forms.Label();
            this.buttonSetRegY = new System.Windows.Forms.Button();
            this.textBoxDataRegY = new System.Windows.Forms.TextBox();
            this.labelRegY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(35, 12);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(55, 14);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(108, 13);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 14);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(38, 30);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(52, 22);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // textBoxData
            // 
            this.textBoxData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxData.Location = new System.Drawing.Point(96, 30);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(54, 22);
            this.textBoxData.TabIndex = 3;
            this.textBoxData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxData.TextChanged += new System.EventHandler(this.textBoxData_TextChanged);
            // 
            // buttonSet
            // 
            this.buttonSet.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSet.Location = new System.Drawing.Point(156, 29);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRegA
            // 
            this.labelRegA.AutoSize = true;
            this.labelRegA.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegA.Location = new System.Drawing.Point(35, 61);
            this.labelRegA.Name = "labelRegA";
            this.labelRegA.Size = new System.Drawing.Size(45, 14);
            this.labelRegA.TabIndex = 5;
            this.labelRegA.Text = "Reg A :";
            // 
            // textBoxDataRegA
            // 
            this.textBoxDataRegA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataRegA.Location = new System.Drawing.Point(96, 57);
            this.textBoxDataRegA.Name = "textBoxDataRegA";
            this.textBoxDataRegA.Size = new System.Drawing.Size(54, 22);
            this.textBoxDataRegA.TabIndex = 6;
            this.textBoxDataRegA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSetRegA
            // 
            this.buttonSetRegA.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetRegA.Location = new System.Drawing.Point(156, 56);
            this.buttonSetRegA.Name = "buttonSetRegA";
            this.buttonSetRegA.Size = new System.Drawing.Size(75, 23);
            this.buttonSetRegA.TabIndex = 7;
            this.buttonSetRegA.Text = "Set";
            this.buttonSetRegA.UseVisualStyleBackColor = true;
            this.buttonSetRegA.Click += new System.EventHandler(this.buttonSetRegA_Click);
            // 
            // buttonSetRegX
            // 
            this.buttonSetRegX.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetRegX.Location = new System.Drawing.Point(156, 83);
            this.buttonSetRegX.Name = "buttonSetRegX";
            this.buttonSetRegX.Size = new System.Drawing.Size(75, 23);
            this.buttonSetRegX.TabIndex = 10;
            this.buttonSetRegX.Text = "Set";
            this.buttonSetRegX.UseVisualStyleBackColor = true;
            this.buttonSetRegX.Click += new System.EventHandler(this.buttonSetRegX_Click);
            // 
            // textBoxDataRegX
            // 
            this.textBoxDataRegX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataRegX.Location = new System.Drawing.Point(96, 84);
            this.textBoxDataRegX.Name = "textBoxDataRegX";
            this.textBoxDataRegX.Size = new System.Drawing.Size(54, 22);
            this.textBoxDataRegX.TabIndex = 9;
            this.textBoxDataRegX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegX
            // 
            this.labelRegX.AutoSize = true;
            this.labelRegX.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegX.Location = new System.Drawing.Point(35, 89);
            this.labelRegX.Name = "labelRegX";
            this.labelRegX.Size = new System.Drawing.Size(44, 14);
            this.labelRegX.TabIndex = 8;
            this.labelRegX.Text = "Reg X :";
            // 
            // buttonSetRegY
            // 
            this.buttonSetRegY.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetRegY.Location = new System.Drawing.Point(156, 110);
            this.buttonSetRegY.Name = "buttonSetRegY";
            this.buttonSetRegY.Size = new System.Drawing.Size(75, 23);
            this.buttonSetRegY.TabIndex = 13;
            this.buttonSetRegY.Text = "Set";
            this.buttonSetRegY.UseVisualStyleBackColor = true;
            this.buttonSetRegY.Click += new System.EventHandler(this.buttonSetRegY_Click);
            // 
            // textBoxDataRegY
            // 
            this.textBoxDataRegY.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataRegY.Location = new System.Drawing.Point(96, 111);
            this.textBoxDataRegY.Name = "textBoxDataRegY";
            this.textBoxDataRegY.Size = new System.Drawing.Size(54, 22);
            this.textBoxDataRegY.TabIndex = 12;
            this.textBoxDataRegY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelRegY
            // 
            this.labelRegY.AutoSize = true;
            this.labelRegY.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegY.Location = new System.Drawing.Point(35, 117);
            this.labelRegY.Name = "labelRegY";
            this.labelRegY.Size = new System.Drawing.Size(44, 14);
            this.labelRegY.TabIndex = 11;
            this.labelRegY.Text = "Reg Y :";
            // 
            // FormSetAddress
            // 
            this.AcceptButton = this.buttonSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 149);
            this.Controls.Add(this.buttonSetRegY);
            this.Controls.Add(this.textBoxDataRegY);
            this.Controls.Add(this.labelRegY);
            this.Controls.Add(this.buttonSetRegX);
            this.Controls.Add(this.textBoxDataRegX);
            this.Controls.Add(this.labelRegX);
            this.Controls.Add(this.buttonSetRegA);
            this.Controls.Add(this.textBoxDataRegA);
            this.Controls.Add(this.labelRegA);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Address / Register";
            this.Load += new System.EventHandler(this.FormSetAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label labelRegA;
        private System.Windows.Forms.TextBox textBoxDataRegA;
        private System.Windows.Forms.Button buttonSetRegA;
        private System.Windows.Forms.Button buttonSetRegX;
        private System.Windows.Forms.TextBox textBoxDataRegX;
        private System.Windows.Forms.Label labelRegX;
        private System.Windows.Forms.Button buttonSetRegY;
        private System.Windows.Forms.TextBox textBoxDataRegY;
        private System.Windows.Forms.Label labelRegY;
    }
}