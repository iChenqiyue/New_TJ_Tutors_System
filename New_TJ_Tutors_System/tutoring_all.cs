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
    public partial class tutoring_all : Form
    {



        //全局变量
        styleinit dgvstyle = new styleinit();
        databind dgvbind = new databind();
        commondb mydb = new commondb();
        string select_tutoring_str = "select print_num as 打印编号,parent_num as 家长编号,parent_name as 家长称呼,phone as 联系方式,"
            + "tutor_state as 家教状态,payment_state as 缴费状态,grade_stu as 年级,subject_stu as 科目,simple_adr as 家教地址,"
            + "student_sex as 学员性别,tutor_time as 家教时间,tutor_price as 家教价格,remarks as 重要备注,latest_time as 最近更新时间"
            + " from tutoring ";
        string insert_tutoring_str = "(parent_num,print_num,reception,reception_time,parent_name,phone,simple_adr,detail_adr,grade_stu,subject_stu," +
            "student_sex,tutor_price,tutor_time,sex,place,grade,subject,other_request,payment_state,tutor_state,remarks,latest_time)";
        
        objectclass.tutoringinfo tutor1 = new objectclass.tutoringinfo();
        bool insertstate = false;



        //构造函数
        public tutoring_all()
        {
            InitializeComponent();
        }

        #region 初始化界面空间
        //打开窗口
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

        private void tutoring_info_Load(object sender, EventArgs e)//名称应为tutoring_all
        {
            //初始化控件
            txt_parent_search.Text = "家长编号";
            txt_print_search.Text = "打印编号";
            txt_phone_search.Text = "联系方式";
            txt_address_search.Text = "地址中含有";
            paneltutor.Visible = false;

            //调用窗口
            openchidform(new tutor_search(), paneltutor);

            dgvstyle.ColorDataGridView(dgv_search);
            dgvstyle.ColorDataGridView(dgv_subject);
            dgv_subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cbo_select.SelectedItem = "全部";

            //绑定表格数据           
            //更改到cbo_select中初始化
            //string mystr = "select * from tutoring";                       
            //dgvbind.dgvbind(dgv_search, mystr, "tutoring");

            //初始化右侧详细信息
            panel_tutor.Visible = true;
            panel_buss.Visible = false;
            panelinfo.BringToFront();
            datainit();

            showtutoring();
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        public void datainit()
        {
            string mysql = "";
            string tablename = "tutoring";

            DataSet info;
            //新建对象tutoring_info
            tutor1.print_num = dgv_search.SelectedRows[0].Cells[0].Value.ToString();
            //Console.WriteLine(tutor1.print_num);
            mysql = "select * from tutoring where print_num= " + tutor1.print_num;
            try
            {
                info = mydb.ExecuteQuery(mysql, tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tutor1.parent_num = info.Tables[0].Rows[0].ItemArray[1].ToString();
            tutor1.reception = info.Tables[0].Rows[0].ItemArray[2].ToString();
            tutor1.reception_time = info.Tables[0].Rows[0].ItemArray[3].ToString();
            tutor1.parent_name = info.Tables[0].Rows[0].ItemArray[4].ToString();
            tutor1.phone = info.Tables[0].Rows[0].ItemArray[5].ToString();
            tutor1.simple_adr = info.Tables[0].Rows[0].ItemArray[6].ToString();
            tutor1.detail_adr = info.Tables[0].Rows[0].ItemArray[7].ToString();
            tutor1.grade_stu = info.Tables[0].Rows[0].ItemArray[8].ToString();
            tutor1.subject_stu = info.Tables[0].Rows[0].ItemArray[9].ToString();
            tutor1.student_sex = info.Tables[0].Rows[0].ItemArray[10].ToString();
            tutor1.tutors_price = info.Tables[0].Rows[0].ItemArray[11].ToString();
            tutor1.tutors_time = info.Tables[0].Rows[0].ItemArray[12].ToString();
            tutor1.sex = info.Tables[0].Rows[0].ItemArray[13].ToString();
            tutor1.place = info.Tables[0].Rows[0].ItemArray[14].ToString();
            tutor1.grade = info.Tables[0].Rows[0].ItemArray[15].ToString();
            tutor1.subject = info.Tables[0].Rows[0].ItemArray[16].ToString();
            tutor1.other_requests = info.Tables[0].Rows[0].ItemArray[17].ToString();
            tutor1.payment_state = info.Tables[0].Rows[0].ItemArray[18].ToString();
            tutor1.payment_time = info.Tables[0].Rows[0].ItemArray[19].ToString();
            tutor1.tutor_state = info.Tables[0].Rows[0].ItemArray[20].ToString();
            tutor1.remarks = info.Tables[0].Rows[0].ItemArray[21].ToString();
        }





        #region textbox控件初始化

        //家长编号搜索框
        private void txt_parent_search_Enter(object sender, EventArgs e)
        {
            if (txt_parent_search.Text.Trim() == "家长编号")
            {
                txt_parent_search.Text = "";
            }
        }

        private void txt_parent_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_parent_num_Leave(object sender, EventArgs e)
        {
            if (txt_parent_search.Text.Trim().Length == 0)
            {
                txt_parent_search.Text = "家长编号";
            }

        }



        //打印编号搜索框
        private void txt_print_num_Enter(object sender, EventArgs e)
        {
            if (txt_print_search.Text.Trim() == "打印编号")
            {
                txt_print_search.Text = "";
            }
        }

        private void txt_print_num_Leave(object sender, EventArgs e)
        {
            if (txt_print_search.Text.Trim().Length == 0)
            {
                txt_print_search.Text = "打印编号";
            }
        }

        private void txt_print_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        //地址搜索框
        private void txt_adress_Enter(object sender, EventArgs e)
        {
            if (txt_address_search.Text.Trim() == "地址中含有")
            {
                txt_address_search.Text = "";
            }
        }

        private void txt_adress_Leave(object sender, EventArgs e)
        {
            if (txt_address_search.Text.Trim().Length == 0)
            {
                txt_address_search.Text = "地址中含有";
            }
        }


        //联系方式搜索框
        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone_search.Text.Trim().Length == 0)
            {
                txt_phone_search.Text = "联系方式";
            }
        }

        private void txt_phone_Enter(object sender, EventArgs e)
        {
            if (txt_phone_search.Text.Trim() == "联系方式")
            {
                txt_phone_search.Text = "";
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }





        //家长编号数值限制
        private void txt_parent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            //...
            //序号自增
            //..

        }

        //打印编号数值限制
        private void txt_print_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            //...
            //序号自增
            //..
        }

        //联系方式数值限制
        private void txt_phone_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //家教价格数值限制
        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            //...
            //设置价格查看点
            //..
        }

        #endregion


        #region 功能函数
        //判断非空
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
            string mysql = select_tutoring_str;
            string tablename = "tutoring";
            if (cbo_select.SelectedItem.ToString() == "全部")
            {
                mysql = select_tutoring_str + "order by latest_time desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "管理费未清家教")
            {
                mysql += "where payment_state='待缴' order by latest_time desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "待接家教")
            {
                mysql += "where tutor_state='待接' order by latest_time desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "未派出家教")
            {
                mysql += "where tutor_state='接入' or tutor_state='换人' or tutor_state='重请' order by latest_time desc";
            }
            else { }
            dgvbind.dgvbind(dgv_search, mysql, tablename);
        }
        #endregion

        //右侧tabbar切换
        private void btn_buss_Click_1(object sender, EventArgs e)
        {
            panel_tutor.Visible = false;
            panel_buss.Visible = true;
            //paneltutor.SendToBack();
            panelbuss.BringToFront();

            //openchidform(new bussiness(), panelinfo);
            datainit();
            showbusiness();
        }
        private void btn_tutor_info_Click_1(object sender, EventArgs e)
        {
            panel_tutor.Visible = true;
            panel_buss.Visible = false;
            //panelbuss.SendToBack();
            panelinfo.BringToFront();

            //openchidform(new tutoring_info(), panelinfo);
            datainit();
            showtutoring();
        }
        #endregion

        #region 搜索和筛选
        //搜索
        private void btn_search_Click(object sender, EventArgs e)
        {
            string mysql = "";
            string tablename = "tutoring";
            string parent = txt_parent_search.Text.Trim();
            string print = txt_print_search.Text.Trim();
            string address = txt_address_search.Text.Trim();
            string phone = txt_phone_search.Text.Trim();

            if (parent == "家长编号" && print == "打印编号" && address == "地址中含有" && phone == "联系方式")
            {
                mysql = select_tutoring_str;
                dgvbind.dgvbind(dgv_search, mysql, "tutoring");
                return;
            }
            string tempstr = "";
            if (parent != "家长编号")
                tempstr = "parent_num Like '%" + parent + "%'";
            if (print != "打印编号")
            {
                if (tempstr == "")
                    tempstr = "print_num Like '%" + print + "%'";
                else
                    tempstr += " AND print_num Like '%" + print + "%'";
            }
            if (address != "地址中含有")
            {
                if (tempstr == "")
                    tempstr = "detail_adr Like '%" + address + "%'";
                else
                    tempstr += " AND detail_adr Like '%" + address + "%'";
            }
            if (phone != "联系方式")
            {
                if (tempstr == "")
                    tempstr = "phone Like '%" + phone + "%'";
                else
                    tempstr += " AND phone Like '%" + phone + "%'";
            }
            mysql = select_tutoring_str + "where " + tempstr + " order by print_num desc";
            dgvbind.dgvbind(dgv_search, mysql, tablename);
        }

        //筛选条件
        private void cbo_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvfresh();
        }
        #endregion

        #region 显示详情页

        /// <summary>
        /// 选中后显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_search_SelectionChanged(object sender, EventArgs e)
        {

            panelinfo.BringToFront();
            if (dgv_search.SelectedRows.Count != 0)
                datainit();

            btn_buss.Enabled = true;
            btn_tutor_info.Enabled = true;

            insertstate = false;
            showtutoring();
        }



        /// <summary>
        /// 显示详细信息页
        /// </summary>
        public void showtutoring()
        {  

            panel_tutor.Visible = true;
            panel_buss.Visible = false;
            txt_parent_num.Text = tutor1.parent_num;
            txt_print_num.Text = tutor1.print_num;
            cbo_reception.Text = tutor1.reception;
            dt_recepiton_time.Text = tutor1.reception_time;
            txt_parent_name.Text = tutor1.parent_name;
            txt_phone.Text = tutor1.phone;
            txt_sadd.Text = tutor1.simple_adr;
            txt_dadd.Text = tutor1.detail_adr;
            txt_grade_stu.Text = tutor1.grade_stu;
            txt_subject_stu.Text = tutor1.subject_stu;
            if (tutor1.student_sex == "男")
                rdo_man.Checked = true;
            else if (tutor1.student_sex == "女")
                rdo_woman.Checked = true;
            else { }
            txt_tutor_price.Text = tutor1.tutors_price;
            txt_tutor_time.Text = tutor1.tutors_time;
            cbo_sex.Text = tutor1.sex;
            txt_place.Text = tutor1.place;
            txt_grade.Text = tutor1.grade;
            txt_subject.Text = tutor1.subject;
            txt_other_requests.Text = tutor1.other_requests;
            cbo_payment_state.Text = tutor1.payment_state;

            if (tutor1.payment_state != "已缴")
            {
                dt_payment_time.Enabled = false;
                dt_payment_time.Text = null;
            }
            else
            {
                dt_payment_time.Enabled = true;
                dt_payment_time.Text = tutor1.payment_time;
            }
        }


        /// <summary>
        /// 显示办理业务页
        /// </summary>
        public void showbusiness()
        {
            cbo_tutor_state.Text = tutor1.tutor_state;
            txt_remarks.Text = tutor1.remarks;
            string tablename="business";
            string mysql = "select a.subject as 科目,a.state as 状态,a.tutor_num as 编号,b.name as 姓名,a.remarks as 备注 " +
                "from business as a,tutor as b where a.tutor_num=b.tutor_num and a.print_num='"+tutor1.print_num+"'";
            //Console.WriteLine(mysql);
           // Console.WriteLine("here");
            dgvbind.dgvbind(dgv_subject, mysql, tablename);
            dgv_subject.Columns[2].Visible = false;
            //dgv_subject.Columns[3].Visible = false;
            dgv_subject.Columns[4].Visible = false;
            
        }
        #endregion

        #region 新增和更新

        /// <summary>
        /// 新增家教信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            string mysql = "";
            int tempnum = 0;
            if (dgv_search.SelectedRows.Count > 0)
                dgv_search.SelectedRows[0].Selected = false;
            //重置tutor1
            tutor1.reset();
            insertstate = true;

            //数据准备，初始化家长编号和打印编号
            //家长编号+1
            mysql = "select max(parent_num) from tutoring";
            try
            {
                tempnum = int.Parse(mydb.Returnafield(mysql)) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tutor1.parent_num = tempnum.ToString();
            //打印编号+1
            mysql = "select max(print_num) from tutoring";
            try
            {
                tempnum = int.Parse(mydb.Returnafield(mysql)) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tutor1.print_num = tempnum.ToString();
            //初始化缴费和家教状态
            cbo_payment_state.SelectedItem = "无需缴纳";
            tutor1.payment_state = "无需缴纳";
            cbo_tutor_state.SelectedItem = "接入";
            tutor1.tutor_state = "接入";


            //判断数组非空
            btn_buss.Enabled = false;
            btn_tutor_info.Enabled = false;
            showtutoring();

        }


        /// <summary>
        /// 新增或更新家教信息  标志位insertnum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            //封装数组
            TextBox[] txt = { txt_parent_num, txt_print_num, txt_parent_name, txt_phone, txt_sadd, txt_dadd,
                txt_grade_stu, txt_subject_stu, txt_tutor_price, txt_tutor_time };
            string[] message = {"家长编号","打印编号","家长称呼","联系电话","家长地址（简单）","家长地址（详细）","年级","科目",
            "家教价格","家教时间"};
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
            if (rdo_man.Checked == true)
                tutor1.student_sex = "男";
            rdo_man.Checked = true;
            if (rdo_woman.Checked == true)
                tutor1.student_sex = "女";
            tutor1.tutors_price = txt_tutor_price.Text.Trim();
            tutor1.tutors_time = txt_tutor_time.Text.Trim();
            tutor1.sex = cbo_sex.SelectedItem.ToString();
            tutor1.place = txt_place.Text.Trim();
            tutor1.grade = txt_grade.Text.Trim();
            tutor1.subject = txt_subject.Text.Trim();
            tutor1.other_requests = txt_other_requests.Text.Trim();
            tutor1.payment_state = cbo_payment_state.SelectedItem.ToString();
            string[] subject = tutor1.subject_stu.Split('、');
            if (tutor1.payment_state != "已缴")
            {
                tutor1.payment_time = null;
            }
            else
            {
                tutor1.payment_time = dt_payment_time.Value.ToString();
            }
            tutor1.latest_time = DateTime.Now.ToString();


            //插入新家教信息
            if (insertstate == true)
            {
                tutor1.tutor_state = "接入";
                tutor1.remarks = "";               
                mysql = "insert into tutoring " + insert_tutoring_str + " values " + tutor1.connectstr();
                DialogResult result = MessageBox.Show("确认新增家教信息？", "操作提示",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        mydb.ExecuteNonQuery(mysql);
                        if (tutor1.payment_time != null)
                            mydb.update_payment_date(tutor1.print_num, tutor1.payment_time);
                        for(int i = 0; i < subject.Length; i++)
                        {
                            //string insert_business_str = "(print_num,tutor_num,subject,state,time,reception,remarks,now";
                            mysql = string.Format("insert into business (print_num,subject,time,reception) values ('{0}', '{1}', '{2}', '{3}')",
                                tutor1.print_num,subject[i],DateTime.Now.ToString(),tutor1.reception);
                            Console.WriteLine(mysql);
                            mydb.ExecuteNonQuery(mysql);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    MessageBox.Show("保存成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    dgvfresh();
                }
            }


            //更新保存现有家教信息
            else
            {
                mysql = tutor1.updatestr();
                Console.WriteLine(mysql);
                DialogResult result = MessageBox.Show("确认更新家教信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        mydb.ExecuteNonQuery(mysql);
                        if (tutor1.payment_time != null)
                            mydb.update_payment_date(tutor1.print_num, tutor1.payment_time);
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

        /// <summary>
        /// 确认更改缴费状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_payment_state_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_payment_state.SelectedItem.ToString() == tutor1.payment_state||cbo_payment_state.SelectedItem.ToString()=="无需缴纳")//判断是否更改状态
                return;
            DialogResult result = MessageBox.Show("确认修改缴费状态？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)//判断是否更改家教状态
            {
                cbo_payment_state.SelectedItem = tutor1.payment_state;
                return;
            }
            if (cbo_payment_state.SelectedItem.ToString() == "已缴")
            {
                dt_payment_time.Enabled = true;
            }
            else
                dt_payment_time.Enabled = false;
        }

        #endregion


        /// <summary>
        /// 删除家教信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {

            string mysql = "";
            mysql = "delete from tutoring where print_num= " + tutor1.print_num;
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

        /// <summary>
        /// 保存家教状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_buss_Click(object sender, EventArgs e)
        {
            tutor1.tutor_state = cbo_tutor_state.SelectedItem.ToString();
            tutor1.remarks = txt_remarks.Text.Trim();
            tutor1.latest_time = DateTime.Now.ToString();
            string mysql = "";
            mysql= string.Format("update tutoring set tutor_state='{0}',remarks='{1}',latest_time='{2}' WHERE print_num='{3}'", 
                tutor1.tutor_state,tutor1.remarks,tutor1.latest_time, tutor1.print_num);
            DialogResult result = MessageBox.Show("确认保存？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                MessageBox.Show("保存成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dgvfresh();
            }
        }
        /// <summary>
        /// 查看不同科目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_subject_SelectionChanged(object sender, EventArgs e)
        {
            string subject = "";
            string state = "";
            string tutor_num = "";
            string tutor_name = "";
            string remark = "";
            //新建对象tutoring_info
            if (dgv_subject.SelectedRows.Count > 0)
            {
                subject = dgv_subject.SelectedRows[0].Cells[0].Value.ToString();
                state = dgv_subject.SelectedRows[0].Cells[1].Value.ToString();
                tutor_num = dgv_subject.SelectedRows[0].Cells[2].Value.ToString();
                tutor_name = dgv_subject.SelectedRows[0].Cells[3].Value.ToString();
                remark = dgv_subject.SelectedRows[0].Cells[4].Value.ToString();              
            }
            txt_seqsubject.Text = subject;
            cbo_state.SelectedItem = state;
            txt_tutor_num.Text = tutor_num;
            txt_tutor_name.Text = tutor_name;
            txt_remark.Text = remark;
        }
    }
}





