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
    public partial class tutoring_info : Form
    {


        //全局变量
        string print_num;
        commondb mydb = new commondb();
        objectclass.tutoringinfo tutor = new objectclass.tutoringinfo();

        public tutoring_info()
        {
            InitializeComponent();
        }
        public tutoring_info(objectclass.tutoringinfo tutor1)
        {
            InitializeComponent();
            tutor = tutor1;
        }


        private void initdata(string print_num, objectclass tutor)
        {
            string tablename = "tutoring";
            string mysql = "select * from tutoring where print_num=" + print_num;
            DataSet mydataset = mydb.ExecuteQuery(mysql, tablename);



        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            //初始化数据
            DialogResult result = MessageBox.Show("确定保存信息？", "操作提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            if (result == DialogResult.OK)
            {
                //确定没有空输入
                if (txt_parent_num.Text == "")
                {
                    MessageBox.Show("请输入家长编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_print_num.Text == "")
                {
                    MessageBox.Show("请输入打印编号！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (cbo_reception.SelectedItem == null)
                {
                    MessageBox.Show("请选择接待人！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_parent_name.Text == "")
                {
                    MessageBox.Show("请输入家长称呼！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_phone.Text == "")
                {
                    MessageBox.Show("请输入联系方式！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_phone.TextLength > 11)
                {
                    MessageBox.Show("联系方式不得超过11位！请重新输入！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_phone.Text = "";
                    return;
                }
                if (txt_sadd.Text == "")
                {
                    MessageBox.Show("请输入家教地址（简单）！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_dadd.Text == "")
                {
                    MessageBox.Show("请输入家教地址（详细）！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_grade_stu.Text == "")
                {
                    MessageBox.Show("请输入年级！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_subject_stu.Text == "")
                {
                    MessageBox.Show("请输入科目！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!rdo_man.Checked && !rdo_woman.Checked)
                {
                    MessageBox.Show("请选择学员性别！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_tutor_price.Text == "")
                {
                    MessageBox.Show("请输入家教价格！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txt_tutor_time.Text == "")
                {
                    MessageBox.Show("请输入家教时间！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (cbo_payment_state.SelectedItem == null)
                {
                    MessageBox.Show("请选择缴费状态！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                objectclass.tutoringinfo tutor1 = new objectclass.tutoringinfo();
                //为字段赋值

                tutor1.parent_num = txt_parent_num.Text.Trim();
                tutor1.print_num = txt_print_num.Text.Trim();
                tutor1.reception = cbo_reception.SelectedItem.ToString();
                tutor1.reception_time = dt_recepiton_time.Value.ToString();
                tutor1.parent_name = txt_parent_name.Text.Trim();
                tutor1.phone = txt_phone.Text.Trim();
                tutor1.simple_adr = txt_sadd.Text.Trim();
                tutor1.detail_adr = txt_dadd.Text.Trim();
                tutor1.grade_stu = txt_grade_stu.Text.Trim();
                tutor1.subject_stu = txt_subject_stu.Text.Trim();
                if (rdo_man.Checked)
                    tutor1.student_sex = rdo_man.Text;
                else
                    tutor1.student_sex = rdo_woman.Text;
                tutor1.tutors_price = txt_tutor_price.Text.Trim();
                tutor1.tutors_time = txt_tutor_time.Text.Trim();
                tutor1.sex = cbo_sex.SelectedItem.ToString();
                tutor1.place = txt_place.Text.Trim();
                tutor1.grade = txt_grade.Text.Trim();
                tutor1.subject = txt_subject.Text.Trim();
                tutor1.other_requests = txt_other_requests.Text.Trim();
                tutor1.payment_state = cbo_payment_state.SelectedItem.ToString();
                tutor1.payment_time = dt_payment_time.Value.ToString();

                //数据库操作
                //...
            }
        }


        /// <summary>
        /// 初始化窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tutoring_info_Load(object sender, EventArgs e)
        {
            txt_parent_num.Text = tutor.parent_num;
            txt_print_num.Text = tutor.print_num;
            cbo_reception.Text = tutor.reception;
            dt_recepiton_time.Text = tutor.reception_time;
            txt_parent_name.Text = tutor.parent_name;
            txt_phone.Text = tutor.phone;
            txt_sadd.Text = tutor.simple_adr;
            txt_dadd.Text = tutor.detail_adr;
            txt_grade_stu.Text = tutor.grade_stu;
            txt_subject_stu.Text = tutor.subject_stu;
            if (tutor.student_sex == "男")
                rdo_man.Checked = true;
            else if (tutor.student_sex == "女")
                rdo_woman.Checked = true;
            else { }
            txt_tutor_price.Text = tutor.tutors_price;
            txt_tutor_time.Text = tutor.tutors_time;
            cbo_sex.Text = tutor.sex;
            txt_place.Text = tutor.place;
            txt_grade.Text = tutor.grade;
            txt_subject.Text = tutor.subject;
            txt_subject.Text = tutor.payment_time;
            txt_other_requests.Text = tutor.other_requests;
            cbo_payment_state.Text = tutor.payment_state;
            //dt_payment_time.Text = (DateTime.Parse(tutor.payment_time)).ToString();
        }

        private void tutoring_info_Activated(object sender, EventArgs e)
        {

        }
    }
}
