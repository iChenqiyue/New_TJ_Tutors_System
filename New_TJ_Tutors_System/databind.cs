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



        #region 绑定数据至ComboBox
        /// <summary>
        /// 绑定查询数据库后的datatable数据
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="cmdText"></param>
        /// <param name="tb"></param>
        /// <param name="DisplayFied"></param>
        public void tablecbobind(ComboBox cbo, string cmdText, string tb, string DisplayFied)
        {
            commondb mydb = new commondb();
            DataSet mydataset;
            //            string mystr = "SELECT distinct 接待人 FROM [Table]";
            mydataset = mydb.ExecuteQuery(cmdText, tb);
            cbo.DataSource = mydataset.Tables[tb];
            cbo.DisplayMember = DisplayFied;

        }
        

        public class Info
        {
            public string Id { get; set; }
            public string Name { get; set; }

        }
        /// <summary>
        /// 绑定list数据
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="str"></param>
        public void listcbobind(ComboBox cbo,string[] str)
        {
            IList<Info> infoList = new List<Info>();
            for(int i = 0; i < str.Length; i++)
            {
                Info info = new Info() { Id = i.ToString(), Name = str[i] };
                infoList.Add(info);
            }
            cbo.DataSource = infoList;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Name";
        }
        #endregion

        #region 获得ComboBox所选项的ValueField
        public int selectedValue(ComboBox cbo)
        {
            if (cbo.SelectedIndex > -1 && cbo.SelectedValue.ToString() !=
                "System.Data.DataRowView")
                return int.Parse(cbo.SelectedValue.ToString());
            return -1;
        }
        #endregion
    }
}
