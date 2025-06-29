using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private bool _dataChanged = false;

        public FormEditor(CPU Cpu)
        {
            InitializeComponent();
            CPU = Cpu;
            Data = CPU.ReadMemory();
        }

        private void ButtonLoadRange_Click(object sender, EventArgs e)
        {

            if (_dataChanged && (MessageBox.Show("Discard changes and reload?", "There are unsaved changes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel))
            {
                return;
            }

            LoadDatagrid();

        }

        private void LoadDatagrid()
        {
            DGVmemory.Rows.Clear(); DGVmemory.Columns.Clear();

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

            for (int i = startAddress; i < endAddress; i += 16)
            {
                var index = DGVmemory.Rows.Add();
                for (int j = 0; j < 16; j++)
                {
                    DGVmemory.Rows[index].Cells[j].Value = Data[i + j].ToString("X2");
                    DGVmemory.Rows[index].HeaderCell.Value = i.ToString("X3");
                }
            }

            _dataChanged = false;
            buttonSave.Enabled = false;
        }

        private void ContextMenuSetStartAdrToZero_Click(object sender, EventArgs e)
        {
            numericUpDown_StartAddress.Value = 0;
        }

        private void ContextMenuSetStartAdrToMax_Click(object sender, EventArgs e)
        {
            numericUpDown_EndAddress.Value = 0xffff;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int startAddress = (int)numericUpDown_StartAddress.Value;
            int endAddress = (int)numericUpDown_EndAddress.Value;
            byte[] data = new byte[endAddress - startAddress];
            int offset = 0;

            buttonSave.Enabled = false;

            for (int i = 0; i <= DGVmemory.Rows.Count-1; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    data[offset] = Convert.ToByte( DGVmemory.Rows[i].Cells[j].Value.ToString(),16 );
                    
                    offset++;
                }
            }

            CPU.UpdateMemoryRange(data, startAddress);
            _dataChanged = false;
            LoadDatagrid();

        }

        private void DGVmemory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell dc = null;

            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
               dc = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex]; 
            }

            if (dc != null && dc.IsInEditMode)
            {
                dc.Style.BackColor = Color.Yellow;
                _dataChanged = true;
            }

            buttonSave.Enabled = _dataChanged;
        }

        private void FormEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dataChanged && (MessageBox.Show("Discard changes and close?","There are unsaved changes!",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.Cancel))
            {
                e.Cancel = true;
            }
        }

        private void DGVmemory_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            
            bool parsed = int.TryParse(e.FormattedValue.ToString(), System.Globalization.NumberStyles.HexNumber, null, out int value);

            if ( !parsed
                || value < 0 
                || value > 255)
            {
                e.Cancel = true;
                dgv.Rows[e.RowIndex].ErrorText = "Value must be hexvalue between 00 and FF";
            }
        }

        private void DGVmemory_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.Rows[e.RowIndex].ErrorText = String.Empty;
            dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToUpper().PadLeft(2,'0');
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
