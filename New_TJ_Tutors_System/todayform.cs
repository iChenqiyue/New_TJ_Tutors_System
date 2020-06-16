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
        string filename = "";
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

        private void btn_export_Click(object sender, EventArgs e)
        {
            string defaultname = DateTime.Now.ToLongDateString() + ".xlsx";
            //bool fileSaved = false;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx";
            saveDialog.FileName = defaultname;
            saveDialog.ShowDialog();
            filename = saveDialog.FileName;

            //Form1_Load
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;


            //CheckUpdate为窗体显示过程中需要处理算法的方法
            worker.DoWork += new DoWorkEventHandler(CheckUpdate);
            worker.RunWorkerAsync();

            //显示进度窗体
            progress f = new progress(worker);
            f.Text = "正在导出...";
            f.ShowDialog();

            //处理算法CheckUpdate，注意参数一致
            /*exporttoexcel ete = new exporttoexcel();
            string filename = DateTime.Now.ToLongDateString() + ".xlsx";
            ete.ExportExcel(filename, dgv_todayform);*/

        }
        public void CheckUpdate(object sender, DoWorkEventArgs e)
        {
            exporttoexcel ete = new exporttoexcel();
            ete.ExportExcel(filename, dgv_todayform);
        }
    }
}
