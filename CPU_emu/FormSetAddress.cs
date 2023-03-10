using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_emulator
{
    public partial class FormSetAddress : Form
    {
        private CPU _cpu;
        private uint _address;
        private byte _data;

        public FormSetAddress(ref CPU cpu)
        {
            InitializeComponent();
            this._cpu = cpu;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            _address= Convert.ToUInt32(textBoxAddress.Text, 16);
        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {
            if (textBoxData.Text!= String.Empty)
            {
                _data = Convert.ToByte(textBoxData.Text, 16); 
            }
            else
            {
                _data = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _cpu.WriteByteToMemory(_data, (ushort)_address);
        }

        private void FormSetAddress_Load(object sender, EventArgs e)
        {
            textBoxDataRegA.Text = _cpu.A.ToString("X2");
            textBoxDataRegX.Text = _cpu.X.ToString("X2");
            textBoxDataRegY.Text = _cpu.Y.ToString("X2");
        }

        private void buttonSetRegA_Click(object sender, EventArgs e)
        {
            _cpu.SetRegister("A", Convert.ToByte(textBoxDataRegA.Text, 16));
        }

        private void buttonSetRegX_Click(object sender, EventArgs e)
        {
            _cpu.SetRegister("X", Convert.ToByte(textBoxDataRegX.Text, 16));
        }

        private void buttonSetRegY_Click(object sender, EventArgs e)
        {
            _cpu.SetRegister("Y", Convert.ToByte(textBoxDataRegY.Text, 16));
        }
    }
}
