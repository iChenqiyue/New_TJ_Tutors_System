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
    public partial class mainform : Form
    {

        //定义全局变量

        private bool dragging = false;
        private Point startpoint = new Point(0, 0);
        public string username = objectclass.userinfo.username;
        private string degree = objectclass.userinfo.degree;

        public mainform()
        {
            InitializeComponent();
            customizedesing();
        }
        #region menusettings
        private void customizedesing()
        {
            paneltutoringmenu.Visible = false;
            paneltutormenu.Visible = false;
            panelworkermenu.Visible = false;
            panelhelpmenu.Visible = false;
            panelemergency.Visible = false;

        }

        private void hidesubmenu()
        {
            if (paneltutoringmenu.Visible == true)
                paneltutoringmenu.Visible = false;
            if (paneltutormenu.Visible == true)
                paneltutormenu.Visible = false;
            if (panelworkermenu.Visible == true)
                panelworkermenu.Visible = false;
            if (panelhelpmenu.Visible == true)
                panelhelpmenu.Visible = false;
            if (panelemergency.Visible == true)
                panelemergency.Visible = false;
        }

        private void showsubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                //hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private Form activeform = null;
        private void openchidform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            paneltutoring.Controls.Add(childform);
            paneltutoring.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        #endregion

        #region panltutoringmenu
        private void btn_tutoring_info_Click(object sender, EventArgs e)
        {
            showsubmenu(paneltutoringmenu);
        }

        private void btn_tutoring_search_Click(object sender, EventArgs e)
        {
            /**/
            openchidform(new tutoring_all());
            //hidesubmenu();
        } 

        private void btn_tutoring_form_Click(object sender, EventArgs e)
        {
            /**/
            openchidform(new todayform());
            //hidesubmenu();
        }
        #endregion

        #region paneltutormenu

        private void btn_tutor_info_Click(object sender, EventArgs e)
        {
            showsubmenu(paneltutormenu);
        }

        private void btn_tutor_search_Click(object sender, EventArgs e)
        {
            /**/
            openchidform(new tutor_all());
            //hidesubmenu();
        }

        private void btn_tutor_add_Click(object sender, EventArgs e)
        {
            /**/
            //hidesubmenu();
        }

        private void btn_tutor_blacklist_Click(object sender, EventArgs e)
        {
            /**/
            //hidesubmenu();
        }
        #endregion


        #region panelworkermenu
        private void btn_worker_Click(object sender, EventArgs e)
        {
            showsubmenu(panelworkermenu);
        }

        private void btn_worker_search_Click(object sender, EventArgs e)
        {
            if(degree=="管理员")
                openchidform(new worker());
            else
            {
                pwdinput myform = new pwdinput();
                myform.admincheck += new admincheckHandler(admincheck);
                myform.ShowDialog();
            }
            /**/
            //hidesubmenu();
        }
        /// <summary>
        /// 返回是否有权限
        /// </summary>
        /// <param name="is_admin"></param>
        public void admincheck(bool is_admin)
        {
            if(is_admin==true)
                openchidform(new worker());
            else
            {
                MessageBox.Show("密码错误，权限不足！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_worker_add_Click(object sender, EventArgs e)
        {
            /**/
            //hidesubmenu();
        }

        private void btn_worker_responsibility_Click(object sender, EventArgs e)
        {
            /**/
            //hidesubmenu();
        }


        private void btn_help_Click(object sender, EventArgs e)
        {
            showsubmenu(panelhelpmenu);
        }

        private void btn_work_tutorial_Click(object sender, EventArgs e)
        {
            /**/
            //hidesubmenu();
        }
        #endregion

        #region panelhelpmenu

        private void btn_price_check_Click(object sender, EventArgs e)
        {
            /**/
            //hidesubmenu();
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            /**/
            //hidesubmenu();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            /**/
            //hidesubmenu();
        }
        #endregion

        #region emergency
        private void btn_emergency_Click(object sender, EventArgs e)
        {
            showsubmenu(panelemergency);
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            database myform = new database();
            myform.ShowDialog();
        }
        #endregion

        
        #region windowstate
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;              
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }
        private void labeltitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void labeltitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void labeltitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startpoint.X, p.Y - this.startpoint.Y);
            }
        }

        #endregion

        private void mainform_Load(object sender, EventArgs e)
        {
            commondb mydb = new commondb();
            string mysql = "";
            string name = "";
            mysql = "select name from worker where worker_num='" + username + "'";
            int count = 0;
            try
            {
                count = mydb.Rownum(mysql);
                if (count > 0)
                {

                    name = mydb.Returnafield(mysql);
                    lbl_user_num.Text = username;
                    lbl_user_name.Text = name;
                    lbl_admin.Visible = false;
                }
                if (degree == "管理员")
                {
                    lbl_user_num.Text = username;
                    lbl_user_name.Text = "";
                    lbl_admin.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                       

        }

        private void lbl_admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            user myform = new user();
            myform.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认换班？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            else
            {
                MessageBox.Show("登出成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                login myform = new login();               
                myform.Show();
                this.Close();
            }
        }
    }
}
