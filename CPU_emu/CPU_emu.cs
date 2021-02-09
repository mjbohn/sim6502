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
    public partial class CPU_emu : Form
    {
        CPU Cpu ;
        
        public CPU_emu()
        {
            InitializeComponent();
            
            Cpu = new CPU();
            Cpu.OnFlagsUpdate += Cpu_onFlagsUpdate;
            Cpu.Reset();
        }

        private void Cpu_onFlagsUpdate(object sender, EventArgs e)
        {
            GetCpuFlags();
            
        }

        private void GetCpuFlags()
        {
            foreach (CheckBox checkBox in groupBoxFlags.Controls)
            {
                checkBox.Checked = Cpu.flags[checkBox.Tag.ToString()];
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
