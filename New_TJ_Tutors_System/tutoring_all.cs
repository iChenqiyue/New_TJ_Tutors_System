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
        string user = objectclass.userinfo.username;
        string select_tutoring_str = "select print_num as 打印编号,parent_num as 家长编号,parent_name as 家长称呼,phone as 联系方式,"
            + "tutor_state as 家教状态,payment_state as 缴费状态,grade_stu as 年级,subject_stu as 科目,simple_adr as 家教地址,"
            + "student_sex as 学员性别,tutor_time as 家教时间,tutor_price as 家教价格,remarks as 重要备注,latest_time as 最近更新时间"
            + " from tutoring ";
        string insert_tutoring_str = "(parent_num,print_num,reception,reception_time,parent_name,phone,simple_adr,detail_adr,grade_stu,subject_stu," +
            "student_sex,tutor_price,tutor_time,sex,place,grade,subject,other_request,payment_state,tutor_state,remarks,latest_time)";
        string insert_business_str = "(print_num,tutor_num,tutor_name,subject,state,time,reception,remarks,now)";
        objectclass.tutoringinfo tutoring1 = new objectclass.tutoringinfo();
        objectclass.tutorinfo tutor1 = new objectclass.tutorinfo();
        objectclass.business bus1 = new objectclass.business();
        bool insertstate = false;
        string tutor_num = "";
        string tutor_name = "";
        string[] subject;


        //构造函数
        public tutoring_all()
        {
            InitializeComponent();
        }

        #region 初始化

        #region 窗口初始化
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
            //openchidform(new tutor_search(), paneltutor);

            dgvstyle.ColorDataGridView(dgv_search);
            dgvstyle.ColorDataGridView(dgv_subject);
            dgvstyle.ColorDataGridView(dgv_done);
            dgv_done.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvstyle.ColorDataGridView(dgv_exist);
            dgv_exist.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

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


        #region 数据初始化
        /// <summary>
        /// 将选中单元格数据赋值到对象
        /// </summary>
        public void datainit()
        {
            string mysql = "";
            string tablename = "tutoring";

            DataSet info;
            //新建对象tutoring_info
            tutoring1.print_num = dgv_search.SelectedRows[0].Cells[0].Value.ToString();
            mysql = "select * from tutoring where print_num= " + tutoring1.print_num;
            try
            {
                info = mydb.ExecuteQuery(mysql, tablename);
                mysql = "select name from worker where isleave='否'";
                cbobind.tablecbobind(cbo_reception, mysql, "workers", "name");
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

        #endregion



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
                mysql = select_tutoring_str + "order by latest_time desc";
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
            //dgvbind.dgvbind(dgv_search, mysql, tablename);
            pages_divided(mysql, tablename);
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
            paneltutor.Visible = false;
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
            txt_parent_num.Text = tutoring1.parent_num;
            txt_print_num.Text = tutoring1.print_num;
            cbo_reception.Text = tutoring1.reception;
            dt_recepiton_time.Text = tutoring1.reception_time;
            txt_parent_name.Text = tutoring1.parent_name;
            txt_phone.Text = tutoring1.phone;
            txt_sadd.Text = tutoring1.simple_adr;
            txt_dadd.Text = tutoring1.detail_adr;
            txt_grade_stu.Text = tutoring1.grade_stu;
            txt_subject_stu.Text = tutoring1.subject_stu;
            if (tutoring1.student_sex == "男")
                rdo_man.Checked = true;
            else if (tutoring1.student_sex == "女")
                rdo_woman.Checked = true;
            else { }
            txt_tutor_price.Text = tutoring1.tutors_price;
            txt_tutor_time.Text = tutoring1.tutors_time;
            cbo_sex.Text = tutoring1.sex;
            txt_place.Text = tutoring1.place;
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


        /// <summary>
        /// 显示办理业务页
        /// </summary>A
        public void showbusiness()
        {
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
        #endregion

        #region 新增、更新和删除

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
            //重置tutoring1
            tutoring1.reset();
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
            tutoring1.parent_num = tempnum.ToString();
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
            tutoring1.print_num = tempnum.ToString();
            //初始化缴费、家教状态和性别
            cbo_payment_state.SelectedItem = "无需缴纳";
            tutoring1.payment_state = "无需缴纳";
            cbo_tutor_state.SelectedItem = "接入";
            tutoring1.tutor_state = "接入";
            rdo_man.Checked = false;
            rdo_woman.Checked = false;
            tutoring1.grade = "不限";
            cbo_reception.SelectedItem = null;
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

            string history = "";
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
            if (is_empty(cbo_reception.SelectedItem.ToString()))
            {
                MessageBox.Show("请选择接待人！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rdo_woman.Checked == false && rdo_man.Checked == false)
            {
                MessageBox.Show("请选择学员性别！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //初始化数据
            //判断科目是否被更改
            bool subject_changed = false;
            if (tutoring1.subject_stu != txt_subject_stu.Text.Trim())
                subject_changed = true;

            updateinfo(ref history, ref tutoring1.parent_num, txt_parent_num.Text.Trim());
            updateinfo(ref history, ref tutoring1.print_num, txt_print_num.Text.Trim());
            updateinfo(ref history, ref tutoring1.parent_name, txt_parent_name.Text.Trim());
            updateinfo(ref history, ref tutoring1.reception, cbo_reception.SelectedItem.ToString());
            updateinfo(ref history, ref tutoring1.phone, txt_phone.Text.Trim());
            updateinfo(ref history, ref tutoring1.simple_adr, txt_sadd.Text.Trim());
            updateinfo(ref history, ref tutoring1.detail_adr, txt_dadd.Text.Trim());
            updateinfo(ref history, ref tutoring1.grade_stu, txt_grade_stu.Text.Trim());
            updateinfo(ref history, ref tutoring1.subject_stu, txt_subject_stu.Text.Trim());
            tutoring1.reception_time = dt_recepiton_time.Value.ToString();
            /*tutoring1.parent_num = txt_parent_num.Text.Trim();
            tutoring1.print_num = txt_print_num.Text.Trim();
            tutoring1.reception = cbo_reception.SelectedItem.ToString();
            
            tutoring1.parent_name = txt_parent_name.Text.Trim();
            tutoring1.phone = txt_phone.Text.Trim();
            tutoring1.simple_adr = txt_sadd.Text.Trim();
            tutoring1.detail_adr = txt_dadd.Text.Trim();
            tutoring1.grade_stu = txt_grade_stu.Text.Trim();
            tutoring1.subject_stu = txt_subject_stu.Text.Trim();*/
            if (rdo_man.Checked == true)
                tutoring1.student_sex = "男";
            if (rdo_woman.Checked == true)
                tutoring1.student_sex = "女";


            updateinfo(ref history, ref tutoring1.tutors_price, txt_tutor_price.Text.Trim());
            updateinfo(ref history, ref tutoring1.tutors_time, txt_tutor_time.Text.Trim());
            updateinfo(ref history, ref tutoring1.sex, cbo_sex.SelectedItem.ToString());
            updateinfo(ref history, ref tutoring1.place, txt_place.Text.Trim());
            updateinfo(ref history, ref tutoring1.grade, txt_grade.Text.Trim());
            updateinfo(ref history, ref tutoring1.subject, txt_subject.Text.Trim());
            updateinfo(ref history, ref tutoring1.other_requests, txt_other_requests.Text.Trim());

            /*tutoring1.tutors_price = txt_tutor_price.Text.Trim();
            tutoring1.tutors_time = txt_tutor_time.Text.Trim();
            tutoring1.sex = cbo_sex.SelectedItem.ToString();
            tutoring1.place = txt_place.Text.Trim();
            tutoring1.grade = txt_grade.Text.Trim();
            tutoring1.subject = txt_subject.Text.Trim();
            tutoring1.other_requests = txt_other_requests.Text.Trim();*/


            bool payment_changed = false;
            if (tutoring1.payment_state != "已缴" && cbo_payment_state.SelectedItem.ToString() == "已缴")
            {
                payment_changed = true;
            }
            updateinfo(ref history, ref tutoring1.payment_state, cbo_payment_state.SelectedItem.ToString());
            //tutoring1.payment_state = cbo_payment_state.SelectedItem.ToString();
            subject = tutoring1.subject_stu.Split('、');
            if (tutoring1.payment_state != "已缴")
            {
                tutoring1.payment_time = null;
            }
            else
            {
                tutoring1.payment_time = dt_payment_time.Value.ToString();
            }


            tutoring1.latest_time = DateTime.Now.ToString();

            //插入新家教信息
            if (insertstate == true)
            {
                tutoring1.tutor_state = "接入";
                tutoring1.remarks = "";

                mysql = "insert into tutoring " + insert_tutoring_str + " values " + tutoring1.connectstr();
                DialogResult result = MessageBox.Show("确认新增家教信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        mydb.ExecuteNonQuery(mysql);
                        Console.WriteLine(history);
                        mysql = string.Format("insert into history (user,optype,num,time,content) values ('{0}', '{1}', '{2}', '{3}','{4}')",
                            user, "新增家教信息", tutoring1.print_num, DateTime.Now.ToString(), history);
                        Console.WriteLine(mysql);
                        mydb.ExecuteNonQuery(mysql);
                        if (tutoring1.payment_time != null)
                        {
                            mydb.update_payment_date(tutoring1.print_num, tutoring1.payment_time);
                            if (payment_changed == true)
                            {
                                mysql = string.Format("insert into history (user,optype,num,time) values ('{0}', '{1}', '{2}', '{3}')",
                                user, "缴费", tutoring1.print_num, DateTime.Now.ToString());
                                mydb.ExecuteNonQuery(mysql);
                            }
                        }
                        for (int i = 0; i < subject.Length; i++)
                        {
                            //string insert_business_str = "(print_num,tutor_num,subject,state,time,reception,remarks,now";
                            mysql = string.Format("insert into business (print_num,subject,time,reception) values ('{0}', '{1}', '{2}', '{3}')",
                                tutoring1.print_num, subject[i], DateTime.Now.ToString(), tutoring1.reception);

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
                mysql = tutoring1.updatestr();

                DialogResult result = MessageBox.Show("确认更新家教信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                    return;
                else
                {
                    try
                    {
                        mydb.ExecuteNonQuery(mysql);
                        mysql = string.Format("insert into history (user,optype,num,time,content) values ('{0}', '{1}', '{2}', '{3}','{4}')",
                            user, "更新家教信息", tutoring1.print_num, DateTime.Now.ToString(), history);
                        mydb.ExecuteNonQuery(mysql);
                        if (tutoring1.payment_time != null)
                        {
                            mydb.update_payment_date(tutoring1.print_num, tutoring1.payment_time);
                            if (payment_changed == true)
                            {
                                mysql = string.Format("insert into history (user,optype,num,time) values ('{0}', '{1}', '{2}', '{3}')",
                                user, "缴费", tutoring1.print_num, DateTime.Now.ToString());
                                mydb.ExecuteNonQuery(mysql);
                            }
                        }


                        ///更新关于科目的更更改
                        ///
                        if (subject_changed == true)
                        {
                            string temp = "";
                            for (int i = 0; i < subject.Length; i++)
                            {
                                mysql = string.Format("insert into business(print_num, subject, time) select '{0}','{1}','{2}' from dual " +
                                    "where not exists(select 1 from business where print_num = '{3}' and subject ='{4}')", tutoring1.print_num,
                                    subject[i], DateTime.Now.ToString(), tutoring1.print_num, subject[i]);
                                temp += "'" + subject[i] + "',";
                                mydb.ExecuteNonQuery(mysql);
                            }

                            temp = temp.Substring(0, temp.Length - 1);
                            mysql = "update business set now=0 where print_num='" + tutoring1.print_num +
                                      "' and subject not in(" + temp + ")";
                            Console.WriteLine(mysql);
                            mydb.ExecuteNonQuery(mysql);


                        }

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

            if (cbo_payment_state.SelectedItem.ToString() == tutoring1.payment_state || cbo_payment_state.SelectedItem.ToString() == "无需缴纳")//判断是否更改状态
                return;
            DialogResult result = MessageBox.Show("确认修改缴费状态？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)//判断是否更改家教状态
            {
                cbo_payment_state.SelectedItem = tutoring1.payment_state;
                return;
            }
            if (cbo_payment_state.SelectedItem.ToString() == "已缴")
            {
                dt_payment_time.Enabled = true;
            }
            else
                dt_payment_time.Enabled = false;
        }


        /// <summary>
        /// 删除家教信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {

            string mysql = "";
            mysql = "delete from tutoring where print_num= " + tutoring1.print_num;
            DialogResult result = MessageBox.Show("确认删除该条信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            else
            {
                try
                {
                    mydb.ExecuteNonQuery(mysql);
                    mysql = string.Format("insert into history (user,optype,num,time) values ('{0}', '{1}', '{2}', '{3}')",
                            user, "删除家教信息", tutoring1.print_num, DateTime.Now.ToString());
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

        private void updateinfo(ref string history, ref string str1, string str2)
        {
            if (str1 != str2)
                history += str1 + "->" + str2 + ";";
            str1 = str2;
        }

        #region 家教业务办理
        /// <summary>
        /// 保存家教状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_buss_Click(object sender, EventArgs e)
        {

            string history = "";
            updateinfo(ref history, ref tutoring1.tutor_state, cbo_tutor_state.SelectedItem.ToString());
            updateinfo(ref history, ref tutoring1.remarks, txt_remarks.Text.Trim());
            tutoring1.latest_time = DateTime.Now.ToString();
            string mysql = "";
            mysql = string.Format("update tutoring set tutor_state='{0}',remarks='{1}',latest_time='{2}' WHERE print_num='{3}'",
                tutoring1.tutor_state, tutoring1.remarks, tutoring1.latest_time, tutoring1.print_num);
            DialogResult result = MessageBox.Show("确认保存？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            else
            {
                try
                {
                    mydb.ExecuteNonQuery(mysql);
                    mysql = string.Format("insert into history (user,optype,num,time,content) values ('{0}', '{1}', '{2}', '{3}','{4}')",
                            user, "更新家教状态/备注", tutoring1.print_num, DateTime.Now.ToString(), history);
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

            if (dgv_subject.SelectedRows.Count != 0)
            {
                bus1.subject = dgv_subject.SelectedRows[0].Cells[0].Value.ToString();
                bus1.state = dgv_subject.SelectedRows[0].Cells[1].Value.ToString();
                bus1.tutor_num = dgv_subject.SelectedRows[0].Cells[2].Value.ToString();
                bus1.tutor_name = dgv_subject.SelectedRows[0].Cells[3].Value.ToString();
                bus1.remarks = dgv_subject.SelectedRows[0].Cells[4].Value.ToString();
            }
            cbo_subject.Text = bus1.subject;
            cbo_state.SelectedItem = bus1.state;
            txt_tutor_num.Text = bus1.tutor_num;
            txt_tutor_name.Text = bus1.tutor_name;
            txt_remark.Text = bus1.remarks;
        }
        #endregion

        /// <summary>
        /// 调用教员搜索窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_searchtutor_Click(object sender, EventArgs e)
        {
            /*if (dgv_subject.SelectedRows.Count > 0)
                dgv_subject.SelectedRows[0].Selected = false;
            cbo_subject.SelectedItem = null;
            cbo_state.SelectedItem = null;
            txt_tutor_name.Text = "";
            txt_tutor_num.Text = "";*/

            tutor_search myform = new tutor_search();
            myform.tutorselected += new tutorselectHandler(tutorselect);
            myform.ShowDialog();
        }
        /// <summary>
        /// 显示返回的教员信息
        /// </summary>
        /// <param name="num"></param>
        /// <param name="name"></param>
        public void tutorselect(string num, string name)
        {
            tutor_num = num;
            tutor_name = name;
            txt_tutor_num.Text = tutor_num;
            txt_tutor_name.Text = tutor_name;
        }

        /// <summary>
        /// 业务办理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bus_Click(object sender, EventArgs e)
        {

            string history = "";

            bus1.print_num = tutoring1.print_num;

            bus1.subject = cbo_subject.Text;
            history += bus1.subject + ":";
            updateinfo(ref history, ref bus1.state, cbo_state.SelectedItem.ToString());
            updateinfo(ref history, ref bus1.tutor_num, txt_tutor_num.Text.Trim());
            updateinfo(ref history, ref bus1.tutor_name, txt_tutor_name.Text.Trim());
            updateinfo(ref history, ref bus1.remarks, txt_remarks.Text.Trim());

            /*bus.state = cbo_state.SelectedItem.ToString();
            bus.tutor_num = txt_tutor_num.Text.Trim();
            bus.tutor_name = txt_tutor_name.Text.Trim();
            
            bus.remarks = txt_remark.Text.Trim();*/
            bus1.time = DateTime.Now.ToString();
            bus1.reception = "";
            /*if (bus.state == "换人" || bus.state == "不请" || bus.state == "重请")
                bus.now = "0";
            else
                bus.now = "1";*/
            bus1.now = "1";

            string mysql = "insert into business " + insert_business_str + " values " + bus1.connectstr();
            Console.WriteLine(mysql);
            DialogResult result = MessageBox.Show("确认办理？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
                return;
            else
            {
                try
                {
                    mydb.ExecuteNonQuery(mysql);
                    mysql = string.Format("insert into history (user,optype,num,time,content) values ('{0}', '{1}', '{2}', '{3}','{4}')",
                            user, "办理业务", tutoring1.print_num, DateTime.Now.ToString(), history);
                    mydb.ExecuteNonQuery(mysql);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MessageBox.Show("办理成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                showbusiness();
            }
        }

        #region 查看相应教员信息
        /// <summary>
        /// 数据初始化
        /// </summary>
        public void tutordatainit()
        {
            string mysql = "";
            string tablename = "tutor";

            DataSet info;
            //新建对象tutoring_info
            tutor1.tutor_num = dgv_done.SelectedRows[0].Cells[2].Value.ToString();
            if (tutor1.tutor_num == "")
            {
                paneltutor.Visible = false;
                return;
            }
            paneltutor.Visible = true;
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

        /// <summary>
        /// 显示教员详细信息
        /// </summary>
        public void showtutor()
        {

            txt_num.Text = tutor1.tutor_num;
            txt_student_name.Text = tutor1.name;
            txt_student_num.Text = tutor1.student_num;
            cbocollege.Text = tutor1.subject;
            cbo_degree.SelectedItem = tutor1.degree;
            txttutorplace.Text = tutor1.place;
            txttutorphone.Text = tutor1.phone;
            txt_important_remarks.Text = tutor1.remarks;
            cbo_yesno.SelectedItem = tutor1.blacklist;
            txt_imprisonment.Text = tutor1.explantion;


            if (tutor1.sex == "男")
                rdotutorman.Checked = true;
            else if (tutor1.sex == "女")
                rdotutorwoman.Checked = true;
            else { }

            string tablename = "business";
            string mysql = "select print_num as 编号,subject as 科目,state as 状态,remarks as 备注 " +
                "from business where idbusiness in (select max(idbusiness) from business where tutor_num='" + tutor1.tutor_num + "' and now=1 group by subject)";
            dgvbind.dgvbind(dgv_exist, mysql, tablename);
        }

        private void dgv_done_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_done.SelectedRows.Count != 0)
            {
                //paneltutor.Visible = true;
                if (dgv_search.SelectedRows.Count != 0)
                    tutordatainit();

                insertstate = false;
                showtutor();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            paneltutor.Visible = false;
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


    }
}
