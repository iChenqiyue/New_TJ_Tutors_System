namespace New_TJ_Tutors_System
{
    partial class tutor_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dt_payment_time = new System.Windows.Forms.DateTimePicker();
            this.cbo_payment_state = new System.Windows.Forms.ComboBox();
            this.gbo_request = new System.Windows.Forms.GroupBox();
            this.txt_place = new System.Windows.Forms.TextBox();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.cbo_sex = new System.Windows.Forms.ComboBox();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.txt_other_requests = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_place = new System.Windows.Forms.Label();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_other_requests = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_woman = new System.Windows.Forms.RadioButton();
            this.rdo_man = new System.Windows.Forms.RadioButton();
            this.dt_recepiton_time = new System.Windows.Forms.DateTimePicker();
            this.cbo_reception = new System.Windows.Forms.ComboBox();
            this.txt_tutor_time = new System.Windows.Forms.TextBox();
            this.txt_tutor_price = new System.Windows.Forms.TextBox();
            this.txt_subject_stu = new System.Windows.Forms.TextBox();
            this.txt_grade_stu = new System.Windows.Forms.TextBox();
            this.txt_dadd = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_sadd = new System.Windows.Forms.TextBox();
            this.txt_parent_name = new System.Windows.Forms.TextBox();
            this.txt_print_num = new System.Windows.Forms.TextBox();
            this.txt_parent_num = new System.Windows.Forms.TextBox();
            this.lbl_tutor_time = new System.Windows.Forms.Label();
            this.lbl_tutor_price = new System.Windows.Forms.Label();
            this.lbl_student_sex = new System.Windows.Forms.Label();
            this.lbl_subject_stu = new System.Windows.Forms.Label();
            this.lbl_grade_stu = new System.Windows.Forms.Label();
            this.lbl_dadd = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_sadd = new System.Windows.Forms.Label();
            this.lbl_parent_name = new System.Windows.Forms.Label();
            this.lbl_recepiton_time = new System.Windows.Forms.Label();
            this.lbl_reception = new System.Windows.Forms.Label();
            this.lbl_print_num = new System.Windows.Forms.Label();
            this.lbl_parent_num = new System.Windows.Forms.Label();
            this.lbl_payment_time = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_payment_state = new System.Windows.Forms.Label();
            this.gbo_request.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_payment_time
            // 
            this.dt_payment_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt_payment_time.Location = new System.Drawing.Point(302, 674);
            this.dt_payment_time.Name = "dt_payment_time";
            this.dt_payment_time.Size = new System.Drawing.Size(195, 27);
            this.dt_payment_time.TabIndex = 99;
            this.dt_payment_time.Value = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            // 
            // cbo_payment_state
            // 
            this.cbo_payment_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_payment_state.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_payment_state.FormattingEnabled = true;
            this.cbo_payment_state.Items.AddRange(new object[] {
            "无需缴纳",
            "免管理费",
            "待缴",
            "已缴"});
            this.cbo_payment_state.Location = new System.Drawing.Point(88, 674);
            this.cbo_payment_state.Name = "cbo_payment_state";
            this.cbo_payment_state.Size = new System.Drawing.Size(195, 28);
            this.cbo_payment_state.TabIndex = 98;
            // 
            // gbo_request
            // 
            this.gbo_request.Controls.Add(this.txt_place);
            this.gbo_request.Controls.Add(this.txt_grade);
            this.gbo_request.Controls.Add(this.cbo_sex);
            this.gbo_request.Controls.Add(this.txt_subject);
            this.gbo_request.Controls.Add(this.txt_other_requests);
            this.gbo_request.Controls.Add(this.lbl_sex);
            this.gbo_request.Controls.Add(this.lbl_place);
            this.gbo_request.Controls.Add(this.lbl_grade);
            this.gbo_request.Controls.Add(this.lbl_subject);
            this.gbo_request.Controls.Add(this.lbl_other_requests);
            this.gbo_request.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbo_request.ForeColor = System.Drawing.Color.White;
            this.gbo_request.Location = new System.Drawing.Point(39, 450);
            this.gbo_request.Name = "gbo_request";
            this.gbo_request.Size = new System.Drawing.Size(500, 203);
            this.gbo_request.TabIndex = 100;
            this.gbo_request.TabStop = false;
            this.gbo_request.Text = "家教要求";
            // 
            // txt_place
            // 
            this.txt_place.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_place.ForeColor = System.Drawing.Color.White;
            this.txt_place.Location = new System.Drawing.Point(262, 46);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(195, 27);
            this.txt_place.TabIndex = 45;
            // 
            // txt_grade
            // 
            this.txt_grade.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_grade.ForeColor = System.Drawing.Color.White;
            this.txt_grade.Location = new System.Drawing.Point(48, 95);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(195, 27);
            this.txt_grade.TabIndex = 47;
            // 
            // cbo_sex
            // 
            this.cbo_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_sex.ForeColor = System.Drawing.Color.White;
            this.cbo_sex.FormattingEnabled = true;
            this.cbo_sex.Items.AddRange(new object[] {
            "",
            "一定女生",
            "一定男生",
            "最好女生",
            "最好男生"});
            this.cbo_sex.Location = new System.Drawing.Point(48, 46);
            this.cbo_sex.Name = "cbo_sex";
            this.cbo_sex.Size = new System.Drawing.Size(195, 28);
            this.cbo_sex.TabIndex = 58;
            // 
            // txt_subject
            // 
            this.txt_subject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_subject.ForeColor = System.Drawing.Color.White;
            this.txt_subject.Location = new System.Drawing.Point(262, 95);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(195, 27);
            this.txt_subject.TabIndex = 49;
            // 
            // txt_other_requests
            // 
            this.txt_other_requests.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_other_requests.ForeColor = System.Drawing.Color.White;
            this.txt_other_requests.Location = new System.Drawing.Point(48, 144);
            this.txt_other_requests.Multiline = true;
            this.txt_other_requests.Name = "txt_other_requests";
            this.txt_other_requests.Size = new System.Drawing.Size(409, 50);
            this.txt_other_requests.TabIndex = 51;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_sex.ForeColor = System.Drawing.Color.White;
            this.lbl_sex.Location = new System.Drawing.Point(45, 28);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(39, 19);
            this.lbl_sex.TabIndex = 44;
            this.lbl_sex.Text = "性别";
            // 
            // lbl_place
            // 
            this.lbl_place.AutoSize = true;
            this.lbl_place.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_place.ForeColor = System.Drawing.Color.White;
            this.lbl_place.Location = new System.Drawing.Point(259, 28);
            this.lbl_place.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_place.Name = "lbl_place";
            this.lbl_place.Size = new System.Drawing.Size(39, 19);
            this.lbl_place.TabIndex = 46;
            this.lbl_place.Text = "地域";
            // 
            // lbl_grade
            // 
            this.lbl_grade.AutoSize = true;
            this.lbl_grade.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_grade.ForeColor = System.Drawing.Color.White;
            this.lbl_grade.Location = new System.Drawing.Point(45, 77);
            this.lbl_grade.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.Size = new System.Drawing.Size(39, 19);
            this.lbl_grade.TabIndex = 48;
            this.lbl_grade.Text = "年级";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_subject.ForeColor = System.Drawing.Color.White;
            this.lbl_subject.Location = new System.Drawing.Point(259, 77);
            this.lbl_subject.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(39, 19);
            this.lbl_subject.TabIndex = 50;
            this.lbl_subject.Text = "专业";
            // 
            // lbl_other_requests
            // 
            this.lbl_other_requests.AutoSize = true;
            this.lbl_other_requests.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_other_requests.ForeColor = System.Drawing.Color.White;
            this.lbl_other_requests.Location = new System.Drawing.Point(45, 126);
            this.lbl_other_requests.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_other_requests.Name = "lbl_other_requests";
            this.lbl_other_requests.Size = new System.Drawing.Size(69, 19);
            this.lbl_other_requests.TabIndex = 52;
            this.lbl_other_requests.Text = "其他要求";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_woman);
            this.groupBox1.Controls.Add(this.rdo_man);
            this.groupBox1.Controls.Add(this.dt_recepiton_time);
            this.groupBox1.Controls.Add(this.cbo_reception);
            this.groupBox1.Controls.Add(this.txt_tutor_time);
            this.groupBox1.Controls.Add(this.txt_tutor_price);
            this.groupBox1.Controls.Add(this.txt_subject_stu);
            this.groupBox1.Controls.Add(this.txt_grade_stu);
            this.groupBox1.Controls.Add(this.txt_dadd);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_sadd);
            this.groupBox1.Controls.Add(this.txt_parent_name);
            this.groupBox1.Controls.Add(this.txt_print_num);
            this.groupBox1.Controls.Add(this.txt_parent_num);
            this.groupBox1.Controls.Add(this.lbl_tutor_time);
            this.groupBox1.Controls.Add(this.lbl_tutor_price);
            this.groupBox1.Controls.Add(this.lbl_student_sex);
            this.groupBox1.Controls.Add(this.lbl_subject_stu);
            this.groupBox1.Controls.Add(this.lbl_grade_stu);
            this.groupBox1.Controls.Add(this.lbl_dadd);
            this.groupBox1.Controls.Add(this.lbl_phone);
            this.groupBox1.Controls.Add(this.lbl_sadd);
            this.groupBox1.Controls.Add(this.lbl_parent_name);
            this.groupBox1.Controls.Add(this.lbl_recepiton_time);
            this.groupBox1.Controls.Add(this.lbl_reception);
            this.groupBox1.Controls.Add(this.lbl_print_num);
            this.groupBox1.Controls.Add(this.lbl_parent_num);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(39, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 451);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // rdo_woman
            // 
            this.rdo_woman.AutoSize = true;
            this.rdo_woman.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_woman.ForeColor = System.Drawing.Color.White;
            this.rdo_woman.Location = new System.Drawing.Point(151, 365);
            this.rdo_woman.Name = "rdo_woman";
            this.rdo_woman.Size = new System.Drawing.Size(45, 23);
            this.rdo_woman.TabIndex = 85;
            this.rdo_woman.TabStop = true;
            this.rdo_woman.Text = "女";
            this.rdo_woman.UseVisualStyleBackColor = true;
            // 
            // rdo_man
            // 
            this.rdo_man.AutoSize = true;
            this.rdo_man.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_man.ForeColor = System.Drawing.Color.White;
            this.rdo_man.Location = new System.Drawing.Point(48, 365);
            this.rdo_man.Name = "rdo_man";
            this.rdo_man.Size = new System.Drawing.Size(45, 23);
            this.rdo_man.TabIndex = 84;
            this.rdo_man.TabStop = true;
            this.rdo_man.Text = "男";
            this.rdo_man.UseVisualStyleBackColor = true;
            // 
            // dt_recepiton_time
            // 
            this.dt_recepiton_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt_recepiton_time.Location = new System.Drawing.Point(262, 95);
            this.dt_recepiton_time.Name = "dt_recepiton_time";
            this.dt_recepiton_time.Size = new System.Drawing.Size(195, 27);
            this.dt_recepiton_time.TabIndex = 83;
            this.dt_recepiton_time.Value = new System.DateTime(2020, 4, 17, 0, 0, 0, 0);
            // 
            // cbo_reception
            // 
            this.cbo_reception.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_reception.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_reception.FormattingEnabled = true;
            this.cbo_reception.Location = new System.Drawing.Point(48, 95);
            this.cbo_reception.Name = "cbo_reception";
            this.cbo_reception.Size = new System.Drawing.Size(195, 28);
            this.cbo_reception.TabIndex = 82;
            // 
            // txt_tutor_time
            // 
            this.txt_tutor_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_tutor_time.Location = new System.Drawing.Point(48, 414);
            this.txt_tutor_time.Name = "txt_tutor_time";
            this.txt_tutor_time.Size = new System.Drawing.Size(409, 27);
            this.txt_tutor_time.TabIndex = 79;
            // 
            // txt_tutor_price
            // 
            this.txt_tutor_price.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_tutor_price.Location = new System.Drawing.Point(262, 365);
            this.txt_tutor_price.Name = "txt_tutor_price";
            this.txt_tutor_price.Size = new System.Drawing.Size(195, 27);
            this.txt_tutor_price.TabIndex = 77;
            // 
            // txt_subject_stu
            // 
            this.txt_subject_stu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_subject_stu.Location = new System.Drawing.Point(262, 316);
            this.txt_subject_stu.Name = "txt_subject_stu";
            this.txt_subject_stu.Size = new System.Drawing.Size(195, 27);
            this.txt_subject_stu.TabIndex = 74;
            // 
            // txt_grade_stu
            // 
            this.txt_grade_stu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_grade_stu.Location = new System.Drawing.Point(48, 316);
            this.txt_grade_stu.Name = "txt_grade_stu";
            this.txt_grade_stu.Size = new System.Drawing.Size(195, 27);
            this.txt_grade_stu.TabIndex = 72;
            // 
            // txt_dadd
            // 
            this.txt_dadd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_dadd.Location = new System.Drawing.Point(48, 242);
            this.txt_dadd.Multiline = true;
            this.txt_dadd.Name = "txt_dadd";
            this.txt_dadd.Size = new System.Drawing.Size(409, 50);
            this.txt_dadd.TabIndex = 70;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_phone.Location = new System.Drawing.Point(262, 144);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(195, 27);
            this.txt_phone.TabIndex = 68;
            // 
            // txt_sadd
            // 
            this.txt_sadd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_sadd.Location = new System.Drawing.Point(48, 193);
            this.txt_sadd.Name = "txt_sadd";
            this.txt_sadd.Size = new System.Drawing.Size(409, 27);
            this.txt_sadd.TabIndex = 66;
            // 
            // txt_parent_name
            // 
            this.txt_parent_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_parent_name.Location = new System.Drawing.Point(48, 144);
            this.txt_parent_name.Name = "txt_parent_name";
            this.txt_parent_name.Size = new System.Drawing.Size(195, 27);
            this.txt_parent_name.TabIndex = 64;
            // 
            // txt_print_num
            // 
            this.txt_print_num.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_print_num.Location = new System.Drawing.Point(262, 46);
            this.txt_print_num.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txt_print_num.Name = "txt_print_num";
            this.txt_print_num.ReadOnly = true;
            this.txt_print_num.Size = new System.Drawing.Size(195, 27);
            this.txt_print_num.TabIndex = 60;
            // 
            // txt_parent_num
            // 
            this.txt_parent_num.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_parent_num.Location = new System.Drawing.Point(48, 46);
            this.txt_parent_num.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_parent_num.Name = "txt_parent_num";
            this.txt_parent_num.Size = new System.Drawing.Size(195, 27);
            this.txt_parent_num.TabIndex = 58;
            // 
            // lbl_tutor_time
            // 
            this.lbl_tutor_time.AutoSize = true;
            this.lbl_tutor_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tutor_time.ForeColor = System.Drawing.Color.White;
            this.lbl_tutor_time.Location = new System.Drawing.Point(45, 396);
            this.lbl_tutor_time.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_tutor_time.Name = "lbl_tutor_time";
            this.lbl_tutor_time.Size = new System.Drawing.Size(69, 19);
            this.lbl_tutor_time.TabIndex = 80;
            this.lbl_tutor_time.Text = "家教时间";
            // 
            // lbl_tutor_price
            // 
            this.lbl_tutor_price.AutoSize = true;
            this.lbl_tutor_price.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tutor_price.ForeColor = System.Drawing.Color.White;
            this.lbl_tutor_price.Location = new System.Drawing.Point(259, 347);
            this.lbl_tutor_price.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_tutor_price.Name = "lbl_tutor_price";
            this.lbl_tutor_price.Size = new System.Drawing.Size(69, 19);
            this.lbl_tutor_price.TabIndex = 78;
            this.lbl_tutor_price.Text = "家教价格";
            // 
            // lbl_student_sex
            // 
            this.lbl_student_sex.AutoSize = true;
            this.lbl_student_sex.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_student_sex.ForeColor = System.Drawing.Color.White;
            this.lbl_student_sex.Location = new System.Drawing.Point(45, 347);
            this.lbl_student_sex.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_student_sex.Name = "lbl_student_sex";
            this.lbl_student_sex.Size = new System.Drawing.Size(69, 19);
            this.lbl_student_sex.TabIndex = 76;
            this.lbl_student_sex.Text = "学员性别";
            // 
            // lbl_subject_stu
            // 
            this.lbl_subject_stu.AutoSize = true;
            this.lbl_subject_stu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_subject_stu.ForeColor = System.Drawing.Color.White;
            this.lbl_subject_stu.Location = new System.Drawing.Point(259, 298);
            this.lbl_subject_stu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_subject_stu.Name = "lbl_subject_stu";
            this.lbl_subject_stu.Size = new System.Drawing.Size(144, 19);
            this.lbl_subject_stu.TabIndex = 75;
            this.lbl_subject_stu.Text = "科目（以分号分隔）";
            // 
            // lbl_grade_stu
            // 
            this.lbl_grade_stu.AutoSize = true;
            this.lbl_grade_stu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_grade_stu.ForeColor = System.Drawing.Color.White;
            this.lbl_grade_stu.Location = new System.Drawing.Point(45, 298);
            this.lbl_grade_stu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_grade_stu.Name = "lbl_grade_stu";
            this.lbl_grade_stu.Size = new System.Drawing.Size(39, 19);
            this.lbl_grade_stu.TabIndex = 73;
            this.lbl_grade_stu.Text = "年级";
            // 
            // lbl_dadd
            // 
            this.lbl_dadd.AutoSize = true;
            this.lbl_dadd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_dadd.ForeColor = System.Drawing.Color.White;
            this.lbl_dadd.Location = new System.Drawing.Point(45, 224);
            this.lbl_dadd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_dadd.Name = "lbl_dadd";
            this.lbl_dadd.Size = new System.Drawing.Size(129, 19);
            this.lbl_dadd.TabIndex = 71;
            this.lbl_dadd.Text = "家庭地址（详细）";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_phone.ForeColor = System.Drawing.Color.White;
            this.lbl_phone.Location = new System.Drawing.Point(259, 126);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(69, 19);
            this.lbl_phone.TabIndex = 69;
            this.lbl_phone.Text = "联系方式";
            // 
            // lbl_sadd
            // 
            this.lbl_sadd.AutoSize = true;
            this.lbl_sadd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_sadd.ForeColor = System.Drawing.Color.White;
            this.lbl_sadd.Location = new System.Drawing.Point(45, 175);
            this.lbl_sadd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_sadd.Name = "lbl_sadd";
            this.lbl_sadd.Size = new System.Drawing.Size(129, 19);
            this.lbl_sadd.TabIndex = 67;
            this.lbl_sadd.Text = "家庭地址（简单）";
            // 
            // lbl_parent_name
            // 
            this.lbl_parent_name.AutoSize = true;
            this.lbl_parent_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_parent_name.ForeColor = System.Drawing.Color.White;
            this.lbl_parent_name.Location = new System.Drawing.Point(45, 126);
            this.lbl_parent_name.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_parent_name.Name = "lbl_parent_name";
            this.lbl_parent_name.Size = new System.Drawing.Size(69, 19);
            this.lbl_parent_name.TabIndex = 65;
            this.lbl_parent_name.Text = "家长称呼";
            // 
            // lbl_recepiton_time
            // 
            this.lbl_recepiton_time.AutoSize = true;
            this.lbl_recepiton_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_recepiton_time.ForeColor = System.Drawing.Color.White;
            this.lbl_recepiton_time.Location = new System.Drawing.Point(259, 77);
            this.lbl_recepiton_time.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_recepiton_time.Name = "lbl_recepiton_time";
            this.lbl_recepiton_time.Size = new System.Drawing.Size(69, 19);
            this.lbl_recepiton_time.TabIndex = 63;
            this.lbl_recepiton_time.Text = "接入时间";
            // 
            // lbl_reception
            // 
            this.lbl_reception.AutoSize = true;
            this.lbl_reception.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_reception.ForeColor = System.Drawing.Color.White;
            this.lbl_reception.Location = new System.Drawing.Point(45, 77);
            this.lbl_reception.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_reception.Name = "lbl_reception";
            this.lbl_reception.Size = new System.Drawing.Size(54, 19);
            this.lbl_reception.TabIndex = 62;
            this.lbl_reception.Text = "接待人";
            // 
            // lbl_print_num
            // 
            this.lbl_print_num.AutoSize = true;
            this.lbl_print_num.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_print_num.ForeColor = System.Drawing.Color.White;
            this.lbl_print_num.Location = new System.Drawing.Point(259, 28);
            this.lbl_print_num.Name = "lbl_print_num";
            this.lbl_print_num.Size = new System.Drawing.Size(69, 19);
            this.lbl_print_num.TabIndex = 61;
            this.lbl_print_num.Text = "打印编号";
            // 
            // lbl_parent_num
            // 
            this.lbl_parent_num.AutoSize = true;
            this.lbl_parent_num.BackColor = System.Drawing.Color.Transparent;
            this.lbl_parent_num.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_parent_num.ForeColor = System.Drawing.Color.White;
            this.lbl_parent_num.Location = new System.Drawing.Point(46, 28);
            this.lbl_parent_num.Name = "lbl_parent_num";
            this.lbl_parent_num.Size = new System.Drawing.Size(69, 19);
            this.lbl_parent_num.TabIndex = 59;
            this.lbl_parent_num.Text = "家长编号";
            // 
            // lbl_payment_time
            // 
            this.lbl_payment_time.AutoSize = true;
            this.lbl_payment_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_payment_time.ForeColor = System.Drawing.Color.White;
            this.lbl_payment_time.Location = new System.Drawing.Point(299, 656);
            this.lbl_payment_time.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_payment_time.Name = "lbl_payment_time";
            this.lbl_payment_time.Size = new System.Drawing.Size(69, 19);
            this.lbl_payment_time.TabIndex = 97;
            this.lbl_payment_time.Text = "缴费时间";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(252, 714);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 32);
            this.btn_save.TabIndex = 94;
            this.btn_save.Text = "保存信息";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_payment_state
            // 
            this.lbl_payment_state.AutoSize = true;
            this.lbl_payment_state.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_payment_state.ForeColor = System.Drawing.Color.White;
            this.lbl_payment_state.Location = new System.Drawing.Point(85, 656);
            this.lbl_payment_state.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_payment_state.Name = "lbl_payment_state";
            this.lbl_payment_state.Size = new System.Drawing.Size(69, 19);
            this.lbl_payment_state.TabIndex = 96;
            this.lbl_payment_state.Text = "缴费状态";
            // 
            // tutor_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(579, 749);
            this.Controls.Add(this.dt_payment_time);
            this.Controls.Add(this.cbo_payment_state);
            this.Controls.Add(this.gbo_request);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_payment_time);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_payment_state);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tutor_info";
            this.Text = "tutor_info";
            this.gbo_request.ResumeLayout(false);
            this.gbo_request.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_payment_time;
        private System.Windows.Forms.ComboBox cbo_payment_state;
        private System.Windows.Forms.GroupBox gbo_request;
        private System.Windows.Forms.TextBox txt_place;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.ComboBox cbo_sex;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.TextBox txt_other_requests;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_place;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_other_requests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_woman;
        private System.Windows.Forms.RadioButton rdo_man;
        private System.Windows.Forms.DateTimePicker dt_recepiton_time;
        private System.Windows.Forms.ComboBox cbo_reception;
        private System.Windows.Forms.TextBox txt_tutor_time;
        private System.Windows.Forms.TextBox txt_tutor_price;
        private System.Windows.Forms.TextBox txt_subject_stu;
        private System.Windows.Forms.TextBox txt_grade_stu;
        private System.Windows.Forms.TextBox txt_dadd;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_sadd;
        private System.Windows.Forms.TextBox txt_parent_name;
        private System.Windows.Forms.TextBox txt_print_num;
        private System.Windows.Forms.TextBox txt_parent_num;
        private System.Windows.Forms.Label lbl_tutor_time;
        private System.Windows.Forms.Label lbl_tutor_price;
        private System.Windows.Forms.Label lbl_student_sex;
        private System.Windows.Forms.Label lbl_subject_stu;
        private System.Windows.Forms.Label lbl_grade_stu;
        private System.Windows.Forms.Label lbl_dadd;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_sadd;
        private System.Windows.Forms.Label lbl_parent_name;
        private System.Windows.Forms.Label lbl_recepiton_time;
        private System.Windows.Forms.Label lbl_reception;
        private System.Windows.Forms.Label lbl_print_num;
        private System.Windows.Forms.Label lbl_parent_num;
        private System.Windows.Forms.Label lbl_payment_time;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_payment_state;
    }
}