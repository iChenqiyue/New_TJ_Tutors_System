namespace New_TJ_Tutors_System
{
    partial class login
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
            this.panelleft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelright = new System.Windows.Forms.Panel();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panelpwd = new System.Windows.Forms.Panel();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.paneluser = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelright.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelpwd.SuspendLayout();
            this.paneluser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.White;
            this.panelleft.Controls.Add(this.pictureBox1);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(305, 337);
            this.panelleft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::New_TJ_Tutors_System.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelright
            // 
            this.panelright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.panelright.Controls.Add(this.labeltitle);
            this.panelright.Controls.Add(this.panel1);
            this.panelright.Controls.Add(this.btn_login);
            this.panelright.Controls.Add(this.panelpwd);
            this.panelright.Controls.Add(this.paneluser);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelright.Location = new System.Drawing.Point(305, 0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(580, 337);
            this.panelright.TabIndex = 1;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(108, 58);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(369, 37);
            this.labeltitle.TabIndex = 65;
            this.labeltitle.Text = "同 济 大 学 家 教 管 理 系 统";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 36);
            this.panel1.TabIndex = 64;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_min
            // 
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("微软雅黑", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_min.ForeColor = System.Drawing.Color.White;
            this.btn_min.Location = new System.Drawing.Point(444, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(68, 36);
            this.btn_min.TabIndex = 5;
            this.btn_min.Text = "—";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // button_close
            // 
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(512, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(68, 36);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(185, 269);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(220, 41);
            this.btn_login.TabIndex = 63;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panelpwd
            // 
            this.panelpwd.BackColor = System.Drawing.Color.Blue;
            this.panelpwd.Controls.Add(this.txt_pwd);
            this.panelpwd.Controls.Add(this.panel5);
            this.panelpwd.Location = new System.Drawing.Point(126, 196);
            this.panelpwd.Name = "panelpwd";
            this.panelpwd.Size = new System.Drawing.Size(327, 32);
            this.panelpwd.TabIndex = 4;
            // 
            // txt_pwd
            // 
            this.txt_pwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.txt_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pwd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_pwd.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pwd.ForeColor = System.Drawing.Color.White;
            this.txt_pwd.Location = new System.Drawing.Point(0, 0);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(327, 31);
            this.txt_pwd.TabIndex = 2;
            this.txt_pwd.Text = "Password";
            this.txt_pwd.Enter += new System.EventHandler(this.txt_pwd_Enter);
            this.txt_pwd.Leave += new System.EventHandler(this.txt_pwd_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 1);
            this.panel5.TabIndex = 1;
            // 
            // paneluser
            // 
            this.paneluser.BackColor = System.Drawing.Color.Blue;
            this.paneluser.Controls.Add(this.txt_user);
            this.paneluser.Controls.Add(this.panel4);
            this.paneluser.Location = new System.Drawing.Point(126, 121);
            this.paneluser.Name = "paneluser";
            this.paneluser.Size = new System.Drawing.Size(327, 32);
            this.paneluser.TabIndex = 3;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_user.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_user.ForeColor = System.Drawing.Color.White;
            this.txt_user.Location = new System.Drawing.Point(0, 0);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(327, 31);
            this.txt_user.TabIndex = 2;
            this.txt_user.Text = "Username";
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 1);
            this.panel4.TabIndex = 1;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 337);
            this.Controls.Add(this.panelright);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panelleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelright.ResumeLayout(false);
            this.panelright.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelpwd.ResumeLayout(false);
            this.panelpwd.PerformLayout();
            this.paneluser.ResumeLayout(false);
            this.paneluser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Panel panelpwd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Panel paneluser;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labeltitle;
    }
}