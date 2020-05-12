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

    public delegate void admincheckHandler(bool is_admin);  //定义委托
    public partial class pwdinput : Form
    {
        public pwdinput()
        {
            InitializeComponent();
        }

        public event admincheckHandler admincheck;  //定义事件

        commondb mydb = new commondb();

        private void btn_yes_Click(object sender, EventArgs e)
        {
            string inputpwd = txt_pwd.Text.ToString();
            string mysql = "";
            mysql = "select password from user where username='admin'";
            string password = mydb.Returnafield(mysql);
            if (password == inputpwd)
            {
                admincheck(true);
                this.Close();
            }
            else
            {
                admincheck(false);
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

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
