using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace New_TJ_Tutors_System
{
    class databind
    {
        public void dgvbind(DataGridView dgv, string mystr, string tb)//绑定数据的自定义方法
        {
            commondb mydb = new commondb();
            DataSet mydataset = mydb.ExecuteQuery(mystr, tb);
            dgv.DataSource = mydataset.Tables[tb];
        }
    }
}
