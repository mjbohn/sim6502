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

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            _address= Convert.ToUInt32(textBoxAddress.Text, 16);
        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {
            _data= Convert.ToByte(textBoxData.Text, 16);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _cpu.WriteByteToMemory(_data, (ushort)_address);
        }
    }
}
