namespace New_TJ_Tutors_System
{
    partial class deal
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
            this.paneltitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.panelselect = new System.Windows.Forms.Panel();
            this.cbo_tutors_num = new System.Windows.Forms.ComboBox();
            this.btn_inquire = new System.Windows.Forms.Button();
            this.btn_cannel = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.cbo_tutors_state = new System.Windows.Forms.ComboBox();
            this.lbl_tutors_state = new System.Windows.Forms.Label();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.cbo_principal = new System.Windows.Forms.ComboBox();
            this.lbl_principal = new System.Windows.Forms.Label();
            this.dt_time = new System.Windows.Forms.DateTimePicker();
            this.lbl_time = new System.Windows.Forms.Label();
            this.cbo_state = new System.Windows.Forms.ComboBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.txt_tutors_name = new System.Windows.Forms.TextBox();
            this.lbl_tutors_name = new System.Windows.Forms.Label();
            this.lbl_tutors_num = new System.Windows.Forms.Label();
            this.txt_printnum = new System.Windows.Forms.TextBox();
            this.lbl_print_num = new System.Windows.Forms.Label();
            this.paneltitle.SuspendLayout();
            this.panelinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.paneltitle.Controls.Add(this.label1);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(990, 35);
            this.paneltitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "业务办理";
            // 
            // panelinfo
            // 
            this.panelinfo.Controls.Add(this.cbo_tutors_num);
            this.panelinfo.Controls.Add(this.btn_inquire);
            this.panelinfo.Controls.Add(this.btn_cannel);
            this.panelinfo.Controls.Add(this.btn_yes);
            this.panelinfo.Controls.Add(this.cbo_tutors_state);
            this.panelinfo.Controls.Add(this.lbl_tutors_state);
            this.panelinfo.Controls.Add(this.txt_remark);
            this.panelinfo.Controls.Add(this.lbl_remark);
            this.panelinfo.Controls.Add(this.cbo_principal);
            this.panelinfo.Controls.Add(this.lbl_principal);
            this.panelinfo.Controls.Add(this.dt_time);
            this.panelinfo.Controls.Add(this.lbl_time);
            this.panelinfo.Controls.Add(this.cbo_state);
            this.panelinfo.Controls.Add(this.lbl_state);
            this.panelinfo.Controls.Add(this.txt_tutors_name);
            this.panelinfo.Controls.Add(this.lbl_tutors_name);
            this.panelinfo.Controls.Add(this.lbl_tutors_num);
            this.panelinfo.Controls.Add(this.txt_printnum);
            this.panelinfo.Controls.Add(this.lbl_print_num);
            this.panelinfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelinfo.Location = new System.Drawing.Point(0, 35);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(552, 667);
            this.panelinfo.TabIndex = 1;
            // 
            // panelselect
            // 
            this.panelselect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelselect.Location = new System.Drawing.Point(552, 35);
            this.panelselect.Name = "panelselect";
            this.panelselect.Size = new System.Drawing.Size(438, 667);
            this.panelselect.TabIndex = 2;
            // 
            // cbo_tutors_num
            // 
            this.cbo_tutors_num.FormattingEnabled = true;
            this.cbo_tutors_num.Location = new System.Drawing.Point(131, 86);
            this.cbo_tutors_num.Name = "cbo_tutors_num";
            this.cbo_tutors_num.Size = new System.Drawing.Size(200, 23);
            this.cbo_tutors_num.TabIndex = 43;
            // 
            // btn_inquire
            // 
            this.btn_inquire.Location = new System.Drawing.Point(367, 76);
            this.btn_inquire.Name = "btn_inquire";
            this.btn_inquire.Size = new System.Drawing.Size(120, 40);
            this.btn_inquire.TabIndex = 42;
            this.btn_inquire.Text = "教员查找";
            this.btn_inquire.UseVisualStyleBackColor = true;
            // 
            // btn_cannel
            // 
            this.btn_cannel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cannel.Location = new System.Drawing.Point(224, 601);
            this.btn_cannel.Name = "btn_cannel";
            this.btn_cannel.Size = new System.Drawing.Size(120, 40);
            this.btn_cannel.TabIndex = 41;
            this.btn_cannel.Text = "取消";
            this.btn_cannel.UseVisualStyleBackColor = true;
            // 
            // btn_yes
            // 
            this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_yes.Location = new System.Drawing.Point(32, 601);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(120, 40);
            this.btn_yes.TabIndex = 40;
            this.btn_yes.Text = "确认";
            this.btn_yes.UseVisualStyleBackColor = true;
            // 
            // cbo_tutors_state
            // 
            this.cbo_tutors_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tutors_state.FormattingEnabled = true;
            this.cbo_tutors_state.Items.AddRange(new object[] {
            "接入",
            "已接",
            "待接",
            "换人",
            "不请",
            "重请"});
            this.cbo_tutors_state.Location = new System.Drawing.Point(134, 505);
            this.cbo_tutors_state.Name = "cbo_tutors_state";
            this.cbo_tutors_state.Size = new System.Drawing.Size(197, 23);
            this.cbo_tutors_state.TabIndex = 39;
            // 
            // lbl_tutors_state
            // 
            this.lbl_tutors_state.AutoSize = true;
            this.lbl_tutors_state.Location = new System.Drawing.Point(29, 508);
            this.lbl_tutors_state.Name = "lbl_tutors_state";
            this.lbl_tutors_state.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutors_state.TabIndex = 38;
            this.lbl_tutors_state.Text = "家教状态";
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(134, 398);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remark.Size = new System.Drawing.Size(390, 85);
            this.txt_remark.TabIndex = 37;
            // 
            // lbl_remark
            // 
            this.lbl_remark.AutoSize = true;
            this.lbl_remark.Location = new System.Drawing.Point(29, 401);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(37, 15);
            this.lbl_remark.TabIndex = 36;
            this.lbl_remark.Text = "备注";
            // 
            // cbo_principal
            // 
            this.cbo_principal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_principal.FormattingEnabled = true;
            this.cbo_principal.Location = new System.Drawing.Point(134, 342);
            this.cbo_principal.Name = "cbo_principal";
            this.cbo_principal.Size = new System.Drawing.Size(197, 23);
            this.cbo_principal.TabIndex = 35;
            // 
            // lbl_principal
            // 
            this.lbl_principal.AutoSize = true;
            this.lbl_principal.Location = new System.Drawing.Point(29, 345);
            this.lbl_principal.Name = "lbl_principal";
            this.lbl_principal.Size = new System.Drawing.Size(52, 15);
            this.lbl_principal.TabIndex = 34;
            this.lbl_principal.Text = "经办人";
            // 
            // dt_time
            // 
            this.dt_time.Location = new System.Drawing.Point(131, 280);
            this.dt_time.Name = "dt_time";
            this.dt_time.Size = new System.Drawing.Size(200, 25);
            this.dt_time.TabIndex = 33;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(29, 287);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(67, 15);
            this.lbl_time.TabIndex = 32;
            this.lbl_time.Text = "经办时间";
            // 
            // cbo_state
            // 
            this.cbo_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_state.FormattingEnabled = true;
            this.cbo_state.Items.AddRange(new object[] {
            "接入",
            "已接",
            "待接",
            "换人",
            "不请",
            "重请"});
            this.cbo_state.Location = new System.Drawing.Point(131, 214);
            this.cbo_state.Name = "cbo_state";
            this.cbo_state.Size = new System.Drawing.Size(200, 23);
            this.cbo_state.TabIndex = 31;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(29, 214);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(67, 15);
            this.lbl_state.TabIndex = 30;
            this.lbl_state.Text = "进行状态";
            // 
            // txt_tutors_name
            // 
            this.txt_tutors_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_tutors_name.Location = new System.Drawing.Point(131, 152);
            this.txt_tutors_name.Name = "txt_tutors_name";
            this.txt_tutors_name.Size = new System.Drawing.Size(200, 25);
            this.txt_tutors_name.TabIndex = 29;
            // 
            // lbl_tutors_name
            // 
            this.lbl_tutors_name.AutoSize = true;
            this.lbl_tutors_name.Location = new System.Drawing.Point(29, 155);
            this.lbl_tutors_name.Name = "lbl_tutors_name";
            this.lbl_tutors_name.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutors_name.TabIndex = 28;
            this.lbl_tutors_name.Text = "教员姓名";
            // 
            // lbl_tutors_num
            // 
            this.lbl_tutors_num.AutoSize = true;
            this.lbl_tutors_num.Location = new System.Drawing.Point(29, 89);
            this.lbl_tutors_num.Name = "lbl_tutors_num";
            this.lbl_tutors_num.Size = new System.Drawing.Size(67, 15);
            this.lbl_tutors_num.TabIndex = 27;
            this.lbl_tutors_num.Text = "教员编号";
            // 
            // txt_printnum
            // 
            this.txt_printnum.Location = new System.Drawing.Point(131, 26);
            this.txt_printnum.Name = "txt_printnum";
            this.txt_printnum.ReadOnly = true;
            this.txt_printnum.Size = new System.Drawing.Size(200, 25);
            this.txt_printnum.TabIndex = 26;
            // 
            // lbl_print_num
            // 
            this.lbl_print_num.AutoSize = true;
            this.lbl_print_num.Location = new System.Drawing.Point(29, 29);
            this.lbl_print_num.Name = "lbl_print_num";
            this.lbl_print_num.Size = new System.Drawing.Size(67, 15);
            this.lbl_print_num.TabIndex = 25;
            this.lbl_print_num.Text = "打印编号";
            // 
            // deal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 702);
            this.Controls.Add(this.panelselect);
            this.Controls.Add(this.panelinfo);
            this.Controls.Add(this.paneltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "deal";
            this.Text = "deal";
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.panelinfo.ResumeLayout(false);
            this.panelinfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Panel panelselect;
        private System.Windows.Forms.ComboBox cbo_tutors_num;
        private System.Windows.Forms.Button btn_inquire;
        private System.Windows.Forms.Button btn_cannel;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.ComboBox cbo_tutors_state;
        private System.Windows.Forms.Label lbl_tutors_state;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label lbl_remark;
        private System.Windows.Forms.ComboBox cbo_principal;
        private System.Windows.Forms.Label lbl_principal;
        private System.Windows.Forms.DateTimePicker dt_time;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.ComboBox cbo_state;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.TextBox txt_tutors_name;
        private System.Windows.Forms.Label lbl_tutors_name;
        private System.Windows.Forms.Label lbl_tutors_num;
        private System.Windows.Forms.TextBox txt_printnum;
        private System.Windows.Forms.Label lbl_print_num;
    }
}