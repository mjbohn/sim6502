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
    public partial class FormConfigSettings : Form
    {
       
        public FormConfigSettings(ref ConfigSettings config)
        {
            InitializeComponent();
            
            configPropertyGrid.SelectedObject = config;
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configPropertyGrid.ResetSelectedProperty();
        }
    }
}
