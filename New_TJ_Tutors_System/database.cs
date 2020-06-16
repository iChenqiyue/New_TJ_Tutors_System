using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace New_TJ_Tutors_System
{
    public partial class database : Form
    {

        commondb mydb = new commondb();
        backup mybackup = new backup();
        string filename = "";
        string[] tables = { "tutoring", "tutor", "business", "worker", "history" };
        string tablename = "";
        public database()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            paneldatabase.Visible = true;
            paneltoexcel.Visible = false;
        }

        private void btn_forms_Click(object sender, EventArgs e)
        {
            paneldatabase.Visible = false;
            paneltoexcel.Visible = true;
        }

        private void btn_server_Click(object sender, EventArgs e)
        {

        }

        private void btn_bpath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txt_bpath.Text = folderBrowserDialog.SelectedPath.ToString();
            }
        }

        private void btn_rpath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FilterIndex = 0;
            openFileDialog.FileName = "";
            openFileDialog.Filter = "txt files (*.sql)|*.sql|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_rpath.Text = openFileDialog.FileName.ToString();
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {

            if (txt_bpath.Text != "")
            {
                try
                {
                    string defaultname = "\\" + DateTime.Now.ToLongDateString() + ".sql";
                    mybackup.Backup(txt_bpath.Text + defaultname);
                    MessageBox.Show("数据备份成功！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "备份失败！请重试！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请填写备份的正确位置！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }// end 


        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            string defaultname = cbo_export.SelectedItem.ToString() + DateTime.Now.ToLongDateString() + ".xlsx";
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
        }

        public void CheckUpdate(object sender, DoWorkEventArgs e)
        {
            exporttoexcel ete = new exporttoexcel();

            ete.ExportExcel(filename, tablename);
        }

        private void cbo_export_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablename = tables[cbo_export.SelectedIndex];
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            if (txt_rpath.Text != "")
            {
                try
                { 
                    mybackup.Backup(txt_rpath.Text.Trim());
                    MessageBox.Show("数据还原成功！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "还原失败！请重试！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请填写还原的正确位置！", "提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }// end
        }
    }
}
