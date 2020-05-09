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
    public partial class todayform : Form
    {
        //全局变量
        styleinit dgvstyle = new styleinit();
        databind dgvbind = new databind();
        commondb mydb = new commondb();
        public todayform()
        {
            InitializeComponent();
        }

        private void todayform_Load(object sender, EventArgs e)
        {
            dgvstyle.ColorDataGridView(dgv_todayform);
            dgv_todayform.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string tablename = "tutoring";
            string mysql = "select print_num as 编号,student_sex as 性别,grade_stu as 年级,subject_stu as 科目,grade as 要求年级," +
                "concat((CASE WHEN sex = '' THEN NULL ELSE concat(sex, ';') END),"
                + "(CASE WHEN place = '' THEN '' ELSE concat(place, ';') END),"
                + "(CASE WHEN subject = '' THEN '' ELSE concat(subject, ';') END),"
                + "(CASE WHEN other_request = '' THEN '' ELSE concat(other_request, ';') END)) as 其他要求,simple_adr as 地址,tutor_time as 时间 " +
                "from tutoring where tutor_state='接入' OR tutor_state='换人' or tutor_state='重请' order by print_num desc";
            dgvbind.dgvbind(dgv_todayform, mysql, tablename);
        }
    }
}
