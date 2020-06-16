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


    public partial class tutor_all : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        //全局变量
        public int pageSize = 20;      //每页记录数
        public int recordCount = 0;    //总记录数
        public int pageCount = 0;      //总页数
        public int currentPage = 0;    //当前页
        DataTable dtSource = new DataTable();

        styleinit dgvstyle = new styleinit();
        databind dgvbind = new databind();
        databind cbobind = new databind();
        commondb mydb = new commondb();
        objectclass.tutorinfo tutor1 = new objectclass.tutorinfo();
        objectclass.tutoringinfo tutoring1 = new objectclass.tutoringinfo();
        bool insertstate = false;
        string select_tutor_str = "select tutor_num as 教员编号,name as 姓名,student_num as 学号,subject as 专业,degree as 学位," +
            "sex as 性别,phone as 联系方式,place as 生源地,blacklist as 是否黑名单,remarks as 备注 from tutor ";
        string insert_tutor_str = "(tutor_num,name,student_num,subject,degree,sex,phone,place,blacklist,explanation,remarks)";
        public tutor_all()
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
        

        private void tutor_all_Load(object sender, EventArgs e)
        {
            paneltutoring.Visible = false;
            //openchidform(new tutor_search(), panelleft);

            //初始化控件
            txt_num_search.Text = "教员编号";
            txt_name_search.Text = "教员姓名";
            txt_stunum_search.Text = "学号";
            txt_phone_search.Text = "联系方式";            

            //调用窗口
            //openchidform(new tutor_search(), paneltutor);

            dgvstyle.ColorDataGridView(dgv_search);
            dgvstyle.ColorDataGridView(dgv_exist);
            
            dgv_exist.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvstyle.ColorDataGridView(dgv_subject);
            dgvstyle.ColorDataGridView(dgv_done);
            dgv_done.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            cbo_select.SelectedItem = "全部";

            //绑定表格数据           
            //更改到cbo_select中初始化
            //string mystr = "select * from tutoring";                       
            //dgvbind.dgvbind(dgv_search, mystr, "tutoring");

            //初始化右侧详细信息

            datainit();

            
            showtutor();
        }

        #endregion


        #region 数据初始化

        /// <summary>
        /// 数据初始化
        /// </summary>
        public void datainit()
        {
            string mysql = "";
            string tablename = "tutor";

            DataSet info;
            //新建对象tutoring_info
            tutor1.tutor_num = dgv_search.SelectedRows[0].Cells[0].Value.ToString();
            //Console.WriteLine(tutor1.print_num);
            mysql = "select * from tutor where tutor_num= " + tutor1.tutor_num;
            try
            {
                info = mydb.ExecuteQuery(mysql, tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            tutor1.name = info.Tables[0].Rows[0].ItemArray[1].ToString();
            tutor1.student_num = info.Tables[0].Rows[0].ItemArray[2].ToString();
            tutor1.subject = info.Tables[0].Rows[0].ItemArray[3].ToString();
            tutor1.degree = info.Tables[0].Rows[0].ItemArray[4].ToString();
            tutor1.sex = info.Tables[0].Rows[0].ItemArray[5].ToString();
            tutor1.phone = info.Tables[0].Rows[0].ItemArray[6].ToString();
            tutor1.place = info.Tables[0].Rows[0].ItemArray[7].ToString();
            tutor1.blacklist = info.Tables[0].Rows[0].ItemArray[8].ToString();
            tutor1.explantion = info.Tables[0].Rows[0].ItemArray[9].ToString();
            tutor1.remarks = info.Tables[0].Rows[0].ItemArray[10].ToString();
        }
        #endregion

        #region textbox控件初始化
        private void txt_num_search_Enter(object sender, EventArgs e)
        {
            if (txt_num_search.Text.Trim() == "教员编号")
            {
                txt_num_search.Text = "";
            }
        }

        private void txt_num_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_num_search_Leave(object sender, EventArgs e)
        {
            if (txt_num_search.Text.Trim().Length == 0)
            {
                txt_num_search.Text = "教员编号";
            }
        }

        private void txt_name_search_Enter(object sender, EventArgs e)
        {
            if (txt_name_search.Text.Trim() == "教员姓名")
            {
                txt_name_search.Text = "";
            }
        }

        private void txt_name_search_Leave(object sender, EventArgs e)
        {
            if (txt_name_search.Text.Trim().Length == 0)
            {
                txt_name_search.Text = "教员姓名";
            }
        }

        private void txt_stunum_search_Enter(object sender, EventArgs e)
        {
            if (txt_stunum_search.Text.Trim() == "学号")
            {
                txt_stunum_search.Text = "";
            }
        }

        private void txt_stunum_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txt_stunum_search_Leave(object sender, EventArgs e)
        {
            if (txt_stunum_search.Text.Trim().Length == 0)
            {
                txt_stunum_search.Text = "学号";
            }
        }

        private void txt_phone_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
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

        //教员编号数字限制
        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //学号数字限制
        private void txt_student_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        //联系方式数字限制
        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
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
            string mysql = select_tutor_str;
            string tablename = "tutor";
            if (cbo_select.SelectedItem.ToString() == "全部")
            {
                mysql += "order by tutor_num desc";
                Console.WriteLine(mysql);
            }
            else if (cbo_select.SelectedItem.ToString() == "黑名单")
            {
                mysql += "where blacklist='是' order by tutor_num desc";
            }
            else if (cbo_select.SelectedItem.ToString() == "非黑名单")
            {
                mysql += "where blacklist='否' order by tutor_num desc";
            }
            else { }
            //dgvbind.dgvbind(dgv_search, mysql, tablename);
            pages_divided(mysql, tablename);
            LoadPage();//调用加载数据的方法
        }
        ///LoadPage方法
        /// <summary>
        /// loaddpage方法
        /// </summary>
        private void LoadPage()
        {
            if (currentPage < 1) currentPage = 1;
            if (currentPage > pageCount) currentPage = pageCount;

            int beginRecord;
            int endRecord;
            DataTable dtTemp;
            dtTemp = dtSource.Clone();

            beginRecord = pageSize * (currentPage - 1);
            if (currentPage == 1) beginRecord = 0;
            endRecord = pageSize * currentPage;

            if (currentPage == pageCount) endRecord = recordCount;
            for (int i = beginRecord; i < endRecord; i++)
            {
                dtTemp.ImportRow(dtSource.Rows[i]);
            }
            dgv_search.DataSource = dtTemp;  //datagridview控件名是tf_dgv1
            txt_currentpage.Text = currentPage.ToString();//当前页
            lbl_pagetotal.Text = "/ " + pageCount.ToString();//总页数
            lbl_totalrecords.Text = "共 " + recordCount.ToString() + " 条记录";//总记录数
        }
        #endregion

        #endregion


        #region 搜索和筛选
        /// <summary>
        /// 搜索教员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            string mysql = "";
            string tablename = "tutor";
            string num = txt_num_search.Text.Trim();
            string name = txt_name_search.Text.Trim();
            string stunum = txt_stunum_search.Text.Trim();
            string phone = txt_phone_search.Text.Trim();

            if (num == "教员编号" && name == "教员姓名" && stunum == "学号" && phone == "联系方式")
            {
                mysql = select_tutor_str+ "order by tutor_num desc";
                dgvbind.dgvbind(dgv_search, mysql, "tutor");
                return;
            }
            string tempstr = "";
            if (num != "教员编号")
                tempstr = "tutor_num Like '%" + num + "%'";
            if (name != "教员姓名")
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
            mysql = select_tutor_str + "where " + tempstr + " order by tutor_num desc";
            //dgvbind.dgvbind(dgv_search, mysql, tablename);
            pages_divided(mysql, tablename);
            LoadPage();//调用加载数据的方法
        }

        private void pages_divided(string mysql, string tablename)
        {
            DataSet mydataset = mydb.ExecuteQuery(mysql, tablename);
            dtSource = mydataset.Tables[0];
            recordCount = dtSource.Rows.Count;
            pageCount = (recordCount / pageSize);
            if ((recordCount % pageSize) > 0)
            {
                pageCount++;
            }
            //默认第一页
            currentPage = 1;
            LoadPage();//调用加载数据的方法
        }
        /// <summary>
        /// 筛选条件变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            paneltutoring.Visible = false;
            if (dgv_search.SelectedRows.Count != 0)
                datainit();

            insertstate = false;
            showtutor();
        }
        /// <summary>
        /// 显示教员详细信息
        /// </summary>
        public void showtutor()
        {

            txt_num.Text = tutor1.tutor_num;
            txt_student_name.Text = tutor1.name;
            txt_student_num.Text = tutor1.student_num;
            cbo_subject.Text = tutor1.subject;
            cbo_degree.SelectedItem = tutor1.degree;
            txt_place.Text = tutor1.place;
            txt_phone.Text = tutor1.phone;
            txt_important_remarks.Text = tutor1.remarks;
            cbo_yesno.SelectedItem = tutor1.blacklist;
            txt_imprisonment.Text = tutor1.explantion;


            if (tutor1.sex == "男")
                rdo_man.Checked = true;
            else if (tutor1.sex == "女")
                rdo_woman.Checked = true;
            else { }

            string tablename = "business";
            string mysql = "select print_num as 编号,subject as 科目,state as 状态,remarks as 备注 " +
                "from business where idbusiness in (select max(idbusiness) from business where tutor_num='" + tutor1.tutor_num + "' and now=1 group by subject)";
            dgvbind.dgvbind(dgv_exist, mysql, tablename);
        }


        #endregion

        #region 新增、更新和删除
        /// <summary>
        /// 新增教员信息
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

            //数据准备，初始化教员编号
            //教员编号+1
            mysql = "select max(tutor_num) from tutor";
            try
            {
                tempnum = int.Parse(mydb.Returnafield(mysql)) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tutor1.tutor_num = tempnum.ToString();

            //初始化学位和性别和是否黑名单
            cbo_degree.SelectedItem = null;
            rdo_man.Checked = false;
            rdo_woman.Checked = false;
            cbo_yesno.SelectedItem = "否";
            //判断数组非空           
            showtutor();
        }

        /// <summary>
        /// 新增或更新教员信息  标志位insertstate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            //封装数组
            TextBox[] txt = { txt_num, txt_student_name, txt_student_num, txt_phone, txt_place };
            string[] message = { "教员编号", "教员姓名", "学号", "联系方式", "生源地" };
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
            tutor1.tutor_num = txt_num.Text.Trim();
            tutor1.name = txt_student_name.Text.Trim();
            tutor1.student_num = txt_student_num.Text.Trim();
            tutor1.subject = cbo_subject.Text.Trim();
            tutor1.degree = cbo_degree.SelectedItem.ToString();
            tutor1.phone = txt_phone.Text.Trim();
            tutor1.place = txt_place.Text.Trim();
            if (rdo_man.Checked == true)
                tutor1.sex = "男";
            rdo_man.Checked = true;
            if (rdo_woman.Checked == true)
                tutor1.sex = "女";
            tutor1.remarks = txt_important_remarks.Text.Trim();
            tutor1.blacklist = cbo_yesno.SelectedItem.ToString();
            tutor1.explantion = txt_imprisonment.Text.Trim();


            //插入新家教信息
            if (insertstate == true)
            {
                mysql = "insert into tutor " + insert_tutor_str + " values " + tutor1.connectstr();
                Console.WriteLine(mysql);
                DialogResult result = MessageBox.Show("确认新增教员信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                mysql = tutor1.updatestr();
                Console.WriteLine(mysql);
                DialogResult result = MessageBox.Show("确认更新教员信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
        #endregion


        #region 删除教员信息
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string mysql = "";
            mysql = "delete from tutor where tutor_num= " + tutor1.tutor_num;
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



        #endregion

        #region 查看相应家教信息
        private void dgv_exist_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }


        /// <summary>
        /// 将选中单元格数据赋值到对象
        /// </summary>
        public void tutoringdatainit()
        {
            string mysql = "";
            string tablename = "tutoring";

            DataSet info;
            //新建对象tutoring_info
            tutoring1.print_num = dgv_exist.SelectedRows[0].Cells[0].Value.ToString();
            Console.WriteLine(tutoring1.print_num);
            mysql = "select * from tutoring where print_num= " + tutoring1.print_num;
            try
            {
                info = mydb.ExecuteQuery(mysql, tablename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            tutoring1.parent_num = info.Tables[0].Rows[0].ItemArray[1].ToString();
            tutoring1.reception = info.Tables[0].Rows[0].ItemArray[2].ToString();
            tutoring1.reception_time = info.Tables[0].Rows[0].ItemArray[3].ToString();
            tutoring1.parent_name = info.Tables[0].Rows[0].ItemArray[4].ToString();
            tutoring1.phone = info.Tables[0].Rows[0].ItemArray[5].ToString();
            tutoring1.simple_adr = info.Tables[0].Rows[0].ItemArray[6].ToString();
            tutoring1.detail_adr = info.Tables[0].Rows[0].ItemArray[7].ToString();
            tutoring1.grade_stu = info.Tables[0].Rows[0].ItemArray[8].ToString();
            tutoring1.subject_stu = info.Tables[0].Rows[0].ItemArray[9].ToString();
            tutoring1.student_sex = info.Tables[0].Rows[0].ItemArray[10].ToString();
            tutoring1.tutors_price = info.Tables[0].Rows[0].ItemArray[11].ToString();
            tutoring1.tutors_time = info.Tables[0].Rows[0].ItemArray[12].ToString();
            tutoring1.sex = info.Tables[0].Rows[0].ItemArray[13].ToString();
            tutoring1.place = info.Tables[0].Rows[0].ItemArray[14].ToString();
            tutoring1.grade = info.Tables[0].Rows[0].ItemArray[15].ToString();
            tutoring1.subject = info.Tables[0].Rows[0].ItemArray[16].ToString();
            tutoring1.other_requests = info.Tables[0].Rows[0].ItemArray[17].ToString();
            tutoring1.payment_state = info.Tables[0].Rows[0].ItemArray[18].ToString();
            tutoring1.payment_time = info.Tables[0].Rows[0].ItemArray[19].ToString();
            tutoring1.tutor_state = info.Tables[0].Rows[0].ItemArray[20].ToString();
            tutoring1.remarks = info.Tables[0].Rows[0].ItemArray[21].ToString();
        }

        /// <summary>
        /// 显示详细信息页
        /// </summary>
        public void showtutoring()
        {

            panelselect1.Visible = true;
            panelselect2.Visible = false;
            txt_parent_num.Text = tutoring1.parent_num;
            txt_print_num.Text = tutoring1.print_num;
            cbo_reception.Text = tutoring1.reception;
            dt_recepiton_time.Text = tutoring1.reception_time;
            txt_parent_name.Text = tutoring1.parent_name;
            txt_stuphone.Text = tutoring1.phone;
            txt_sadd.Text = tutoring1.simple_adr;
            txt_dadd.Text = tutoring1.detail_adr;
            txt_grade_stu.Text = tutoring1.grade_stu;
            txt_subject_stu.Text = tutoring1.subject_stu;
            if (tutoring1.student_sex == "男")
                rdo_stuman.Checked = true;
            else if (tutoring1.student_sex == "女")
                rdo_stuwoman.Checked = true;
            else { }
            txt_tutor_price.Text = tutoring1.tutors_price;
            txt_tutor_time.Text = tutoring1.tutors_time;
            cbo_sex.Text = tutoring1.sex;
            txt_reqplace.Text = tutoring1.place;
            txt_grade.Text = tutoring1.grade;
            txt_subject.Text = tutoring1.subject;
            txt_other_requests.Text = tutoring1.other_requests;
            cbo_payment_state.Text = tutoring1.payment_state;

            if (tutoring1.payment_state != "已缴")
            {
                dt_payment_time.Enabled = false;
                dt_payment_time.Text = null;
            }
            else
            {
                dt_payment_time.Enabled = true;
                dt_payment_time.Text = tutoring1.payment_time;
            }



        }
        private void dgv_exist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_exist.SelectedRows.Count != 0)
            {
                paneltutoring.Visible = true;
                pantutoring.BringToFront();
                if (dgv_search.SelectedRows.Count != 0)
                    tutoringdatainit();

                btn_select2.Enabled = true;
                btn_select1.Enabled = true;

                insertstate = false;
                showtutoring();
            }
        }

        private void btn_select1_Click(object sender, EventArgs e)
        {
            panelselect1.Visible = true;
            panelselect2.Visible = false;

            pantutoring.BringToFront();

            tutoringdatainit();
            showtutoring();
        }

        private void btn_select2_Click(object sender, EventArgs e)
        {
            panelselect1.Visible = false;
            panelselect2.Visible = true;
            panelmid.BringToFront();

            tutoringdatainit();
            showbusiness();
        }

        public void showbusiness()
        {
            string[] subject;
            subject = tutoring1.subject_stu.Split('、');
            cbobind.listcbobind(cbo_subject, subject);
            cbo_tutor_state.SelectedItem = tutoring1.tutor_state;
            txt_remarks.Text = tutoring1.remarks;
            string tablename = "business";
            string mysql = "select subject as 科目,state as 状态,tutor_num as 编号,tutor_name as 姓名,remarks as 备注 " +
                "from business where idbusiness in (select max(idbusiness) from business where print_num='" + tutoring1.print_num + "' and now=1 group by subject)";
            dgvbind.dgvbind(dgv_subject, mysql, tablename);
            dgv_subject.Columns[2].Visible = false;
            dgv_subject.Columns[4].Visible = false;
            mysql = "select subject as 科目,state as 状态,tutor_num as 编号,tutor_name as 姓名,remarks as 备注,time as 时间 " +
                "from business  where print_num='" + tutoring1.print_num + "' order by subject,time desc";
            dgvbind.dgvbind(dgv_done, mysql, tablename);

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            paneltutoring.Visible = false;
        }



        private void dgv_subject_SelectionChanged(object sender, EventArgs e)
        {
            string subject = "";
            string state = "";
            string tutor_num = "";
            string tutor_name = "";
            string remark = "";
            //新建对象tutoring_info
            if (dgv_subject.SelectedRows.Count != 0)
            {
                subject = dgv_subject.SelectedRows[0].Cells[0].Value.ToString();
                state = dgv_subject.SelectedRows[0].Cells[1].Value.ToString();
                tutor_num = dgv_subject.SelectedRows[0].Cells[2].Value.ToString();
                tutor_name = dgv_subject.SelectedRows[0].Cells[3].Value.ToString();
                remark = dgv_subject.SelectedRows[0].Cells[4].Value.ToString();
            }
            //Console.WriteLine(subject);
            txt_sesubject.Text = subject;
            //Console.WriteLine(cbo_subject.Text);
            cbo_state.SelectedItem = state;
            txt_tutor_num.Text = tutor_num;
            txt_tutor_name.Text = tutor_name;
            txt_remark.Text = remark;
        }

        #endregion

        private void btn_pre_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadPage();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadPage();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadPage();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            currentPage = pageCount;
            LoadPage();
        }

        private void txt_currentpage_Leave(object sender, EventArgs e)
        {
            string num = txt_currentpage.Text.Trim();
            if (num != "")
                currentPage = int.Parse(num);
            else
            {
                txt_currentpage.Text = "1";
                currentPage = 1;
            }
            LoadPage();
        }

        private void txt_currentpage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {

                string num = txt_currentpage.Text.Trim();
                if (num != "")
                    currentPage = int.Parse(num);
                else
                {
                    txt_currentpage.Text = "1";
                    currentPage = 1;
                }
                LoadPage();
            }
        }
    }
}
