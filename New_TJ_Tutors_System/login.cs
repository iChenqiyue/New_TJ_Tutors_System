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
    public partial class login : Form
    {

        commondb mydb = new commondb();
        private bool dragging = false;
        private Point startpoint = new Point(0, 0);


        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            objectclass.userinfo.username = txt_user.Text;
            objectclass.userinfo.password = txt_pwd.Text;
            string mysql = "";
            mysql = string.Format("select * from user where username='{0}' and password='{1}'", objectclass.userinfo.username, objectclass.userinfo.password);
            try
            {
                int i = mydb.Rownum(mysql);
                if (i == 0)
                {
                    MessageBox.Show("您输入的用户名或密码错误！请重试", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_pwd.Text = "";
                    return;
                }
                else
                {
                    mysql = "select degree from user where username='"+ objectclass.userinfo.username + "'";
                    string level = mydb.Returnafield(mysql);
                    this.Hide();
                    Form myform = new mainform();
                    myform.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_user.Text = "用户名";
            txt_pwd.Text = "密码";
            btn_login.Focus();
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim() == "用户名")
            {
                txt_user.Text = "";
            }
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim().Length == 0)
            {
                txt_user.Text = "用户名";
            }
        }

        private void txt_pwd_Enter(object sender, EventArgs e)
        {
            if (txt_pwd.Text.Trim() == "密码")
            {
                txt_pwd.Text = "";
                txt_pwd.PasswordChar = '*';
            }
        }

        private void txt_pwd_Leave(object sender, EventArgs e)
        {
            if (txt_pwd.Text.Trim().Length == 0)
            {
                txt_pwd.PasswordChar = '\0';
                txt_pwd.Text = "密码";
            }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);
        }
    }
}
