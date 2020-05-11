namespace New_TJ_Tutors_System
{
    partial class user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            this.paneltop = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelop = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbo_degree = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelop.SuspendLayout();
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
            this.paneltop.Size = new System.Drawing.Size(538, 36);
            this.paneltop.TabIndex = 2;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            this.paneltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseMove);
            this.paneltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseUp);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(12, 4);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(110, 27);
            this.labeltitle.TabIndex = 3;
            this.labeltitle.Text = "用 户 管 理";
            this.labeltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labeltitle_MouseDown);
            this.labeltitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labeltitle_MouseMove);
            this.labeltitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labeltitle_MouseUp);
            // 
            // button_close
            // 
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(483, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(55, 36);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_user.Location = new System.Drawing.Point(0, 50);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowTemplate.Height = 27;
            this.dgv_user.Size = new System.Drawing.Size(320, 263);
            this.dgv_user.TabIndex = 3;
            this.dgv_user.SelectionChanged += new System.EventHandler(this.dgv_user_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_user);
            this.panel1.Controls.Add(this.panelop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 313);
            this.panel1.TabIndex = 4;
            // 
            // panelop
            // 
            this.panelop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.panelop.Controls.Add(this.btn_delete);
            this.panelop.Controls.Add(this.btn_add);
            this.panelop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelop.Location = new System.Drawing.Point(0, 0);
            this.panelop.Name = "panelop";
            this.panelop.Size = new System.Drawing.Size(320, 50);
            this.panelop.TabIndex = 12;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(160, 0);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(160, 50);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "删除";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(160, 50);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "新增";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbo_degree
            // 
            this.cbo_degree.BackColor = System.Drawing.Color.White;
            this.cbo_degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_degree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_degree.FormattingEnabled = true;
            this.cbo_degree.Items.AddRange(new object[] {
            "管理员",
            "操作员"});
            this.cbo_degree.Location = new System.Drawing.Point(350, 225);
            this.cbo_degree.Name = "cbo_degree";
            this.cbo_degree.Size = new System.Drawing.Size(164, 28);
            this.cbo_degree.TabIndex = 88;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.Location = new System.Drawing.Point(348, 160);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(166, 27);
            this.txt_password.TabIndex = 86;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_username.Location = new System.Drawing.Point(349, 96);
            this.txt_username.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(165, 27);
            this.txt_username.TabIndex = 83;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.lbl_password.Location = new System.Drawing.Point(345, 137);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(39, 19);
            this.lbl_password.TabIndex = 87;
            this.lbl_password.Text = "密码";
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_degree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.lbl_degree.Location = new System.Drawing.Point(347, 202);
            this.lbl_degree.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(39, 19);
            this.lbl_degree.TabIndex = 85;
            this.lbl_degree.Text = "级别";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(112)))));
            this.lbl_username.Location = new System.Drawing.Point(347, 73);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(54, 19);
            this.lbl_username.TabIndex = 84;
            this.lbl_username.Text = "用户名";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(388, 288);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 32);
            this.btn_save.TabIndex = 102;
            this.btn_save.Text = "保存信息";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 349);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbo_degree);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_degree);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelop;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cbo_degree;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_degree;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_save;
    }
}