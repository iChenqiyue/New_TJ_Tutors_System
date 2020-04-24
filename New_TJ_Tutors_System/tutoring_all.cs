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
    public partial class tutoring_all : Form
    {
        class tutoringinfo
        {
            public string ID1, parent_num1, print_num1, reception1, reception_time1, parent_name1, phone1, simple_adr1, detail_adr1,
                grade_stu1, subject_stu1, student_sex1, tutors_price1, tutors_time1, sex1, place1, grade1, subject1, other_requests1,
                payment_state1, payment_time1, tutor_state1, remarks1;
        }


        //全局变量
        styleinit dgvstyle = new styleinit();
        databind dgvbind = new databind();
        commondb mydb = new commondb();
        string select_tutoring_str = "select print_num as 打印编号,parent_num as 家长编号,parent_name as 家长称呼,phone as 联系方式,"
            +"tutor_state as 家教状态,payment_state as 缴费状态,grade_stu as 年级,subject_stu as 科目,simple_adr as 家教地址,"
            +"student_sex as 学员性别,tutor_time as 家教时间,tutor_price as 家教价格,remarks as 重要备注,latest_time as 最近更新时间"
            +" from tutoring ";
        //打开窗口
        private Form activeform = null;
        private void openchidform(Form childform,Panel childpanel)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childpanel.Controls.Add(childform);
            childpanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }


        //右侧tabbar切换
        private void btn_buss_Click_1(object sender, EventArgs e)
        {
            panel_tutor.Visible = false;
            panel_buss.Visible = true;
            openchidform(new bussiness(),panelinfo);
        }
        private void btn_tutor_info_Click_1(object sender, EventArgs e)
        {
            panel_tutor.Visible = true;
            panel_buss.Visible = false;
            openchidform(new tutoring_info(),panelinfo);
        }

 

        
        //构造函数
        public tutoring_all()
        {
            InitializeComponent();
        }

        

        private void tutoring_info_Load(object sender, EventArgs e)
        {
            //初始化控件
            txt_parent_search.Text = "家长编号";
            txt_print_search.Text = "打印编号";
            txt_phone_search.Text = "联系方式";
            txt_address_search.Text = "地址中含有";
            paneltutor.Visible = false;

            //调用窗口
            openchidform(new tutor_search(),paneltutor);

            //dgvstyle.ColorDataGridView(dgv_search);

            cbo_select.SelectedItem = "全部";

            //绑定表格数据           
            //更改到cbo_select中初始化
            //string mystr = "select * from tutoring";                       
            //dgvbind.dgvbind(dgv_search, mystr, "tutoring");
            

   
            
        }

        

        //textbox控件初始化
        #region parent_num

        private void txt_parent_search_Enter(object sender, EventArgs e)
        {
            if (txt_parent_search.Text.Trim() == "家长编号")
            {
                txt_parent_search.Text = "";
            }
        }

        private void txt_parent_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_parent_num_Leave(object sender, EventArgs e)
        {
            if (txt_parent_search.Text.Trim().Length == 0)
            {
                txt_parent_search.Text = "家长编号";
            }

        }

        #endregion

        #region print_num
        private void txt_print_num_Enter(object sender, EventArgs e)
        {
            if (txt_print_search.Text.Trim() == "打印编号")
            {
                txt_print_search.Text = "";
            }
        }

        private void txt_print_num_Leave(object sender, EventArgs e)
        {
            if (txt_print_search.Text.Trim().Length == 0)
            {
                txt_print_search.Text = "打印编号";
            }
        }

        private void txt_print_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region address
        private void txt_adress_Enter(object sender, EventArgs e)
        {
            if (txt_address_search.Text.Trim() == "地址中含有")
            {
                txt_address_search.Text = "";
            }
        }

        private void txt_adress_Leave(object sender, EventArgs e)
        {
            if (txt_address_search.Text.Trim().Length == 0)
            {
                txt_address_search.Text = "地址中含有";
            }
        }
        #endregion

        #region phone
        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone_search.Text.Trim().Length == 0)
            {
                txt_phone_search.Text = "联系方式";
            }
        }

        private void txt_phone_Enter(object sender, EventArgs e)
        {
            if (txt_phone_search.Text.Trim() == "联系方式")
            {
                txt_phone_search.Text = "";
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        #endregion

        #region revise_info
        private void txt_parent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            //...
            //序号自增
            //..

        }
        private void txt_print_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            //...
            //序号自增
            //..
        }

        private void txt_phone_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            //...
            //设置价格查看点
            //..
        }
        #endregion

        //判断非空
        private bool is_empty(string str)
        {
            if (str == "")
                return true;
            else
                return false;
        }

        #region leftop
        //搜索
        private void btn_search_Click(object sender, EventArgs e)
        {
            string mysql="";
            string tablename = "tutoring";
            string parent = txt_parent_search.Text.Trim();
            string print = txt_print_search.Text.Trim();
            string address = txt_address_search.Text.Trim();
            string phone = txt_phone_search.Text.Trim();

            if (parent=="家长编号" && print=="打印编号" && address=="地址中含有" && phone=="联系方式")
            {
                mysql = select_tutoring_str;
                dgvbind.dgvbind(dgv_search, mysql, "tutoring");
                return;
            }
            string tempstr = "";
            if (parent != "家长编号")
                tempstr = "parent_num Like '%" + parent + "%'";
            if (print != "打印编号")
            {
                if (tempstr == "")
                    tempstr = "print_num Like '%" + print + "%'";
                else
                    tempstr += " AND print_num Like '%" + print + "%'";
            }
            if (address != "地址中含有")
            {
                if (tempstr == "")
                    tempstr = "detail_adr Like '%" + address + "%'";
                else
                    tempstr += " AND detail_adr Like '%" + address + "%'";
            }
            if (phone != "联系方式")
            {
                if (tempstr == "")
                    tempstr = "phone Like '%" + phone + "%'";
                else
                    tempstr += " AND phone Like '%" + phone + "%'";
            }
            mysql = select_tutoring_str +"where " + tempstr + " order by print_num desc";
            dgvbind.dgvbind(dgv_search, mysql, tablename);
            //DataSet mydataset = mydb.ExecuteQuery(mysql, tablename);
            //dgv_search.DataSource = mydataset.Tables[tablename];
        }

        //筛选条件
        private void cbo_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mysql = select_tutoring_str;
            string tablename = "tutoring";
            if (cbo_select.SelectedItem.ToString() == "全部")
            {
                mysql = select_tutoring_str;
            }
            else if (cbo_select.SelectedItem.ToString() == "管理费未清家教")
            {
                mysql += "where payment_state='待缴' order by latest_time desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "待接家教")
            {
                mysql += "where tutor_state='待接' order by latest_time desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "未派出家教")
            {
                mysql += "where tutor_state='接入' or tutor_state='换人' or tutor_state='重请' order by latest_time desc";
            }
            else { }
            dgvbind.dgvbind(dgv_search, mysql, tablename);
        }
        #endregion
    }


}



