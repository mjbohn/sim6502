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
            Cpu.onFlagsUpdate += Cpu_onFlagsUpdate;
            Cpu.reset();
        }

        private void Cpu_onFlagsUpdate(object sender, EventArgs e)
        {
            label1.Text = "onFlagsUpdate";
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
