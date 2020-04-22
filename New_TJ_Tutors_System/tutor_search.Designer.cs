namespace New_TJ_Tutors_System
{
    partial class tutor_search
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
            this.panelsearchresult = new System.Windows.Forms.Panel();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.panelop = new System.Windows.Forms.Panel();
            this.lbl_select = new System.Windows.Forms.Label();
            this.cbo_select = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.gbo_search = new System.Windows.Forms.GroupBox();
            this.txt_num_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_stunum_search = new System.Windows.Forms.TextBox();
            this.txt_phone_search = new System.Windows.Forms.TextBox();
            this.txt_name_search = new System.Windows.Forms.TextBox();
            this.panelleft.SuspendLayout();
            this.panelsearchresult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.panelop.SuspendLayout();
            this.panelsearch.SuspendLayout();
            this.gbo_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(161)))), ((int)(((byte)(244)))));
            this.panelleft.Controls.Add(this.panelsearchresult);
            this.panelleft.Controls.Add(this.panelop);
            this.panelleft.Controls.Add(this.panelsearch);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(591, 785);
            this.panelleft.TabIndex = 3;
            // 
            // panelsearchresult
            // 
            this.panelsearchresult.Controls.Add(this.dgv_search);
            this.panelsearchresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelsearchresult.Location = new System.Drawing.Point(0, 169);
            this.panelsearchresult.Name = "panelsearchresult";
            this.panelsearchresult.Size = new System.Drawing.Size(591, 616);
            this.panelsearchresult.TabIndex = 12;
            // 
            // dgv_search
            // 
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_search.Location = new System.Drawing.Point(0, 0);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RowTemplate.Height = 27;
            this.dgv_search.Size = new System.Drawing.Size(591, 616);
            this.dgv_search.TabIndex = 0;
            // 
            // panelop
            // 
            this.panelop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.panelop.Controls.Add(this.lbl_select);
            this.panelop.Controls.Add(this.cbo_select);
            this.panelop.Controls.Add(this.btn_delete);
            this.panelop.Controls.Add(this.btn_add);
            this.panelop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelop.Location = new System.Drawing.Point(0, 119);
            this.panelop.Name = "panelop";
            this.panelop.Size = new System.Drawing.Size(591, 50);
            this.panelop.TabIndex = 11;
            // 
            // lbl_select
            // 
            this.lbl_select.AutoSize = true;
            this.lbl_select.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_select.ForeColor = System.Drawing.Color.White;
            this.lbl_select.Location = new System.Drawing.Point(264, 17);
            this.lbl_select.Name = "lbl_select";
            this.lbl_select.Size = new System.Drawing.Size(69, 19);
            this.lbl_select.TabIndex = 18;
            this.lbl_select.Text = "筛选条件";
            // 
            // cbo_select
            // 
            this.cbo_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.cbo_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_select.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbo_select.ForeColor = System.Drawing.Color.White;
            this.cbo_select.FormattingEnabled = true;
            this.cbo_select.Items.AddRange(new object[] {
            "全部",
            "黑名单",
            "非黑名单"});
            this.cbo_select.Location = new System.Drawing.Point(338, 13);
            this.cbo_select.Name = "cbo_select";
            this.cbo_select.Size = new System.Drawing.Size(148, 28);
            this.cbo_select.TabIndex = 17;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::New_TJ_Tutors_System.Properties.Resources.ashbin;
            this.btn_delete.Location = new System.Drawing.Point(123, 0);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 50);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "删除";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = global::New_TJ_Tutors_System.Properties.Resources.nav_list;
            this.btn_add.Location = new System.Drawing.Point(0, 0);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 50);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "新增";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // panelsearch
            // 
            this.panelsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.panelsearch.Controls.Add(this.gbo_search);
            this.panelsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsearch.Location = new System.Drawing.Point(0, 0);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(591, 119);
            this.panelsearch.TabIndex = 10;
            // 
            // gbo_search
            // 
            this.gbo_search.Controls.Add(this.txt_num_search);
            this.gbo_search.Controls.Add(this.btn_search);
            this.gbo_search.Controls.Add(this.txt_stunum_search);
            this.gbo_search.Controls.Add(this.txt_phone_search);
            this.gbo_search.Controls.Add(this.txt_name_search);
            this.gbo_search.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbo_search.ForeColor = System.Drawing.Color.White;
            this.gbo_search.Location = new System.Drawing.Point(12, 5);
            this.gbo_search.Name = "gbo_search";
            this.gbo_search.Size = new System.Drawing.Size(483, 111);
            this.gbo_search.TabIndex = 5;
            this.gbo_search.TabStop = false;
            this.gbo_search.Text = "搜索";
            // 
            // txt_num_search
            // 
            this.txt_num_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(99)))), ((int)(((byte)(199)))));
            this.txt_num_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_num_search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_num_search.ForeColor = System.Drawing.Color.Gray;
            this.txt_num_search.Location = new System.Drawing.Point(25, 35);
            this.txt_num_search.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txt_num_search.Name = "txt_num_search";
            this.txt_num_search.Size = new System.Drawing.Size(179, 27);
            this.txt_num_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(397, 35);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(78, 54);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_stunum_search
            // 
            this.txt_stunum_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(184)))), ((int)(((byte)(211)))));
            this.txt_stunum_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stunum_search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_stunum_search.ForeColor = System.Drawing.Color.SeaShell;
            this.txt_stunum_search.Location = new System.Drawing.Point(25, 62);
            this.txt_stunum_search.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.txt_stunum_search.Name = "txt_stunum_search";
            this.txt_stunum_search.Size = new System.Drawing.Size(179, 27);
            this.txt_stunum_search.TabIndex = 2;
            // 
            // txt_phone_search
            // 
            this.txt_phone_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.txt_phone_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_phone_search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_phone_search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_phone_search.Location = new System.Drawing.Point(204, 62);
            this.txt_phone_search.Margin = new System.Windows.Forms.Padding(0, 0, 100, 20);
            this.txt_phone_search.Name = "txt_phone_search";
            this.txt_phone_search.Size = new System.Drawing.Size(179, 27);
            this.txt_phone_search.TabIndex = 3;
            // 
            // txt_name_search
            // 
            this.txt_name_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(184)))), ((int)(((byte)(211)))));
            this.txt_name_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name_search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_name_search.ForeColor = System.Drawing.Color.SeaShell;
            this.txt_name_search.Location = new System.Drawing.Point(204, 35);
            this.txt_name_search.Margin = new System.Windows.Forms.Padding(0, 20, 100, 0);
            this.txt_name_search.Name = "txt_name_search";
            this.txt_name_search.Size = new System.Drawing.Size(179, 27);
            this.txt_name_search.TabIndex = 1;
            // 
            // tutor_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 785);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tutor_search";
            this.Text = "deal";
            this.panelleft.ResumeLayout(false);
            this.panelsearchresult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.panelop.ResumeLayout(false);
            this.panelop.PerformLayout();
            this.panelsearch.ResumeLayout(false);
            this.gbo_search.ResumeLayout(false);
            this.gbo_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelsearchresult;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Panel panelop;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.ComboBox cbo_select;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.GroupBox gbo_search;
        private System.Windows.Forms.TextBox txt_num_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_stunum_search;
        private System.Windows.Forms.TextBox txt_phone_search;
        private System.Windows.Forms.TextBox txt_name_search;
    }
}