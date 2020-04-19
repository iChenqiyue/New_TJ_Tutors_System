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
    public partial class tutor_info : Form
    {

        public string ID1, parent_num1, print_num1, reception1, reception_time1, parent_name1, phone1, simple_adr1, detail_adr1,
            grade_stu1, subject_stu1, student_sex1, tutors_price1, tutors_time1, sex1, place1, grade1, subject1, other_requests1,
            payment_state1, payment_time1, tutor_state1, remarks1;


        public tutor_info()
        {
            InitializeComponent();
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

                //为字段赋值
                parent_num1 = txt_parent_num.Text.Trim();
                print_num1 = txt_print_num.Text.Trim();
                reception1 = cbo_reception.SelectedItem.ToString();
                reception_time1 = dt_recepiton_time.Value.ToString();
                parent_name1 = txt_parent_name.Text.Trim();
                phone1 = txt_phone.Text.Trim();
                simple_adr1 = txt_sadd.Text.Trim();
                detail_adr1 = txt_dadd.Text.Trim();
                grade_stu1 = txt_grade_stu.Text.Trim();
                subject_stu1 = txt_subject_stu.Text.Trim();
                if (rdo_man.Checked)
                    student_sex1 = rdo_man.Text;
                else
                    student_sex1 = rdo_woman.Text;
                tutors_price1 = txt_tutor_price.Text.Trim();
                tutors_time1 = txt_tutor_time.Text.Trim();
                sex1 = cbo_sex.SelectedItem.ToString();
                place1 = txt_place.Text.Trim();
                grade1 = txt_grade.Text.Trim();
                subject1 = txt_subject.Text.Trim();
                other_requests1 = txt_other_requests.Text.Trim();
                payment_state1 = cbo_payment_state.SelectedItem.ToString();
                payment_time1 = dt_payment_time.Value.ToString();

                //数据库操作
                //...
            }
        }
    }
}
