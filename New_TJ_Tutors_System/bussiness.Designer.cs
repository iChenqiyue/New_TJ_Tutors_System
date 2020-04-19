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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_bus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
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
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.gpo_state.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_done)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.panel4.Controls.Add(this.btn_bus);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 361);
            this.panel4.TabIndex = 66;
            // 
            // btn_bus
            // 
            this.btn_bus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_bus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_bus.FlatAppearance.BorderSize = 0;
            this.btn_bus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btn_bus.ForeColor = System.Drawing.Color.White;
            this.btn_bus.Location = new System.Drawing.Point(0, 165);
            this.btn_bus.Name = "btn_bus";
            this.btn_bus.Size = new System.Drawing.Size(120, 44);
            this.btn_bus.TabIndex = 76;
            this.btn_bus.Text = "办理业务";
            this.btn_bus.UseVisualStyleBackColor = false;
            this.btn_bus.Click += new System.EventHandler(this.btn_bus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(579, 152);
            this.dataGridView1.TabIndex = 66;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.gpo_state);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(579, 165);
            this.panel6.TabIndex = 79;
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
            this.lbl_tutor_state.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.dgv_done.Location = new System.Drawing.Point(0, 361);
            this.dgv_done.Name = "dgv_done";
            this.dgv_done.RowTemplate.Height = 27;
            this.dgv_done.Size = new System.Drawing.Size(579, 388);
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
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bussiness";
            this.Text = "bussiness";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.gpo_state.ResumeLayout(false);
            this.gpo_state.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_done)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_bus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel6;
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
    }
}