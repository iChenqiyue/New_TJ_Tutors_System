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
    public partial class worker : Form
    {
        //全局变量
        styleinit dgvstyle = new styleinit();
        databind dgvbind = new databind();
        databind cbobind = new databind();
        commondb mydb = new commondb();
        objectclass.workerinfo worker1 = new objectclass.workerinfo();
        string select_worker_str = "select worker_num as 职员编号,name as 姓名,student_num as 学号,subject as 院系专业," +
            "sex as 性别,position as 职位,month_score as 本月积分,total_score as 累计积分,isleave as 是否离职 from worker ";
        string insert_worker_str = "(worker_num, name, sex, student_num, subject, phone, position, month_score, total_score,isleave)";
        string select_history_str = "select user as 职工编号,optype as 操作类型,num as 打印编号,content as 内容,time as 时间 from history ";
        bool insertstate = false;

        public worker()
        {
            InitializeComponent();
        }

        #region 初始化

        #region 窗口初始化

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

        private void worker_Load(object sender, EventArgs e)
        {

            //初始化控件
            txt_num_search.Text = "职工编号";
            txt_name_search.Text = "职工姓名";
            txt_stunum_search.Text = "学号";
            txt_phone_search.Text = "联系方式";
            txt_print_num.Text = "打印编号";
            txt_worker_num.Text = "职工编号";
            ckb_time.Checked = false;

            dgvstyle.ColorDataGridView(dgv_search);
            dgvstyle.ColorDataGridView(dgv_res);

            //dgv_res.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            
            dgv_res.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_res.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_res.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            cbo_select.SelectedItem = "全部";

            datainit();
            dgvhisfresh();
            //
            showworker();
        }
        #endregion

        #region 数据初始化

        /// <summary>
        /// 数据初始化
        /// </summary>
        public void datainit()
        {
            string mysql = "";
            string tablename = "worker";

            DataSet info;
            //新建对象tutoring_info
            worker1.worker_num = dgv_search.SelectedRows[0].Cells[0].Value.ToString();
            mysql = "select * from worker where worker_num= " + worker1.worker_num;
            try
            {
                info = mydb.ExecuteQuery(mysql, tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            worker1.name = info.Tables[0].Rows[0].ItemArray[1].ToString();
            worker1.sex = info.Tables[0].Rows[0].ItemArray[2].ToString();
            worker1.student_num = info.Tables[0].Rows[0].ItemArray[3].ToString();
            worker1.subject = info.Tables[0].Rows[0].ItemArray[4].ToString();
            worker1.phone = info.Tables[0].Rows[0].ItemArray[5].ToString();
            worker1.position = info.Tables[0].Rows[0].ItemArray[6].ToString();
            worker1.month_score = info.Tables[0].Rows[0].ItemArray[7].ToString();        
            worker1.total_score = info.Tables[0].Rows[0].ItemArray[8].ToString();
            worker1.isleave = info.Tables[0].Rows[0].ItemArray[9].ToString();

        }


        #endregion

        

        #region textbox控件初始化


        private void txt_num_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }





        private void txt_stunum_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_phone_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        private void txt_num_search_Enter(object sender, EventArgs e)
        {
            if (txt_num_search.Text.Trim() == "职工编号")
            {
                txt_num_search.Text = "";
            }
        }

        private void txt_num_search_Leave(object sender, EventArgs e)
        {
            if (txt_num_search.Text.Trim().Length == 0)
            {
                txt_num_search.Text = "职工编号";
            }
        }

        private void txt_name_search_Enter(object sender, EventArgs e)
        {
            if (txt_name_search.Text.Trim() == "职工姓名")
            {
                txt_name_search.Text = "";
            }
        }

        private void txt_name_search_Leave(object sender, EventArgs e)
        {
            if (txt_name_search.Text.Trim().Length == 0)
            {
                txt_name_search.Text = "职工姓名";
            }
        }

        private void txt_stunum_search_Enter(object sender, EventArgs e)
        {
            if (txt_stunum_search.Text.Trim() == "学号")
            {
                txt_stunum_search.Text = "";
            }
        }

        private void txt_stunum_search_Leave(object sender, EventArgs e)
        {
            if (txt_stunum_search.Text.Trim().Length == 0)
            {
                txt_stunum_search.Text = "学号";
            }
        }

        private void txt_phone_search_Enter(object sender, EventArgs e)
        {
            if (txt_phone_search.Text.Trim() == "联系方式")
            {
                txt_phone_search.Text = "";
            }
        }

        private void txt_phone_search_Leave(object sender, EventArgs e)
        {
            if (txt_phone_search.Text.Trim().Length == 0)
            {
                txt_phone_search.Text = "联系方式";
            }
        }



        private void txt_print_num_Enter(object sender, EventArgs e)
        {
            if (txt_print_num.Text.Trim() == "打印编号")
            {
                txt_print_num.Text = "";
            }
        }

        private void txt_print_num_Leave(object sender, EventArgs e)
        {
            if (txt_print_num.Text.Trim().Length == 0)
            {
                txt_print_num.Text = "打印编号";
            }
        }

        private void txt_print_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_worker_num_Enter(object sender, EventArgs e)
        {
            if (txt_worker_num.Text.Trim() == "职工编号")
            {
                txt_worker_num.Text = "";
            }
        }

        private void txt_worker_num_Leave(object sender, EventArgs e)
        {
            if (txt_worker_num.Text.Trim().Length == 0)
            {
                txt_worker_num.Text = "职工编号";
            }
        }

        private void txt_worker_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion

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
            string mysql = select_worker_str;
            string tablename = "worker";
            if (cbo_select.SelectedItem.ToString() == "全部")
            {
                mysql += "order by worker_num desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "在职")
            {
                mysql += "where isleave='否' order by worker_num desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "离职")
            {
                mysql += "where isleave='是' order by worker_num desc";
            }
            else { }
            
            dgvbind.dgvbind(dgv_search, mysql, tablename);
        }

        /// <summary>
        /// 刷新表格
        /// </summary>
        public void dgvhisfresh()
        {
            string mysql = select_history_str+" order by time desc";
            string tablename = "history";
            Console.WriteLine(mysql);
            dgvbind.dgvbind(dgv_res, mysql, tablename);
            dgv_res.Columns[3].FillWeight = 250;
        }

        #endregion

        #endregion


        #region 搜索和筛选
        private void btn_workersearch_Click(object sender, EventArgs e)
        {
            string mysql = "";
            string tablename = "worker";
            string num = txt_num_search.Text.Trim();
            string name = txt_name_search.Text.Trim();
            string stunum = txt_stunum_search.Text.Trim();
            string phone = txt_phone_search.Text.Trim();

            if (num == "职工编号" && name == "职工姓名" && stunum == "学号" && phone == "联系方式")
            {
                mysql = select_worker_str + "order by worker_num desc";
                dgvbind.dgvbind(dgv_search, mysql, tablename);
                return;
            }
            string tempstr = "";
            if (num != "职工编号")
                tempstr = "worker_num Like '%" + num + "%'";
            if (name != "职工姓名")
            {
                if (tempstr == "")
                    tempstr = "name Like '%" + name + "%'";
                else
                    tempstr += " AND name Like '%" + name + "%'";
            }
            if (stunum != "学号")
            {
                if (tempstr == "")
                    tempstr = "student_num Like '%" + stunum + "%'";
                else
                    tempstr += " AND student_num Like '%" + stunum + "%'";
            }
            if (phone != "联系方式")
            {
                if (tempstr == "")
                    tempstr = "phone Like '%" + phone + "%'";
                else
                    tempstr += " AND phone Like '%" + phone + "%'";
            }
            mysql = select_worker_str + "where " + tempstr + " order by worker_num desc";
            dgvbind.dgvbind(dgv_search, mysql, tablename);
        }

        private void cbo_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvfresh();
        }
        #endregion

        #region 显示详情页
        private void dgv_search_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_search.SelectedRows.Count != 0)
                datainit();

            insertstate = false;
            showworker();
        }


        /// <summary>
        /// 显示职工详细信息
        /// </summary>
        public void showworker()
        {

            txt_num.Text = worker1.worker_num;
            txt_name.Text = worker1.name;
            txt_student_num.Text = worker1.student_num;
            cbo_subject.Text = worker1.subject;
            txt_position.Text = worker1.position;
            txt_phone.Text = worker1.phone;
            txt_month.Text = worker1.month_score;
            cbo_yesno.Text = worker1.isleave;
            txt_total.Text = worker1.total_score;
            if (worker1.sex == "男")
                rdo_man.Checked = true;
            else if (worker1.sex == "女")
                rdo_woman.Checked = true;
            else { }

        }
        #endregion

        #region 新增、更新和删除
        private void btn_add_Click(object sender, EventArgs e)
        {
            string mysql = "";
            int tempnum = 0;
            if (dgv_search.SelectedRows.Count > 0)
                dgv_search.SelectedRows[0].Selected = false;
            //重置worker1
            worker1.reset();
            insertstate = true;

            //数据准备，初始化教员编号
            //教员编号+1
            mysql = "select max(worker_num) from worker";
            try
            {
                tempnum = int.Parse(mydb.Returnafield(mysql)) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            worker1.worker_num = tempnum.ToString();

            //初始化学位和性别和是否黑名单
            rdo_man.Checked = false;
            rdo_woman.Checked = false;
            cbo_yesno.SelectedItem = "否";
            worker1.month_score = "0";
            worker1.total_score = "0";
            //判断数组非空           
            showworker();
        }


        #endregion

        private void btn_save_Click(object sender, EventArgs e)
        {
            //封装数组
            TextBox[] txt = { txt_num, txt_name, txt_student_num, txt_phone,txt_position};
            string[] message = { "职工编号", "职工姓名", "学号", "联系方式","职位" };
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
            worker1.worker_num = txt_num.Text.Trim();
            worker1.name = txt_name.Text.Trim();
            worker1.student_num = txt_student_num.Text.Trim();
            worker1.subject = cbo_subject.Text.Trim();
            worker1.phone = txt_phone.Text.Trim();
            worker1.position = txt_position.Text.Trim();
            if (rdo_man.Checked == true)
                worker1.sex = "男";
            rdo_man.Checked = true;
            if (rdo_woman.Checked == true)
                worker1.sex = "女";
            worker1.isleave = cbo_yesno.SelectedItem.ToString();
            worker1.month_score = txt_month.Text.Trim();
            worker1.total_score = txt_total.Text.Trim();

            //插入新家教信息
            if (insertstate == true)
            {
                mysql = "insert into worker " + insert_worker_str + " values " + worker1.connectstr();
                DialogResult result = MessageBox.Show("确认新增职工信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        mydb.ExecuteNonQuery(mysql);
                        mysql = string.Format("insert into user (username,password,degree) values ('{0}','{1}','{2}')", 
                            worker1.worker_num,worker1.student_num, "操作员");
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
                mysql = worker1.updatestr();
                DialogResult result = MessageBox.Show("确认更新职工信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
            mysql = "delete from worker where worker_num= '" + worker1.worker_num+"'";
            DialogResult result = MessageBox.Show("确认删除该条信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btn_research_Click(object sender, EventArgs e)
        {
            string mysql = "";
            string tablename = "history";
            string print_num = txt_print_num.Text.Trim();
            string worker_num = txt_worker_num.Text.Trim();

            if (print_num == "打印编号"  && worker_num == "职工编号"&&ckb_time.Checked==false)
            {
                mysql = select_history_str + "order by time desc";
                dgvbind.dgvbind(dgv_res, mysql, tablename);
                return;
            }
            string tempstr = "";
            if (print_num != "打印编号")
                tempstr = "num Like '%" + print_num + "%'";

            if (worker_num != "职工编号")
            {
                if (tempstr == "")
                    tempstr = "user Like '%" + worker_num + "%'";
                else
                    tempstr += " AND user Like '%" + worker_num + "%'";
            }

            if (ckb_time.Checked == true)
            {
                if (tempstr == "")
                    tempstr += "time>'" + dt_from.Value.ToString() + "' and time<'" + dt_to.Value.ToString() + "'";
                else
                    tempstr += " and time>'" + dt_from.Value.ToString() + "' and time<'" + dt_to.Value.ToString() + "'";
            }
            mysql = select_history_str + "where " + tempstr + " order by time desc";
            dgvbind.dgvbind(dgv_res, mysql, tablename);
        }

        
    }
}
