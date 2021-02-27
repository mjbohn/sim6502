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
               
        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 16; i++)
            {
                DGVmemory.Columns.Add("c" + i.ToString("X2"), i.ToString("X"));
            }

            foreach (DataGridViewColumn column in DGVmemory.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                
            }

            DataGridViewCellStyle style = DGVmemory.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DGVmemory.RowHeadersWidth = 75;

            foreach (DataGridViewColumn column in DGVmemory.Columns)
            {
                column.Width = 60;
                
            }
                       
            for (int i = 0; i < Data.Length; i+=16)
            {
                var index = DGVmemory.Rows.Add();
                for (int j = 0; j < 16; j++)
                {
                    DGVmemory.Rows[index].Cells[j].Value = Data[i+j].ToString("X2");
                    //DGVmemory.Rows[index].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DGVmemory.Rows[index].HeaderCell.Value = i.ToString("X3");
                    
                }

            }

                        
        }
    }
}
