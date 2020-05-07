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
    public partial class tutor_all : Form
    {

        //全局变量
        styleinit dgvstyle = new styleinit();
        databind dgvbind = new databind();
        commondb mydb = new commondb();
        objectclass.tutorinfo tutor1 = new objectclass.tutorinfo();
        bool insertstate = false;


        public tutor_all()
        {
            InitializeComponent();
        }



        //打开子窗口
        private Form activeform = null;
        private void openchidform(Form childform, Panel childpanel)
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
        


        private void button3_Click(object sender, EventArgs e)
        {
            if (paneltutoring.Visible == false)
                paneltutoring.Visible = true;
            else
                paneltutoring.Visible = false;
        }


        private void tutor_all_Load(object sender, EventArgs e)
        {
            paneltutoring.Visible = false;
            //openchidform(new tutor_search(), panelleft);

            //初始化控件
            txt_num_search.Text = "教员编号";
            txt_name_search.Text = "教员姓名";
            txt_stunum_search.Text = "学号";
            txt_phone_search.Text = "联系方式";            
            paneltutoring.Visible = false;

            //调用窗口
            //openchidform(new tutor_search(), paneltutor);

            dgvstyle.ColorDataGridView(dgv_search);


            cbo_select.SelectedItem = "全部";

            //绑定表格数据           
            //更改到cbo_select中初始化
            //string mystr = "select * from tutoring";                       
            //dgvbind.dgvbind(dgv_search, mystr, "tutoring");

            //初始化右侧详细信息

            datainit();

            //
            showtutor();
        }






        /// <summary>
        /// 数据初始化
        /// </summary>
        public void datainit()
        {
            string mysql = "";
            string tablename = "tutor";

            DataSet info;
            //新建对象tutoring_info
            tutor1.tutor_num = dgv_search.SelectedRows[0].Cells[0].Value.ToString();
            //Console.WriteLine(tutor1.print_num);
            mysql = "select * from tutor where tutor_num= " + tutor1.tutor_num;
            try
            {
                info = mydb.ExecuteQuery(mysql, tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            tutor1.name = info.Tables[0].Rows[0].ItemArray[1].ToString();
            tutor1.student_num = info.Tables[0].Rows[0].ItemArray[2].ToString();
            tutor1.subject = info.Tables[0].Rows[0].ItemArray[3].ToString();
            tutor1.degree = info.Tables[0].Rows[0].ItemArray[4].ToString();
            tutor1.sex = info.Tables[0].Rows[0].ItemArray[5].ToString();
            tutor1.phone = info.Tables[0].Rows[0].ItemArray[6].ToString();
            tutor1.place = info.Tables[0].Rows[0].ItemArray[7].ToString();
            tutor1.blacklist = info.Tables[0].Rows[0].ItemArray[8].ToString();
            tutor1.explantion = info.Tables[0].Rows[0].ItemArray[9].ToString();
            tutor1.remarks = info.Tables[0].Rows[0].ItemArray[10].ToString();
        }

        public void showtutor()
        {
          
            txt_num.Text = tutor1.tutor_num;
            txt_student_name.Text = tutor1.name;
            txt_student_num.Text = tutor1.student_num;
            cbo_subject.Text = tutor1.subject;
            cbo_degree.SelectedItem = tutor1.degree;
            txt_place.Text = tutor1.place;
            txt_phone.Text = tutor1.phone;
            txt_important_remarks.Text = tutor1.remarks;
            cbo_yesno.SelectedItem = tutor1.blacklist;
            txt_imprisonment.Text = tutor1.explantion;

            
            if (tutor1.sex == "男")
                rdo_man.Checked = true;
            else if (tutor1.sex == "女")
                rdo_woman.Checked = true;
            else { }
           
            
        }

        private void cbo_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvfresh();
        }

        public void dgvfresh()
        {
            string mysql = "select * from tutor ";
            string tablename = "tutor";
            if (cbo_select.SelectedItem.ToString() == "全部")
            {
                mysql += "order by tutor_num desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "黑名单")
            {
                mysql += "where blacklist='是' order by tutor_num desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "非黑名单")
            {
                mysql += "where blacklist='否' order by tutor_num desc";
            }
            else { }
            dgvbind.dgvbind(dgv_search, mysql, tablename);
        }

        private void dgv_search_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_search.SelectedRows.Count != 0)
                datainit();

            insertstate = false;
            showtutor();
        }
    }
}
