namespace New_TJ_Tutors_System
{
    partial class database
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btn_database = new System.Windows.Forms.Button();
            this.btn_forms = new System.Windows.Forms.Button();
            this.paneldatabase = new System.Windows.Forms.Panel();
            this.btn_rpath = new System.Windows.Forms.Button();
            this.panelrpath = new System.Windows.Forms.Panel();
            this.txt_rpath = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_bpath = new System.Windows.Forms.Button();
            this.panelbpath = new System.Windows.Forms.Panel();
            this.txt_bpath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_backup = new System.Windows.Forms.Button();
            this.panellabels = new System.Windows.Forms.Panel();
            this.lbl_restore = new System.Windows.Forms.Label();
            this.lbl_backup = new System.Windows.Forms.Label();
            this.paneltoexcel = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.cbo_export = new System.Windows.Forms.ComboBox();
            this.panelselect = new System.Windows.Forms.Panel();
            this.lbl_select = new System.Windows.Forms.Label();
            this.paneltop.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.paneldatabase.SuspendLayout();
            this.panelrpath.SuspendLayout();
            this.panelbpath.SuspendLayout();
            this.panellabels.SuspendLayout();
            this.paneltoexcel.SuspendLayout();
            this.panelselect.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.paneltop.Controls.Add(this.labeltitle);
            this.paneltop.Controls.Add(this.button_close);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(714, 52);
            this.paneltop.TabIndex = 3;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold);
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(9, 7);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(189, 37);
            this.labeltitle.TabIndex = 3;
            this.labeltitle.Text = "数 据 库 备 份";
            // 
            // button_close
            // 
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(665, 0);
            this.button_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(49, 52);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(99)))), ((int)(((byte)(199)))));
            this.panelmenu.Controls.Add(this.btn_database);
            this.panelmenu.Controls.Add(this.btn_forms);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 52);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(159, 297);
            this.panelmenu.TabIndex = 14;
            // 
            // btn_database
            // 
            this.btn_database.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_database.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_database.FlatAppearance.BorderSize = 0;
            this.btn_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_database.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_database.ForeColor = System.Drawing.Color.White;
            this.btn_database.Location = new System.Drawing.Point(0, 45);
            this.btn_database.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(159, 45);
            this.btn_database.TabIndex = 4;
            this.btn_database.Text = "备份与还原";
            this.btn_database.UseVisualStyleBackColor = false;
            this.btn_database.Click += new System.EventHandler(this.btn_database_Click);
            // 
            // btn_forms
            // 
            this.btn_forms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.btn_forms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_forms.FlatAppearance.BorderSize = 0;
            this.btn_forms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forms.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_forms.ForeColor = System.Drawing.Color.White;
            this.btn_forms.Location = new System.Drawing.Point(0, 0);
            this.btn_forms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_forms.Name = "btn_forms";
            this.btn_forms.Size = new System.Drawing.Size(159, 45);
            this.btn_forms.TabIndex = 5;
            this.btn_forms.Text = "导出到Excel";
            this.btn_forms.UseVisualStyleBackColor = false;
            this.btn_forms.Click += new System.EventHandler(this.btn_forms_Click);
            // 
            // paneldatabase
            // 
            this.paneldatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.paneldatabase.Controls.Add(this.btn_rpath);
            this.paneldatabase.Controls.Add(this.panelrpath);
            this.paneldatabase.Controls.Add(this.btn_restore);
            this.paneldatabase.Controls.Add(this.btn_bpath);
            this.paneldatabase.Controls.Add(this.panelbpath);
            this.paneldatabase.Controls.Add(this.btn_backup);
            this.paneldatabase.Controls.Add(this.panellabels);
            this.paneldatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldatabase.Location = new System.Drawing.Point(159, 52);
            this.paneldatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneldatabase.Name = "paneldatabase";
            this.paneldatabase.Size = new System.Drawing.Size(555, 297);
            this.paneldatabase.TabIndex = 15;
            // 
            // btn_rpath
            // 
            this.btn_rpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_rpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rpath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_rpath.ForeColor = System.Drawing.Color.White;
            this.btn_rpath.Location = new System.Drawing.Point(511, 131);
            this.btn_rpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rpath.Name = "btn_rpath";
            this.btn_rpath.Size = new System.Drawing.Size(32, 27);
            this.btn_rpath.TabIndex = 105;
            this.btn_rpath.Text = "...";
            this.btn_rpath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rpath.UseVisualStyleBackColor = false;
            this.btn_rpath.Click += new System.EventHandler(this.btn_rpath_Click);
            // 
            // panelrpath
            // 
            this.panelrpath.BackColor = System.Drawing.Color.Blue;
            this.panelrpath.Controls.Add(this.txt_rpath);
            this.panelrpath.Controls.Add(this.panel5);
            this.panelrpath.Location = new System.Drawing.Point(143, 130);
            this.panelrpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelrpath.Name = "panelrpath";
            this.panelrpath.Size = new System.Drawing.Size(347, 25);
            this.panelrpath.TabIndex = 104;
            // 
            // txt_rpath
            // 
            this.txt_rpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.txt_rpath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rpath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_rpath.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_rpath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.txt_rpath.Location = new System.Drawing.Point(0, 0);
            this.txt_rpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_rpath.Name = "txt_rpath";
            this.txt_rpath.Size = new System.Drawing.Size(347, 24);
            this.txt_rpath.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 24);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(347, 1);
            this.panel5.TabIndex = 1;
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_restore.ForeColor = System.Drawing.Color.White;
            this.btn_restore.Location = new System.Drawing.Point(288, 183);
            this.btn_restore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(94, 32);
            this.btn_restore.TabIndex = 103;
            this.btn_restore.Text = "还原";
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_bpath
            // 
            this.btn_bpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_bpath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bpath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_bpath.ForeColor = System.Drawing.Color.White;
            this.btn_bpath.Location = new System.Drawing.Point(511, 22);
            this.btn_bpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_bpath.Name = "btn_bpath";
            this.btn_bpath.Size = new System.Drawing.Size(32, 27);
            this.btn_bpath.TabIndex = 102;
            this.btn_bpath.Text = "...";
            this.btn_bpath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_bpath.UseVisualStyleBackColor = false;
            this.btn_bpath.Click += new System.EventHandler(this.btn_bpath_Click);
            // 
            // panelbpath
            // 
            this.panelbpath.BackColor = System.Drawing.Color.Blue;
            this.panelbpath.Controls.Add(this.txt_bpath);
            this.panelbpath.Controls.Add(this.panel1);
            this.panelbpath.Location = new System.Drawing.Point(143, 20);
            this.panelbpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelbpath.Name = "panelbpath";
            this.panelbpath.Size = new System.Drawing.Size(347, 25);
            this.panelbpath.TabIndex = 101;
            // 
            // txt_bpath
            // 
            this.txt_bpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.txt_bpath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_bpath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_bpath.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.txt_bpath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.txt_bpath.Location = new System.Drawing.Point(0, 0);
            this.txt_bpath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_bpath.Name = "txt_bpath";
            this.txt_bpath.Size = new System.Drawing.Size(347, 24);
            this.txt_bpath.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 1);
            this.panel1.TabIndex = 1;
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.Location = new System.Drawing.Point(288, 72);
            this.btn_backup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(94, 32);
            this.btn_backup.TabIndex = 100;
            this.btn_backup.Text = "备份";
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // panellabels
            // 
            this.panellabels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panellabels.Controls.Add(this.lbl_restore);
            this.panellabels.Controls.Add(this.lbl_backup);
            this.panellabels.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellabels.Location = new System.Drawing.Point(0, 0);
            this.panellabels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panellabels.Name = "panellabels";
            this.panellabels.Size = new System.Drawing.Size(120, 297);
            this.panellabels.TabIndex = 0;
            // 
            // lbl_restore
            // 
            this.lbl_restore.AutoSize = true;
            this.lbl_restore.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_restore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.lbl_restore.Location = new System.Drawing.Point(6, 130);
            this.lbl_restore.Name = "lbl_restore";
            this.lbl_restore.Size = new System.Drawing.Size(107, 26);
            this.lbl_restore.TabIndex = 1;
            this.lbl_restore.Text = "从本地还原";
            // 
            // lbl_backup
            // 
            this.lbl_backup.AutoSize = true;
            this.lbl_backup.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_backup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.lbl_backup.Location = new System.Drawing.Point(6, 20);
            this.lbl_backup.Name = "lbl_backup";
            this.lbl_backup.Size = new System.Drawing.Size(107, 26);
            this.lbl_backup.TabIndex = 0;
            this.lbl_backup.Text = "备份到本地";
            // 
            // paneltoexcel
            // 
            this.paneltoexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.paneltoexcel.Controls.Add(this.btn_export);
            this.paneltoexcel.Controls.Add(this.cbo_export);
            this.paneltoexcel.Controls.Add(this.panelselect);
            this.paneltoexcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltoexcel.Location = new System.Drawing.Point(159, 52);
            this.paneltoexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paneltoexcel.Name = "paneltoexcel";
            this.paneltoexcel.Size = new System.Drawing.Size(555, 297);
            this.paneltoexcel.TabIndex = 106;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(438, 17);
            this.btn_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(94, 32);
            this.btn_export.TabIndex = 101;
            this.btn_export.Text = "导出";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // cbo_export
            // 
            this.cbo_export.DisplayMember = "姓名";
            this.cbo_export.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_export.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_export.FormattingEnabled = true;
            this.cbo_export.Items.AddRange(new object[] {
            "家长信息",
            "教员信息",
            "家教信息",
            "工作人员信息",
            "责任认定"});
            this.cbo_export.Location = new System.Drawing.Point(162, 20);
            this.cbo_export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_export.Name = "cbo_export";
            this.cbo_export.Size = new System.Drawing.Size(248, 28);
            this.cbo_export.TabIndex = 34;
            this.cbo_export.ValueMember = "姓名";
            this.cbo_export.SelectedIndexChanged += new System.EventHandler(this.cbo_export_SelectedIndexChanged);
            // 
            // panelselect
            // 
            this.panelselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelselect.Controls.Add(this.lbl_select);
            this.panelselect.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelselect.Location = new System.Drawing.Point(0, 0);
            this.panelselect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelselect.Name = "panelselect";
            this.panelselect.Size = new System.Drawing.Size(120, 297);
            this.panelselect.TabIndex = 0;
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.lbl_select.Location = new System.Drawing.Point(6, 20);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(107, 26);
            this.lbl_select.TabIndex = 0;
            this.lbl_select.Text = "选择导出表";
            // 
            // database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 349);
            this.Controls.Add(this.paneldatabase);
            this.Controls.Add(this.paneltoexcel);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.paneltop);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "database";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.paneldatabase.ResumeLayout(false);
            this.panelrpath.ResumeLayout(false);
            this.panelrpath.PerformLayout();
            this.panelbpath.ResumeLayout(false);
            this.panelbpath.PerformLayout();
            this.panellabels.ResumeLayout(false);
            this.panellabels.PerformLayout();
            this.paneltoexcel.ResumeLayout(false);
            this.panelselect.ResumeLayout(false);
            this.panelselect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button btn_forms;
        private System.Windows.Forms.Button btn_database;
        private System.Windows.Forms.Panel paneldatabase;
        private System.Windows.Forms.Panel panellabels;
        private System.Windows.Forms.Label lbl_restore;
        private System.Windows.Forms.Label lbl_backup;
        private System.Windows.Forms.Panel panelbpath;
        private System.Windows.Forms.TextBox txt_bpath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_bpath;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_rpath;
        private System.Windows.Forms.Panel panelrpath;
        private System.Windows.Forms.TextBox txt_rpath;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Panel paneltoexcel;
        private System.Windows.Forms.Panel panelselect;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.ComboBox cbo_export;
        private System.Windows.Forms.Button btn_export;
    }
}