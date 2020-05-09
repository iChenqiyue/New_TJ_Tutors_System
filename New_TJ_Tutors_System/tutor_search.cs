using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_TJ_Tutors_System
{
    public delegate void tutorselectHandler(string num, string name);  //定义委托

    public partial class tutor_search : Form
    {

        
        public event tutorselectHandler tutorselected;  //定义事件


        //全局变量
        styleinit dgvstyle = new styleinit();
        databind dgvbind = new databind();
        commondb mydb = new commondb();
        string select_tutor_str = "select tutor_num as 教员编号,name as 姓名,student_num as 学号,subject as 专业,degree as 学位," +
            "sex as 性别,phone as 联系方式,place as 生源地,blacklist as 是否黑名单,remarks as 备注 from tutor ";
        private bool dragging = false;
        private Point startpoint = new Point(0, 0);




        public tutor_search()
        {
            InitializeComponent();
        }


        #region 窗口初始化
        private void tutor_search_Load(object sender, EventArgs e)
        {

            //初始化控件
            txt_num_search.Text = "教员编号";
            txt_name_search.Text = "教员姓名";
            txt_stunum_search.Text = "学号";
            txt_phone_search.Text = "联系方式";



            dgvstyle.ColorDataGridView(dgv_search);
            dgvfresh();
        }

        #endregion

        #region textbox控件初始化
        private void txt_num_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_num_search_Enter(object sender, EventArgs e)
        {
            if (txt_num_search.Text.Trim() == "教员编号")
            {
                txt_num_search.Text = "";
            }
        }

        private void txt_num_search_Leave(object sender, EventArgs e)
        {
            if (txt_num_search.Text.Trim().Length == 0)
            {
                txt_num_search.Text = "教员编号";
            }
        }

        private void txt_name_search_Enter(object sender, EventArgs e)
        {
            if (txt_name_search.Text.Trim() == "教员姓名")
            {
                txt_name_search.Text = "";
            }
        }

        private void txt_name_search_Leave(object sender, EventArgs e)
        {
            if (txt_name_search.Text.Trim().Length == 0)
            {
                txt_name_search.Text = "教员姓名";
            }
        }

        private void txt_stunum_search_Enter(object sender, EventArgs e)
        {
            if (txt_stunum_search.Text.Trim() == "学号")
            {
                txt_stunum_search.Text = "";
            }
        }

        private void txt_stunum_search_Leave(object sender, EventArgs e)
        {
            if (txt_stunum_search.Text.Trim().Length == 0)
            {
                txt_stunum_search.Text = "学号";
            }
        }

        private void txt_stunum_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_phone_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_phone_search_Enter(object sender, EventArgs e)
        {
            if (txt_phone_search.Text.Trim() == "联系方式")
            {
                txt_phone_search.Text = "";
            }
        }

        private void txt_phone_search_Leave(object sender, EventArgs e)
        {
            if (txt_phone_search.Text.Trim().Length == 0)
            {
                txt_phone_search.Text = "联系方式";
            }
        }
        #endregion

        #region 功能函数
        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool is_empty(string str)
        {
            if (str == "")
                return true;
            else
                return false;
        }
        /// <summary>
        /// 刷新表格
        /// </summary>
        public void dgvfresh()
        {
            string mysql = select_tutor_str + "where blacklist='否' order by tutor_num desc"; 
            string tablename = "tutor";          
            dgvbind.dgvbind(dgv_search, mysql, tablename);
        }

        #endregion


        #region 搜索和筛选
        /// <summary>
        /// 搜索教员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            string mysql = "";
            string tablename = "tutor";
            string num = txt_num_search.Text.Trim();
            string name = txt_name_search.Text.Trim();
            string stunum = txt_stunum_search.Text.Trim();
            string phone = txt_phone_search.Text.Trim();

            if (num == "教员编号" && name == "教员姓名" && stunum == "学号" && phone == "联系方式")
            {
                mysql = select_tutor_str + "order by tutor_num desc";
                dgvbind.dgvbind(dgv_search, mysql, "tutor");
                return;
            }
            string tempstr = "";
            if (num != "教员编号")
                tempstr = "tutor_num Like '%" + num + "%'";
            if (name != "教员姓名")
            {
                if (tempstr == "")
                    tempstr = "name Like '%" + name + "%'";
                else
                    tempstr += " AND name Like '%" + name + "%'";
            }
            if (stunum != "学号")
            {
                if (tempstr == "")
                    tempstr = "student_num Like '%" + stunum + "%'";
                else
                    tempstr += " AND student_num Like '%" + stunum + "%'";
            }
            if (phone != "联系方式")
            {
                if (tempstr == "")
                    tempstr = "phone Like '%" + phone + "%'";
                else
                    tempstr += " AND phone Like '%" + phone + "%'";
            }
            mysql = select_tutor_str + "where " + tempstr + " order by tutor_num desc";
            dgvbind.dgvbind(dgv_search, mysql, tablename);
        }

        #endregion

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paneltop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void paneltop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

        private void labeltitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void labeltitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void labeltitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

        private void dgv_search_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void dgv_search_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void dgv_search_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string num = "";
            string name = "";
            if (dgv_search.SelectedRows.Count > 0)
            {
                num = dgv_search.SelectedRows[0].Cells[0].Value.ToString();
                name = dgv_search.SelectedRows[0].Cells[1].Value.ToString();
            }
            tutorselected(num, name);
            this.Close();
        }
    }
}
