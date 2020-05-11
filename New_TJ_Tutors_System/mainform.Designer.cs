namespace New_TJ_Tutors_System
{
    partial class mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panelemergency = new System.Windows.Forms.Panel();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_emergency = new System.Windows.Forms.Button();
            this.panelhelpmenu = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_doc = new System.Windows.Forms.Button();
            this.btn_price_check = new System.Windows.Forms.Button();
            this.btn_work_tutorial = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.panelworkermenu = new System.Windows.Forms.Panel();
            this.btn_worker_search = new System.Windows.Forms.Button();
            this.btn_worker = new System.Windows.Forms.Button();
            this.paneltutormenu = new System.Windows.Forms.Panel();
            this.btn_tutor_search = new System.Windows.Forms.Button();
            this.btn_tutor_info = new System.Windows.Forms.Button();
            this.paneltutoringmenu = new System.Windows.Forms.Panel();
            this.btn_tutoring_form = new System.Windows.Forms.Button();
            this.btn_tutoring_search = new System.Windows.Forms.Button();
            this.btn_tutoring_info = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.lbl_admin = new System.Windows.Forms.LinkLabel();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_user_num = new System.Windows.Forms.Label();
            this.paneltutoring = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panelmenu.SuspendLayout();
            this.panelemergency.SuspendLayout();
            this.panelhelpmenu.SuspendLayout();
            this.panelworkermenu.SuspendLayout();
            this.paneltutormenu.SuspendLayout();
            this.paneltutoringmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.paneltutoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.AutoScroll = true;
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(99)))), ((int)(((byte)(199)))));
            this.panelmenu.Controls.Add(this.panelemergency);
            this.panelmenu.Controls.Add(this.btn_emergency);
            this.panelmenu.Controls.Add(this.panelhelpmenu);
            this.panelmenu.Controls.Add(this.btn_help);
            this.panelmenu.Controls.Add(this.panelworkermenu);
            this.panelmenu.Controls.Add(this.btn_worker);
            this.panelmenu.Controls.Add(this.paneltutormenu);
            this.panelmenu.Controls.Add(this.btn_tutor_info);
            this.panelmenu.Controls.Add(this.paneltutoringmenu);
            this.panelmenu.Controls.Add(this.btn_tutoring_info);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 56);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 785);
            this.panelmenu.TabIndex = 0;
            // 
            // panelemergency
            // 
            this.panelemergency.Controls.Add(this.btn_backup);
            this.panelemergency.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelemergency.Location = new System.Drawing.Point(0, 689);
            this.panelemergency.Name = "panelemergency";
            this.panelemergency.Size = new System.Drawing.Size(220, 45);
            this.panelemergency.TabIndex = 10;
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_backup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_backup.FlatAppearance.BorderSize = 0;
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.Location = new System.Drawing.Point(0, 0);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_backup.Size = new System.Drawing.Size(220, 45);
            this.btn_backup.TabIndex = 0;
            this.btn_backup.Text = "数据备份/还原";
            this.btn_backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_emergency
            // 
            this.btn_emergency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_emergency.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_emergency.FlatAppearance.BorderSize = 0;
            this.btn_emergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emergency.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_emergency.ForeColor = System.Drawing.Color.White;
            this.btn_emergency.Location = new System.Drawing.Point(0, 644);
            this.btn_emergency.Name = "btn_emergency";
            this.btn_emergency.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_emergency.Size = new System.Drawing.Size(220, 45);
            this.btn_emergency.TabIndex = 9;
            this.btn_emergency.Text = "应急管理系统";
            this.btn_emergency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emergency.UseVisualStyleBackColor = false;
            this.btn_emergency.Click += new System.EventHandler(this.btn_emergency_Click);
            // 
            // panelhelpmenu
            // 
            this.panelhelpmenu.Controls.Add(this.btn_about);
            this.panelhelpmenu.Controls.Add(this.btn_doc);
            this.panelhelpmenu.Controls.Add(this.btn_price_check);
            this.panelhelpmenu.Controls.Add(this.btn_work_tutorial);
            this.panelhelpmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhelpmenu.Location = new System.Drawing.Point(0, 464);
            this.panelhelpmenu.Name = "panelhelpmenu";
            this.panelhelpmenu.Size = new System.Drawing.Size(220, 180);
            this.panelhelpmenu.TabIndex = 8;
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Location = new System.Drawing.Point(0, 135);
            this.btn_about.Name = "btn_about";
            this.btn_about.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_about.Size = new System.Drawing.Size(220, 45);
            this.btn_about.TabIndex = 4;
            this.btn_about.Text = "系统负责人信息";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.UseVisualStyleBackColor = false;
            // 
            // btn_doc
            // 
            this.btn_doc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_doc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_doc.FlatAppearance.BorderSize = 0;
            this.btn_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_doc.ForeColor = System.Drawing.Color.White;
            this.btn_doc.Location = new System.Drawing.Point(0, 90);
            this.btn_doc.Name = "btn_doc";
            this.btn_doc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_doc.Size = new System.Drawing.Size(220, 45);
            this.btn_doc.TabIndex = 2;
            this.btn_doc.Text = "系统使用说明";
            this.btn_doc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doc.UseVisualStyleBackColor = false;
            this.btn_doc.Click += new System.EventHandler(this.btn_doc_Click);
            // 
            // btn_price_check
            // 
            this.btn_price_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_price_check.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_price_check.FlatAppearance.BorderSize = 0;
            this.btn_price_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_price_check.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_price_check.ForeColor = System.Drawing.Color.White;
            this.btn_price_check.Location = new System.Drawing.Point(0, 45);
            this.btn_price_check.Name = "btn_price_check";
            this.btn_price_check.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_price_check.Size = new System.Drawing.Size(220, 45);
            this.btn_price_check.TabIndex = 1;
            this.btn_price_check.Text = "家教价格查看";
            this.btn_price_check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_price_check.UseVisualStyleBackColor = false;
            this.btn_price_check.Click += new System.EventHandler(this.btn_price_check_Click);
            // 
            // btn_work_tutorial
            // 
            this.btn_work_tutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_work_tutorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_work_tutorial.FlatAppearance.BorderSize = 0;
            this.btn_work_tutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_work_tutorial.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_work_tutorial.ForeColor = System.Drawing.Color.White;
            this.btn_work_tutorial.Location = new System.Drawing.Point(0, 0);
            this.btn_work_tutorial.Name = "btn_work_tutorial";
            this.btn_work_tutorial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_work_tutorial.Size = new System.Drawing.Size(220, 45);
            this.btn_work_tutorial.TabIndex = 0;
            this.btn_work_tutorial.Text = "家教部工作流程";
            this.btn_work_tutorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_work_tutorial.UseVisualStyleBackColor = false;
            this.btn_work_tutorial.Click += new System.EventHandler(this.btn_work_tutorial_Click);
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_help.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_help.ForeColor = System.Drawing.Color.White;
            this.btn_help.Location = new System.Drawing.Point(0, 419);
            this.btn_help.Name = "btn_help";
            this.btn_help.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_help.Size = new System.Drawing.Size(220, 45);
            this.btn_help.TabIndex = 7;
            this.btn_help.Text = "帮助";
            this.btn_help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // panelworkermenu
            // 
            this.panelworkermenu.Controls.Add(this.btn_worker_search);
            this.panelworkermenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelworkermenu.Location = new System.Drawing.Point(0, 374);
            this.panelworkermenu.Name = "panelworkermenu";
            this.panelworkermenu.Size = new System.Drawing.Size(220, 45);
            this.panelworkermenu.TabIndex = 6;
            // 
            // btn_worker_search
            // 
            this.btn_worker_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_worker_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_worker_search.FlatAppearance.BorderSize = 0;
            this.btn_worker_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_worker_search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_worker_search.ForeColor = System.Drawing.Color.White;
            this.btn_worker_search.Location = new System.Drawing.Point(0, 0);
            this.btn_worker_search.Name = "btn_worker_search";
            this.btn_worker_search.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_worker_search.Size = new System.Drawing.Size(220, 45);
            this.btn_worker_search.TabIndex = 0;
            this.btn_worker_search.Text = "查询职工信息";
            this.btn_worker_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_worker_search.UseVisualStyleBackColor = false;
            this.btn_worker_search.Click += new System.EventHandler(this.btn_worker_search_Click);
            // 
            // btn_worker
            // 
            this.btn_worker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_worker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_worker.FlatAppearance.BorderSize = 0;
            this.btn_worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_worker.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_worker.ForeColor = System.Drawing.Color.White;
            this.btn_worker.Location = new System.Drawing.Point(0, 327);
            this.btn_worker.Name = "btn_worker";
            this.btn_worker.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_worker.Size = new System.Drawing.Size(220, 47);
            this.btn_worker.TabIndex = 5;
            this.btn_worker.Text = "工作人员管理";
            this.btn_worker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_worker.UseVisualStyleBackColor = false;
            this.btn_worker.Click += new System.EventHandler(this.btn_worker_Click);
            // 
            // paneltutormenu
            // 
            this.paneltutormenu.Controls.Add(this.btn_tutor_search);
            this.paneltutormenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltutormenu.Location = new System.Drawing.Point(0, 282);
            this.paneltutormenu.Name = "paneltutormenu";
            this.paneltutormenu.Size = new System.Drawing.Size(220, 45);
            this.paneltutormenu.TabIndex = 4;
            // 
            // btn_tutor_search
            // 
            this.btn_tutor_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_tutor_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutor_search.FlatAppearance.BorderSize = 0;
            this.btn_tutor_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutor_search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tutor_search.ForeColor = System.Drawing.Color.White;
            this.btn_tutor_search.Location = new System.Drawing.Point(0, 0);
            this.btn_tutor_search.Name = "btn_tutor_search";
            this.btn_tutor_search.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutor_search.Size = new System.Drawing.Size(220, 45);
            this.btn_tutor_search.TabIndex = 0;
            this.btn_tutor_search.Text = "查询教员信息";
            this.btn_tutor_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutor_search.UseVisualStyleBackColor = false;
            this.btn_tutor_search.Click += new System.EventHandler(this.btn_tutor_search_Click);
            // 
            // btn_tutor_info
            // 
            this.btn_tutor_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_tutor_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutor_info.FlatAppearance.BorderSize = 0;
            this.btn_tutor_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutor_info.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tutor_info.ForeColor = System.Drawing.Color.White;
            this.btn_tutor_info.Location = new System.Drawing.Point(0, 237);
            this.btn_tutor_info.Name = "btn_tutor_info";
            this.btn_tutor_info.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tutor_info.Size = new System.Drawing.Size(220, 45);
            this.btn_tutor_info.TabIndex = 3;
            this.btn_tutor_info.Text = "教员信息管理";
            this.btn_tutor_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutor_info.UseVisualStyleBackColor = false;
            this.btn_tutor_info.Click += new System.EventHandler(this.btn_tutor_info_Click);
            // 
            // paneltutoringmenu
            // 
            this.paneltutoringmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.paneltutoringmenu.Controls.Add(this.btn_tutoring_form);
            this.paneltutoringmenu.Controls.Add(this.btn_tutoring_search);
            this.paneltutoringmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltutoringmenu.Location = new System.Drawing.Point(0, 147);
            this.paneltutoringmenu.Name = "paneltutoringmenu";
            this.paneltutoringmenu.Size = new System.Drawing.Size(220, 90);
            this.paneltutoringmenu.TabIndex = 2;
            // 
            // btn_tutoring_form
            // 
            this.btn_tutoring_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_tutoring_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutoring_form.FlatAppearance.BorderSize = 0;
            this.btn_tutoring_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutoring_form.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tutoring_form.ForeColor = System.Drawing.Color.White;
            this.btn_tutoring_form.Location = new System.Drawing.Point(0, 45);
            this.btn_tutoring_form.Name = "btn_tutoring_form";
            this.btn_tutoring_form.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutoring_form.Size = new System.Drawing.Size(220, 45);
            this.btn_tutoring_form.TabIndex = 3;
            this.btn_tutoring_form.Text = "当日表格";
            this.btn_tutoring_form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutoring_form.UseVisualStyleBackColor = false;
            this.btn_tutoring_form.Click += new System.EventHandler(this.btn_tutoring_form_Click);
            // 
            // btn_tutoring_search
            // 
            this.btn_tutoring_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_tutoring_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutoring_search.FlatAppearance.BorderSize = 0;
            this.btn_tutoring_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutoring_search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tutoring_search.ForeColor = System.Drawing.Color.White;
            this.btn_tutoring_search.Location = new System.Drawing.Point(0, 0);
            this.btn_tutoring_search.Name = "btn_tutoring_search";
            this.btn_tutoring_search.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutoring_search.Size = new System.Drawing.Size(220, 45);
            this.btn_tutoring_search.TabIndex = 0;
            this.btn_tutoring_search.Text = "查询家教信息";
            this.btn_tutoring_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutoring_search.UseVisualStyleBackColor = false;
            this.btn_tutoring_search.Click += new System.EventHandler(this.btn_tutoring_search_Click);
            // 
            // btn_tutoring_info
            // 
            this.btn_tutoring_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_tutoring_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutoring_info.FlatAppearance.BorderSize = 0;
            this.btn_tutoring_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutoring_info.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tutoring_info.ForeColor = System.Drawing.Color.White;
            this.btn_tutoring_info.Location = new System.Drawing.Point(0, 102);
            this.btn_tutoring_info.Name = "btn_tutoring_info";
            this.btn_tutoring_info.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tutoring_info.Size = new System.Drawing.Size(220, 45);
            this.btn_tutoring_info.TabIndex = 0;
            this.btn_tutoring_info.Text = "家教信息管理";
            this.btn_tutoring_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutoring_info.UseVisualStyleBackColor = false;
            this.btn_tutoring_info.Click += new System.EventHandler(this.btn_tutoring_info_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.lbl_admin);
            this.panellogo.Controls.Add(this.lbl_user_name);
            this.panellogo.Controls.Add(this.btn_logout);
            this.panellogo.Controls.Add(this.pictureBox2);
            this.panellogo.Controls.Add(this.lbl_user_num);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(220, 102);
            this.panellogo.TabIndex = 1;
            // 
            // lbl_admin
            // 
            this.lbl_admin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(99)))), ((int)(((byte)(199)))));
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbl_admin.LinkColor = System.Drawing.Color.White;
            this.lbl_admin.Location = new System.Drawing.Point(103, 29);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(88, 26);
            this.lbl_admin.TabIndex = 64;
            this.lbl_admin.TabStop = true;
            this.lbl_admin.Text = "用户管理";
            this.lbl_admin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(99)))), ((int)(((byte)(199)))));
            this.lbl_admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_admin_LinkClicked);
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user_name.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.White;
            this.lbl_user_name.Location = new System.Drawing.Point(103, 32);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(69, 26);
            this.lbl_user_name.TabIndex = 63;
            this.lbl_user_name.Text = "陈振华";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(99)))), ((int)(((byte)(199)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(0, 61);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(220, 41);
            this.btn_logout.TabIndex = 62;
            this.btn_logout.Text = "换班登出";
            this.btn_logout.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(31, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_user_num
            // 
            this.lbl_user_num.AutoSize = true;
            this.lbl_user_num.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user_num.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_user_num.ForeColor = System.Drawing.Color.White;
            this.lbl_user_num.Location = new System.Drawing.Point(103, 3);
            this.lbl_user_num.Name = "lbl_user_num";
            this.lbl_user_num.Size = new System.Drawing.Size(84, 26);
            this.lbl_user_num.TabIndex = 60;
            this.lbl_user_num.Text = "190031";
            // 
            // paneltutoring
            // 
            this.paneltutoring.BackColor = System.Drawing.Color.White;
            this.paneltutoring.Controls.Add(this.pictureBox1);
            this.paneltutoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltutoring.Location = new System.Drawing.Point(220, 56);
            this.paneltutoring.Name = "paneltutoring";
            this.paneltutoring.Size = new System.Drawing.Size(1170, 785);
            this.paneltutoring.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::New_TJ_Tutors_System.Properties.Resources.QQ图片20190223220706;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1170, 785);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.paneltitle.Controls.Add(this.btn_min);
            this.paneltitle.Controls.Add(this.btn_max);
            this.paneltitle.Controls.Add(this.button_close);
            this.paneltitle.Controls.Add(this.labeltitle);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(1390, 56);
            this.paneltitle.TabIndex = 2;
            this.paneltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.paneltitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.paneltitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_min
            // 
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(1186, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(68, 56);
            this.btn_min.TabIndex = 3;
            this.btn_min.Text = "—";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_max.ForeColor = System.Drawing.Color.White;
            this.btn_max.Location = new System.Drawing.Point(1254, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(68, 56);
            this.btn_max.TabIndex = 2;
            this.btn_max.Text = "口";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_close
            // 
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(1322, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(68, 56);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(12, 9);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(369, 37);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "同 济 大 学 家 教 管 理 系 统";
            this.labeltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labeltitle_MouseDown);
            this.labeltitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labeltitle_MouseMove);
            this.labeltitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labeltitle_MouseUp);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1390, 841);
            this.Controls.Add(this.paneltutoring);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.paneltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.panelmenu.ResumeLayout(false);
            this.panelemergency.ResumeLayout(false);
            this.panelhelpmenu.ResumeLayout(false);
            this.panelworkermenu.ResumeLayout(false);
            this.paneltutormenu.ResumeLayout(false);
            this.paneltutoringmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.paneltutoring.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel paneltutoringmenu;
        private System.Windows.Forms.Button btn_tutoring_form;
        private System.Windows.Forms.Button btn_tutoring_search;
        private System.Windows.Forms.Button btn_tutoring_info;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel paneltutormenu;
        private System.Windows.Forms.Button btn_tutor_search;
        private System.Windows.Forms.Button btn_tutor_info;
        private System.Windows.Forms.Panel paneltutoring;
        private System.Windows.Forms.Panel panelhelpmenu;
        private System.Windows.Forms.Button btn_doc;
        private System.Windows.Forms.Button btn_price_check;
        private System.Windows.Forms.Button btn_work_tutorial;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Panel panelworkermenu;
        private System.Windows.Forms.Button btn_worker_search;
        private System.Windows.Forms.Button btn_worker;
        private System.Windows.Forms.Panel panelemergency;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_emergency;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_user_num;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.LinkLabel lbl_admin;
    }
}

