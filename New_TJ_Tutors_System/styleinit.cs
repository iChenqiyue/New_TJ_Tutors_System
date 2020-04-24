using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_TJ_Tutors_System
{
    class styleinit
    {
        #region 设置DataGridView风格
        public void ColorDataGridView(DataGridView dgv)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv.Font = new System.Drawing.Font("微软雅黑",9f);
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //   dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.BackgroundColor=System.Drawing.Color.FromArgb(45, 66, 91);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;



        }
        #endregion
    }
}
