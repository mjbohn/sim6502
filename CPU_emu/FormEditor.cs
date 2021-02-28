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
    public partial class FormEditor : Form
    {
        private CPU CPU;
        private byte[] Data;

        public FormEditor(CPU Cpu)
        {
            InitializeComponent();
            CPU = Cpu;
            Data = CPU.ReadMemory();
        }

        private void buttonLoadRange_Click(object sender, EventArgs e)
        {
            DGVmemory.Rows.Clear();DGVmemory.Columns.Clear();
            
            int startAddress = (int)numericUpDown_StartAddress.Value;
            int endAddress = (int)numericUpDown_EndAddress.Value;
            
            
            DataGridViewCellStyle style = DGVmemory.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.BackColor = Color.LightYellow;
                        
            for (int i = 0; i < 16; i++)
            {
                DGVmemory.Columns.Add("c" + i.ToString("X2"), i.ToString("X"));
                DGVmemory.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (DataGridViewColumn column in DGVmemory.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DGVmemory.RowHeadersWidth = 75;

            foreach (DataGridViewColumn column in DGVmemory.Columns)
            {
                column.Width = 60;
                
            }

            //for (int i = 0; i < Data.Length; i+=16)
            for (int i = startAddress; i < endAddress; i+=16)
            {
                var index = DGVmemory.Rows.Add(); 
                for (int j = 0; j < 16; j++)
                {
                    DGVmemory.Rows[index].Cells[j].Value = Data[i+j].ToString("X2");
                    DGVmemory.Rows[index].HeaderCell.Value = i.ToString("X3");
                }
            }
                                   
        }

    }
}
