namespace New_TJ_Tutors_System
{
    partial class bussiness
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panelbus = new System.Windows.Forms.Panel();
            this.btn_bus = new System.Windows.Forms.Button();
            this.cbo_state = new System.Windows.Forms.ComboBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.txt_tutor_num = new System.Windows.Forms.TextBox();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_tutor_num = new System.Windows.Forms.Label();
            this.cbo_subject = new System.Windows.Forms.ComboBox();
            this.lbl_tutor_name = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.txt_tutor_name = new System.Windows.Forms.TextBox();
            this.dgv_subject = new System.Windows.Forms.DataGridView();
            this.panelstate = new System.Windows.Forms.Panel();
            this.gpo_state = new System.Windows.Forms.GroupBox();
            this.cbo_tutor_state = new System.Windows.Forms.ComboBox();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.lbl_tutor_state = new System.Windows.Forms.Label();
            this.lbl_remarks = new System.Windows.Forms.Label();
            this.btn_save_buss = new System.Windows.Forms.Button();
            this.dgv_done = new System.Windows.Forms.DataGridView();
            this.多选 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教员编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paneltop.SuspendLayout();
            this.panelbus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subject)).BeginInit();
            this.panelstate.SuspendLayout();
            this.gpo_state.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_done)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.paneltop.Controls.Add(this.panelbus);
            this.paneltop.Controls.Add(this.dgv_subject);
            this.paneltop.Controls.Add(this.panelstate);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(579, 464);
            this.paneltop.TabIndex = 66;
            // 
            // panelbus
            // 
            this.panelbus.Controls.Add(this.btn_bus);
            this.panelbus.Controls.Add(this.cbo_state);
            this.panelbus.Controls.Add(this.txt_remark);
            this.panelbus.Controls.Add(this.lbl_remark);
            this.panelbus.Controls.Add(this.txt_tutor_num);
            this.panelbus.Controls.Add(this.lbl_subject);
            this.panelbus.Controls.Add(this.lbl_tutor_num);
            this.panelbus.Controls.Add(this.cbo_subject);
            this.panelbus.Controls.Add(this.lbl_tutor_name);
            this.panelbus.Controls.Add(this.lbl_state);
            this.panelbus.Controls.Add(this.txt_tutor_name);
            this.panelbus.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelbus.Location = new System.Drawing.Point(281, 165);
            this.panelbus.Name = "panelbus";
            this.panelbus.Size = new System.Drawing.Size(298, 299);
            this.panelbus.TabIndex = 81;
            // 
            // btn_bus
            // 
            this.btn_bus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_bus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_bus.ForeColor = System.Drawing.Color.White;
            this.btn_bus.Location = new System.Drawing.Point(108, 256);
            this.btn_bus.Name = "btn_bus";
            this.btn_bus.Size = new System.Drawing.Size(86, 38);
            this.btn_bus.TabIndex = 76;
            this.btn_bus.Text = "办理";
            this.btn_bus.UseVisualStyleBackColor = false;
            this.btn_bus.Click += new System.EventHandler(this.btn_bus_Click);
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
            this.cbo_state.Location = new System.Drawing.Point(166, 33);
            this.cbo_state.Name = "cbo_state";
            this.cbo_state.Size = new System.Drawing.Size(114, 23);
            this.cbo_state.TabIndex = 53;
            // 
            // txt_remark
            // 
            this.txt_remark.Location = new System.Drawing.Point(29, 146);
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remark.Size = new System.Drawing.Size(251, 100);
            this.txt_remark.TabIndex = 52;
            // 
            // lbl_remark
            // 
            this.lbl_remark.AutoSize = true;
            this.lbl_remark.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_remark.ForeColor = System.Drawing.Color.White;
            this.lbl_remark.Location = new System.Drawing.Point(25, 124);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(39, 19);
            this.lbl_remark.TabIndex = 51;
            this.lbl_remark.Text = "备注";
            // 
            // txt_tutor_num
            // 
            this.txt_tutor_num.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_tutor_num.Location = new System.Drawing.Point(29, 90);
            this.txt_tutor_num.Name = "txt_tutor_num";
            this.txt_tutor_num.Size = new System.Drawing.Size(114, 25);
            this.txt_tutor_num.TabIndex = 50;
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_subject.ForeColor = System.Drawing.Color.White;
            this.lbl_subject.Location = new System.Drawing.Point(25, 15);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(39, 19);
            this.lbl_subject.TabIndex = 43;
            this.lbl_subject.Text = "科目";
            // 
            // lbl_tutor_num
            // 
            this.lbl_tutor_num.AutoSize = true;
            this.lbl_tutor_num.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_tutor_num.ForeColor = System.Drawing.Color.White;
            this.lbl_tutor_num.Location = new System.Drawing.Point(25, 70);
            this.lbl_tutor_num.Name = "lbl_tutor_num";
            this.lbl_tutor_num.Size = new System.Drawing.Size(69, 19);
            this.lbl_tutor_num.TabIndex = 45;
            this.lbl_tutor_num.Text = "教员编号";
            // 
            // cbo_subject
            // 
            this.cbo_subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_subject.FormattingEnabled = true;
            this.cbo_subject.Items.AddRange(new object[] {
            "接入",
            "已接",
            "待接",
            "换人",
            "不请",
            "重请"});
            this.cbo_subject.Location = new System.Drawing.Point(29, 33);
            this.cbo_subject.Name = "cbo_subject";
            this.cbo_subject.Size = new System.Drawing.Size(114, 23);
            this.cbo_subject.TabIndex = 49;
            // 
            // lbl_tutor_name
            // 
            this.lbl_tutor_name.AutoSize = true;
            this.lbl_tutor_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_tutor_name.ForeColor = System.Drawing.Color.White;
            this.lbl_tutor_name.Location = new System.Drawing.Point(162, 70);
            this.lbl_tutor_name.Name = "lbl_tutor_name";
            this.lbl_tutor_name.Size = new System.Drawing.Size(69, 19);
            this.lbl_tutor_name.TabIndex = 46;
            this.lbl_tutor_name.Text = "教员姓名";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_state.ForeColor = System.Drawing.Color.White;
            this.lbl_state.Location = new System.Drawing.Point(163, 15);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(69, 19);
            this.lbl_state.TabIndex = 48;
            this.lbl_state.Text = "进行状态";
            // 
            // txt_tutor_name
            // 
            this.txt_tutor_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_tutor_name.Location = new System.Drawing.Point(166, 90);
            this.txt_tutor_name.Name = "txt_tutor_name";
            this.txt_tutor_name.Size = new System.Drawing.Size(114, 25);
            this.txt_tutor_name.TabIndex = 47;
            // 
            // dgv_subject
            // 
            this.dgv_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_subject.Location = new System.Drawing.Point(0, 165);
            this.dgv_subject.Name = "dgv_subject";
            this.dgv_subject.RowTemplate.Height = 27;
            this.dgv_subject.Size = new System.Drawing.Size(579, 299);
            this.dgv_subject.TabIndex = 66;
            // 
            // panelstate
            // 
            this.panelstate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelstate.Controls.Add(this.gpo_state);
            this.panelstate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelstate.Location = new System.Drawing.Point(0, 0);
            this.panelstate.Name = "panelstate";
            this.panelstate.Size = new System.Drawing.Size(579, 165);
            this.panelstate.TabIndex = 79;
            // 
            // gpo_state
            // 
            this.gpo_state.Controls.Add(this.cbo_tutor_state);
            this.gpo_state.Controls.Add(this.txt_remarks);
            this.gpo_state.Controls.Add(this.lbl_tutor_state);
            this.gpo_state.Controls.Add(this.lbl_remarks);
            this.gpo_state.Controls.Add(this.btn_save_buss);
            this.gpo_state.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.gpo_state.ForeColor = System.Drawing.Color.White;
            this.gpo_state.Location = new System.Drawing.Point(31, 0);
            this.gpo_state.Name = "gpo_state";
            this.gpo_state.Size = new System.Drawing.Size(500, 155);
            this.gpo_state.TabIndex = 78;
            this.gpo_state.TabStop = false;
            this.gpo_state.Text = "当前状态";
            // 
            // cbo_tutor_state
            // 
            this.cbo_tutor_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tutor_state.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbo_tutor_state.ForeColor = System.Drawing.Color.White;
            this.cbo_tutor_state.FormattingEnabled = true;
            this.cbo_tutor_state.Location = new System.Drawing.Point(27, 48);
            this.cbo_tutor_state.Name = "cbo_tutor_state";
            this.cbo_tutor_state.Size = new System.Drawing.Size(195, 28);
            this.cbo_tutor_state.TabIndex = 77;
            // 
            // txt_remarks
            // 
            this.txt_remarks.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_remarks.ForeColor = System.Drawing.Color.White;
            this.txt_remarks.Location = new System.Drawing.Point(27, 98);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(449, 50);
            this.txt_remarks.TabIndex = 72;
            // 
            // lbl_tutor_state
            // 
            this.lbl_tutor_state.AutoSize = true;
            this.lbl_tutor_state.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_tutor_state.ForeColor = System.Drawing.Color.White;
            this.lbl_tutor_state.Location = new System.Drawing.Point(24, 30);
            this.lbl_tutor_state.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_tutor_state.Name = "lbl_tutor_state";
            this.lbl_tutor_state.Size = new System.Drawing.Size(69, 19);
            this.lbl_tutor_state.TabIndex = 67;
            this.lbl_tutor_state.Text = "家教状态";
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.AutoSize = true;
            this.lbl_remarks.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_remarks.ForeColor = System.Drawing.Color.White;
            this.lbl_remarks.Location = new System.Drawing.Point(24, 79);
            this.lbl_remarks.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(69, 19);
            this.lbl_remarks.TabIndex = 69;
            this.lbl_remarks.Text = "重要备注";
            // 
            // btn_save_buss
            // 
            this.btn_save_buss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_save_buss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_buss.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save_buss.ForeColor = System.Drawing.Color.White;
            this.btn_save_buss.Location = new System.Drawing.Point(371, 27);
            this.btn_save_buss.Name = "btn_save_buss";
            this.btn_save_buss.Size = new System.Drawing.Size(105, 61);
            this.btn_save_buss.TabIndex = 75;
            this.btn_save_buss.Text = "保存信息";
            this.btn_save_buss.UseVisualStyleBackColor = false;
            // 
            // dgv_done
            // 
            this.dgv_done.AllowUserToDeleteRows = false;
            this.dgv_done.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_done.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_done.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_done.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_done.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_done.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.多选,
            this.Column3,
            this.教员编号,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dgv_done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_done.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv_done.Location = new System.Drawing.Point(0, 464);
            this.dgv_done.Name = "dgv_done";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_done.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_done.RowTemplate.Height = 27;
            this.dgv_done.Size = new System.Drawing.Size(579, 285);
            this.dgv_done.TabIndex = 67;
            // 
            // 多选
            // 
            this.多选.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.多选.HeaderText = "多选";
            this.多选.Name = "多选";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "科目";
            this.Column3.Name = "Column3";
            // 
            // 教员编号
            // 
            this.教员编号.HeaderText = "教员编号";
            this.教员编号.Name = "教员编号";
            this.教员编号.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.教员编号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "教员姓名";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "经办时间";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "经办人";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "处理备注";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bussiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 749);
            this.Controls.Add(this.dgv_done);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bussiness";
            this.Text = "bussiness";
            this.paneltop.ResumeLayout(false);
            this.panelbus.ResumeLayout(false);
            this.panelbus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subject)).EndInit();
            this.panelstate.ResumeLayout(false);
            this.gpo_state.ResumeLayout(false);
            this.gpo_state.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_done)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.DataGridView dgv_subject;
        private System.Windows.Forms.Panel panelstate;
        private System.Windows.Forms.GroupBox gpo_state;
        private System.Windows.Forms.ComboBox cbo_tutor_state;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Label lbl_tutor_state;
        private System.Windows.Forms.Label lbl_remarks;
        private System.Windows.Forms.Button btn_save_buss;
        private System.Windows.Forms.DataGridView dgv_done;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 多选;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 教员编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panelbus;
        private System.Windows.Forms.TextBox txt_tutor_num;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_tutor_num;
        private System.Windows.Forms.ComboBox cbo_subject;
        private System.Windows.Forms.Label lbl_tutor_name;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.TextBox txt_tutor_name;
        private System.Windows.Forms.Button btn_bus;
        private System.Windows.Forms.ComboBox cbo_state;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label lbl_remark;
    }
}