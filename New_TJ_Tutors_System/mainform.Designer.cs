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
            this.btn_worker_responsibility = new System.Windows.Forms.Button();
            this.btn_worker_add = new System.Windows.Forms.Button();
            this.btn_worker_search = new System.Windows.Forms.Button();
            this.btn_worker = new System.Windows.Forms.Button();
            this.paneltutormenu = new System.Windows.Forms.Panel();
            this.btn_tutor_blacklist = new System.Windows.Forms.Button();
            this.btn_tutor_add = new System.Windows.Forms.Button();
            this.btn_tutor_search = new System.Windows.Forms.Button();
            this.btn_tutor_info = new System.Windows.Forms.Button();
            this.paneltutoringmenu = new System.Windows.Forms.Panel();
            this.btn_tutoring_form = new System.Windows.Forms.Button();
            this.btn_tutoring_track = new System.Windows.Forms.Button();
            this.btn_tutoring_add = new System.Windows.Forms.Button();
            this.btn_tutoring_search = new System.Windows.Forms.Button();
            this.btn_tutoring_info = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.paneltutoring = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelmenu.SuspendLayout();
            this.panelemergency.SuspendLayout();
            this.panelhelpmenu.SuspendLayout();
            this.panelworkermenu.SuspendLayout();
            this.paneltutormenu.SuspendLayout();
            this.paneltutoringmenu.SuspendLayout();
            this.paneltutoring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.AutoScroll = true;
            this.panelmenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(193, 741);
            this.panelmenu.TabIndex = 0;
            // 
            // panelemergency
            // 
            this.panelemergency.Controls.Add(this.btn_backup);
            this.panelemergency.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelemergency.Location = new System.Drawing.Point(0, 999);
            this.panelemergency.Name = "panelemergency";
            this.panelemergency.Size = new System.Drawing.Size(172, 56);
            this.panelemergency.TabIndex = 10;
            // 
            // btn_backup
            // 
            this.btn_backup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_backup.FlatAppearance.BorderSize = 0;
            this.btn_backup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_backup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.ForeColor = System.Drawing.Color.Gray;
            this.btn_backup.Location = new System.Drawing.Point(0, 0);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_backup.Size = new System.Drawing.Size(172, 45);
            this.btn_backup.TabIndex = 0;
            this.btn_backup.Text = "数据备份/还原";
            this.btn_backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_emergency
            // 
            this.btn_emergency.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_emergency.FlatAppearance.BorderSize = 0;
            this.btn_emergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emergency.ForeColor = System.Drawing.Color.Black;
            this.btn_emergency.Location = new System.Drawing.Point(0, 954);
            this.btn_emergency.Name = "btn_emergency";
            this.btn_emergency.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_emergency.Size = new System.Drawing.Size(172, 45);
            this.btn_emergency.TabIndex = 9;
            this.btn_emergency.Text = "应急管理系统";
            this.btn_emergency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_emergency.UseVisualStyleBackColor = true;
            this.btn_emergency.Click += new System.EventHandler(this.btn_emergency_Click);
            // 
            // panelhelpmenu
            // 
            this.panelhelpmenu.Controls.Add(this.btn_about);
            this.panelhelpmenu.Controls.Add(this.btn_doc);
            this.panelhelpmenu.Controls.Add(this.btn_price_check);
            this.panelhelpmenu.Controls.Add(this.btn_work_tutorial);
            this.panelhelpmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhelpmenu.Location = new System.Drawing.Point(0, 764);
            this.panelhelpmenu.Name = "panelhelpmenu";
            this.panelhelpmenu.Size = new System.Drawing.Size(172, 190);
            this.panelhelpmenu.TabIndex = 8;
            // 
            // btn_about
            // 
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.ForeColor = System.Drawing.Color.Gray;
            this.btn_about.Location = new System.Drawing.Point(0, 135);
            this.btn_about.Name = "btn_about";
            this.btn_about.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_about.Size = new System.Drawing.Size(172, 45);
            this.btn_about.TabIndex = 4;
            this.btn_about.Text = "系统负责人信息";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.UseVisualStyleBackColor = true;
            // 
            // btn_doc
            // 
            this.btn_doc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_doc.FlatAppearance.BorderSize = 0;
            this.btn_doc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_doc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doc.ForeColor = System.Drawing.Color.Gray;
            this.btn_doc.Location = new System.Drawing.Point(0, 90);
            this.btn_doc.Name = "btn_doc";
            this.btn_doc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_doc.Size = new System.Drawing.Size(172, 45);
            this.btn_doc.TabIndex = 2;
            this.btn_doc.Text = "系统使用说明";
            this.btn_doc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doc.UseVisualStyleBackColor = true;
            this.btn_doc.Click += new System.EventHandler(this.btn_doc_Click);
            // 
            // btn_price_check
            // 
            this.btn_price_check.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_price_check.FlatAppearance.BorderSize = 0;
            this.btn_price_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_price_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_price_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_price_check.ForeColor = System.Drawing.Color.Gray;
            this.btn_price_check.Location = new System.Drawing.Point(0, 45);
            this.btn_price_check.Name = "btn_price_check";
            this.btn_price_check.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_price_check.Size = new System.Drawing.Size(172, 45);
            this.btn_price_check.TabIndex = 1;
            this.btn_price_check.Text = "家教价格查看";
            this.btn_price_check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_price_check.UseVisualStyleBackColor = true;
            this.btn_price_check.Click += new System.EventHandler(this.btn_price_check_Click);
            // 
            // btn_work_tutorial
            // 
            this.btn_work_tutorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_work_tutorial.FlatAppearance.BorderSize = 0;
            this.btn_work_tutorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_work_tutorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_work_tutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_work_tutorial.ForeColor = System.Drawing.Color.Gray;
            this.btn_work_tutorial.Location = new System.Drawing.Point(0, 0);
            this.btn_work_tutorial.Name = "btn_work_tutorial";
            this.btn_work_tutorial.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_work_tutorial.Size = new System.Drawing.Size(172, 45);
            this.btn_work_tutorial.TabIndex = 0;
            this.btn_work_tutorial.Text = "家教部工作流程";
            this.btn_work_tutorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_work_tutorial.UseVisualStyleBackColor = true;
            this.btn_work_tutorial.Click += new System.EventHandler(this.btn_work_tutorial_Click);
            // 
            // btn_help
            // 
            this.btn_help.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.ForeColor = System.Drawing.Color.Black;
            this.btn_help.Location = new System.Drawing.Point(0, 719);
            this.btn_help.Name = "btn_help";
            this.btn_help.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_help.Size = new System.Drawing.Size(172, 45);
            this.btn_help.TabIndex = 7;
            this.btn_help.Text = "帮助";
            this.btn_help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // panelworkermenu
            // 
            this.panelworkermenu.Controls.Add(this.btn_worker_responsibility);
            this.panelworkermenu.Controls.Add(this.btn_worker_add);
            this.panelworkermenu.Controls.Add(this.btn_worker_search);
            this.panelworkermenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelworkermenu.Location = new System.Drawing.Point(0, 572);
            this.panelworkermenu.Name = "panelworkermenu";
            this.panelworkermenu.Size = new System.Drawing.Size(172, 147);
            this.panelworkermenu.TabIndex = 6;
            // 
            // btn_worker_responsibility
            // 
            this.btn_worker_responsibility.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_worker_responsibility.FlatAppearance.BorderSize = 0;
            this.btn_worker_responsibility.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_worker_responsibility.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_worker_responsibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_worker_responsibility.ForeColor = System.Drawing.Color.Gray;
            this.btn_worker_responsibility.Location = new System.Drawing.Point(0, 90);
            this.btn_worker_responsibility.Name = "btn_worker_responsibility";
            this.btn_worker_responsibility.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_worker_responsibility.Size = new System.Drawing.Size(172, 45);
            this.btn_worker_responsibility.TabIndex = 2;
            this.btn_worker_responsibility.Text = "责任认定表";
            this.btn_worker_responsibility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_worker_responsibility.UseVisualStyleBackColor = true;
            this.btn_worker_responsibility.Click += new System.EventHandler(this.btn_worker_responsibility_Click);
            // 
            // btn_worker_add
            // 
            this.btn_worker_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_worker_add.FlatAppearance.BorderSize = 0;
            this.btn_worker_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_worker_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_worker_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_worker_add.ForeColor = System.Drawing.Color.Gray;
            this.btn_worker_add.Location = new System.Drawing.Point(0, 45);
            this.btn_worker_add.Name = "btn_worker_add";
            this.btn_worker_add.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_worker_add.Size = new System.Drawing.Size(172, 45);
            this.btn_worker_add.TabIndex = 1;
            this.btn_worker_add.Text = "新增工作人员信息";
            this.btn_worker_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_worker_add.UseVisualStyleBackColor = true;
            this.btn_worker_add.Click += new System.EventHandler(this.btn_worker_add_Click);
            // 
            // btn_worker_search
            // 
            this.btn_worker_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_worker_search.FlatAppearance.BorderSize = 0;
            this.btn_worker_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_worker_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_worker_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_worker_search.ForeColor = System.Drawing.Color.Gray;
            this.btn_worker_search.Location = new System.Drawing.Point(0, 0);
            this.btn_worker_search.Name = "btn_worker_search";
            this.btn_worker_search.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_worker_search.Size = new System.Drawing.Size(172, 45);
            this.btn_worker_search.TabIndex = 0;
            this.btn_worker_search.Text = "查询工作人员信息";
            this.btn_worker_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_worker_search.UseVisualStyleBackColor = true;
            this.btn_worker_search.Click += new System.EventHandler(this.btn_worker_search_Click);
            // 
            // btn_worker
            // 
            this.btn_worker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_worker.FlatAppearance.BorderSize = 0;
            this.btn_worker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_worker.ForeColor = System.Drawing.Color.Black;
            this.btn_worker.Location = new System.Drawing.Point(0, 527);
            this.btn_worker.Name = "btn_worker";
            this.btn_worker.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_worker.Size = new System.Drawing.Size(172, 45);
            this.btn_worker.TabIndex = 5;
            this.btn_worker.Text = "工作人员管理";
            this.btn_worker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_worker.UseVisualStyleBackColor = true;
            this.btn_worker.Click += new System.EventHandler(this.btn_worker_Click);
            // 
            // paneltutormenu
            // 
            this.paneltutormenu.Controls.Add(this.btn_tutor_blacklist);
            this.paneltutormenu.Controls.Add(this.btn_tutor_add);
            this.paneltutormenu.Controls.Add(this.btn_tutor_search);
            this.paneltutormenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltutormenu.Location = new System.Drawing.Point(0, 380);
            this.paneltutormenu.Name = "paneltutormenu";
            this.paneltutormenu.Size = new System.Drawing.Size(172, 147);
            this.paneltutormenu.TabIndex = 4;
            // 
            // btn_tutor_blacklist
            // 
            this.btn_tutor_blacklist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutor_blacklist.FlatAppearance.BorderSize = 0;
            this.btn_tutor_blacklist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_tutor_blacklist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_tutor_blacklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutor_blacklist.ForeColor = System.Drawing.Color.Gray;
            this.btn_tutor_blacklist.Location = new System.Drawing.Point(0, 90);
            this.btn_tutor_blacklist.Name = "btn_tutor_blacklist";
            this.btn_tutor_blacklist.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutor_blacklist.Size = new System.Drawing.Size(172, 45);
            this.btn_tutor_blacklist.TabIndex = 2;
            this.btn_tutor_blacklist.Text = "教员黑名单";
            this.btn_tutor_blacklist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutor_blacklist.UseVisualStyleBackColor = true;
            this.btn_tutor_blacklist.Click += new System.EventHandler(this.btn_tutor_blacklist_Click);
            // 
            // btn_tutor_add
            // 
            this.btn_tutor_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutor_add.FlatAppearance.BorderSize = 0;
            this.btn_tutor_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_tutor_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_tutor_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutor_add.ForeColor = System.Drawing.Color.Gray;
            this.btn_tutor_add.Location = new System.Drawing.Point(0, 45);
            this.btn_tutor_add.Name = "btn_tutor_add";
            this.btn_tutor_add.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutor_add.Size = new System.Drawing.Size(172, 45);
            this.btn_tutor_add.TabIndex = 1;
            this.btn_tutor_add.Text = "新增教员信息";
            this.btn_tutor_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutor_add.UseVisualStyleBackColor = true;
            this.btn_tutor_add.Click += new System.EventHandler(this.btn_tutor_add_Click);
            // 
            // btn_tutor_search
            // 
            this.btn_tutor_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutor_search.FlatAppearance.BorderSize = 0;
            this.btn_tutor_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_tutor_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_tutor_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutor_search.ForeColor = System.Drawing.Color.Gray;
            this.btn_tutor_search.Location = new System.Drawing.Point(0, 0);
            this.btn_tutor_search.Name = "btn_tutor_search";
            this.btn_tutor_search.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutor_search.Size = new System.Drawing.Size(172, 45);
            this.btn_tutor_search.TabIndex = 0;
            this.btn_tutor_search.Text = "查询教员信息";
            this.btn_tutor_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutor_search.UseVisualStyleBackColor = true;
            this.btn_tutor_search.Click += new System.EventHandler(this.btn_tutor_search_Click);
            // 
            // btn_tutor_info
            // 
            this.btn_tutor_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutor_info.FlatAppearance.BorderSize = 0;
            this.btn_tutor_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutor_info.ForeColor = System.Drawing.Color.Black;
            this.btn_tutor_info.Location = new System.Drawing.Point(0, 335);
            this.btn_tutor_info.Name = "btn_tutor_info";
            this.btn_tutor_info.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tutor_info.Size = new System.Drawing.Size(172, 45);
            this.btn_tutor_info.TabIndex = 3;
            this.btn_tutor_info.Text = "教员信息管理";
            this.btn_tutor_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutor_info.UseVisualStyleBackColor = true;
            this.btn_tutor_info.Click += new System.EventHandler(this.btn_tutor_info_Click);
            // 
            // paneltutoringmenu
            // 
            this.paneltutoringmenu.Controls.Add(this.btn_tutoring_form);
            this.paneltutoringmenu.Controls.Add(this.btn_tutoring_track);
            this.paneltutoringmenu.Controls.Add(this.btn_tutoring_add);
            this.paneltutoringmenu.Controls.Add(this.btn_tutoring_search);
            this.paneltutoringmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltutoringmenu.Location = new System.Drawing.Point(0, 145);
            this.paneltutoringmenu.Name = "paneltutoringmenu";
            this.paneltutoringmenu.Size = new System.Drawing.Size(172, 190);
            this.paneltutoringmenu.TabIndex = 2;
            // 
            // btn_tutoring_form
            // 
            this.btn_tutoring_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutoring_form.FlatAppearance.BorderSize = 0;
            this.btn_tutoring_form.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_tutoring_form.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_tutoring_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutoring_form.ForeColor = System.Drawing.Color.Gray;
            this.btn_tutoring_form.Location = new System.Drawing.Point(0, 135);
            this.btn_tutoring_form.Name = "btn_tutoring_form";
            this.btn_tutoring_form.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutoring_form.Size = new System.Drawing.Size(172, 45);
            this.btn_tutoring_form.TabIndex = 3;
            this.btn_tutoring_form.Text = "当日表格";
            this.btn_tutoring_form.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutoring_form.UseVisualStyleBackColor = true;
            this.btn_tutoring_form.Click += new System.EventHandler(this.btn_tutoring_form_Click);
            // 
            // btn_tutoring_track
            // 
            this.btn_tutoring_track.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutoring_track.FlatAppearance.BorderSize = 0;
            this.btn_tutoring_track.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_tutoring_track.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_tutoring_track.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutoring_track.ForeColor = System.Drawing.Color.Gray;
            this.btn_tutoring_track.Location = new System.Drawing.Point(0, 90);
            this.btn_tutoring_track.Name = "btn_tutoring_track";
            this.btn_tutoring_track.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutoring_track.Size = new System.Drawing.Size(172, 45);
            this.btn_tutoring_track.TabIndex = 2;
            this.btn_tutoring_track.Text = "家教信息跟踪";
            this.btn_tutoring_track.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutoring_track.UseVisualStyleBackColor = true;
            this.btn_tutoring_track.Click += new System.EventHandler(this.btn_tutoring_track_Click);
            // 
            // btn_tutoring_add
            // 
            this.btn_tutoring_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutoring_add.FlatAppearance.BorderSize = 0;
            this.btn_tutoring_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_tutoring_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_tutoring_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutoring_add.ForeColor = System.Drawing.Color.Gray;
            this.btn_tutoring_add.Location = new System.Drawing.Point(0, 45);
            this.btn_tutoring_add.Name = "btn_tutoring_add";
            this.btn_tutoring_add.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutoring_add.Size = new System.Drawing.Size(172, 45);
            this.btn_tutoring_add.TabIndex = 1;
            this.btn_tutoring_add.Text = "新增家教信息";
            this.btn_tutoring_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutoring_add.UseVisualStyleBackColor = true;
            this.btn_tutoring_add.Click += new System.EventHandler(this.btn_tutoring_add_Click);
            // 
            // btn_tutoring_search
            // 
            this.btn_tutoring_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutoring_search.FlatAppearance.BorderSize = 0;
            this.btn_tutoring_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_tutoring_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_tutoring_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutoring_search.ForeColor = System.Drawing.Color.Gray;
            this.btn_tutoring_search.Location = new System.Drawing.Point(0, 0);
            this.btn_tutoring_search.Name = "btn_tutoring_search";
            this.btn_tutoring_search.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_tutoring_search.Size = new System.Drawing.Size(172, 45);
            this.btn_tutoring_search.TabIndex = 0;
            this.btn_tutoring_search.Text = "查询家教信息";
            this.btn_tutoring_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutoring_search.UseVisualStyleBackColor = true;
            this.btn_tutoring_search.Click += new System.EventHandler(this.btn_tutoring_search_Click);
            // 
            // btn_tutoring_info
            // 
            this.btn_tutoring_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tutoring_info.FlatAppearance.BorderSize = 0;
            this.btn_tutoring_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutoring_info.ForeColor = System.Drawing.Color.Black;
            this.btn_tutoring_info.Location = new System.Drawing.Point(0, 100);
            this.btn_tutoring_info.Name = "btn_tutoring_info";
            this.btn_tutoring_info.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tutoring_info.Size = new System.Drawing.Size(172, 45);
            this.btn_tutoring_info.TabIndex = 0;
            this.btn_tutoring_info.Text = "家教信息管理";
            this.btn_tutoring_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tutoring_info.UseVisualStyleBackColor = true;
            this.btn_tutoring_info.Click += new System.EventHandler(this.btn_tutoring_info_Click);
            // 
            // panellogo
            // 
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(172, 100);
            this.panellogo.TabIndex = 1;
            // 
            // paneltutoring
            // 
            this.paneltutoring.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.paneltutoring.Controls.Add(this.pictureBox1);
            this.paneltutoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltutoring.Location = new System.Drawing.Point(193, 0);
            this.paneltutoring.Name = "paneltutoring";
            this.paneltutoring.Size = new System.Drawing.Size(1080, 741);
            this.paneltutoring.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::New_TJ_Tutors_System.Properties.Resources.QQ图片20190223220706;
            this.pictureBox1.Location = new System.Drawing.Point(180, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 736);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 741);
            this.Controls.Add(this.paneltutoring);
            this.Controls.Add(this.panelmenu);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "mainform";
            this.Text = "Form1";
            this.panelmenu.ResumeLayout(false);
            this.panelemergency.ResumeLayout(false);
            this.panelhelpmenu.ResumeLayout(false);
            this.panelworkermenu.ResumeLayout(false);
            this.paneltutormenu.ResumeLayout(false);
            this.paneltutoringmenu.ResumeLayout(false);
            this.paneltutoring.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel paneltutoringmenu;
        private System.Windows.Forms.Button btn_tutoring_form;
        private System.Windows.Forms.Button btn_tutoring_track;
        private System.Windows.Forms.Button btn_tutoring_add;
        private System.Windows.Forms.Button btn_tutoring_search;
        private System.Windows.Forms.Button btn_tutoring_info;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Panel paneltutormenu;
        private System.Windows.Forms.Button btn_tutor_blacklist;
        private System.Windows.Forms.Button btn_tutor_add;
        private System.Windows.Forms.Button btn_tutor_search;
        private System.Windows.Forms.Button btn_tutor_info;
        private System.Windows.Forms.Panel paneltutoring;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelhelpmenu;
        private System.Windows.Forms.Button btn_doc;
        private System.Windows.Forms.Button btn_price_check;
        private System.Windows.Forms.Button btn_work_tutorial;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Panel panelworkermenu;
        private System.Windows.Forms.Button btn_worker_responsibility;
        private System.Windows.Forms.Button btn_worker_add;
        private System.Windows.Forms.Button btn_worker_search;
        private System.Windows.Forms.Button btn_worker;
        private System.Windows.Forms.Panel panelemergency;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_emergency;
        private System.Windows.Forms.Button btn_about;
    }
}

