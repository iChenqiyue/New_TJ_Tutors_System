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
    public partial class user : Form
    {
        styleinit dgvstyle = new styleinit();
        databind dgvbind = new databind();
        commondb mydb = new commondb();
        private string username = "";
        private string password = "";
        private string level = "";
        private string select_user_str = "select username as 用户名,password as 密码,degree as 级别 from user order by degree,username desc";
        bool insertstate = false;
        private bool dragging = false;
        private Point startpoint = new Point(0, 0);

        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            dgvstyle.ColorDataGridView(dgv_user);
            dgv_user.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string mysql = select_user_str;
            string tablename = "user";
            dgvbind.dgvbind(dgv_user, mysql, tablename);
            datainit();
            showuser();
        }
        public void datainit()
        {
            username = dgv_user.SelectedRows[0].Cells[0].Value.ToString();
            password = dgv_user.SelectedRows[0].Cells[1].Value.ToString();
            level = dgv_user.SelectedRows[0].Cells[2].Value.ToString();
        }

        public void showuser()
        {
            txt_username.Text = username;
            txt_password.Text = password;
            cbo_degree.Text = level;
        }

        private void dgv_user_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_user.SelectedRows.Count != 0)
                datainit();
            insertstate = false;
            showuser();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region 功能函数
        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private bool is_empty(string str)
        {
            if (str == "")
                return true;
            else
                return false;
        }
        /// <summary>
        /// 刷新表格
        /// </summary>
        public void dgvfresh()
        {
            string mysql = select_user_str;
            string tablename = "user";
            dgvbind.dgvbind(dgv_user, mysql, tablename);
        }
        #endregion

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (dgv_user.SelectedRows.Count > 0)
                dgv_user.SelectedRows[0].Selected = false;

            insertstate = true;
            username = "";
            password = "";
            level = "";
            showuser();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //封装数组
            TextBox[] txt = { txt_username, txt_password };
            string[] message = { "用户名", "密码" };
            string mysql = "";

            //操作提示
            for (int i = 0; i < txt.Length; i++)
            {
                if (is_empty(txt[i].Text.Trim()))
                {
                    MessageBox.Show("请输入" + message[i] + "！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            //初始化数据
            username = txt_username.Text.Trim();
            password = txt_password.Text.Trim();
            level = cbo_degree.SelectedItem.ToString();

            //插入新信息
            if (insertstate == true)
            {
                mysql = string.Format("insert into user (username,password,degree) values ('{0}','{1}','{2}')", username, password, level);
                DialogResult result = MessageBox.Show("确认新增？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        mydb.ExecuteNonQuery(mysql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    MessageBox.Show("新增成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvfresh();
                }
            }


            //更新保存现有家教信息
            else
            {
                mysql = "update user set password='" + password + "',degree='" + level + "' where username='" + username + "'";
                DialogResult result = MessageBox.Show("确认更新？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        mydb.ExecuteNonQuery(mysql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    MessageBox.Show("更新成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvfresh();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string mysql = "";
            mysql = "delete from user where username= '" + username + "'";
            DialogResult result = MessageBox.Show("确认删除？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            else
            {
                try
                {
                    mydb.ExecuteNonQuery(mysql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MessageBox.Show("删除成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvfresh();
            }
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = new Point(e.X, e.Y);
        }

        private void paneltop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void paneltop_MouseMove(object sender, MouseEventArgs e)
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

        private void btn_user_Click(object sender, EventArgs e)
        {
            paneluser.Visible = true;
            panelsettings.Visible = false;

        }

        private void btn_other_Click(object sender, EventArgs e)
        {
            paneluser.Visible = false;
            panelsettings.Visible = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            string mysql = "";
            mysql = "update worker set month_score = 0 where worker_num in (select worker_num from(select worker_num from worker)as a)";
            DialogResult result = MessageBox.Show("确认清空？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            else
            {
                try
                {
                    mydb.ExecuteNonQuery(mysql);
                    MessageBox.Show("清空成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
    }
}
