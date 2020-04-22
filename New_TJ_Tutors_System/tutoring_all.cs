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
        public string ID1, parent_num1, print_num1, reception1, reception_time1, parent_name1, phone1, simple_adr1, detail_adr1,
            grade_stu1, subject_stu1, student_sex1, tutors_price1, tutors_time1, sex1, place1, grade1, subject1, other_requests1,
            payment_state1, payment_time1,tutor_state1,remarks1;

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

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
            openchidform(new tutor_search(),paneltutor);
            string mystr = "select * from tutoring";
            databind dgvbind = new databind();
            dgvbind.dgvbind(dgv_search, mystr, "tutoring");
            paneltutor.Visible = false;
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
        
        }
        
        
    }



