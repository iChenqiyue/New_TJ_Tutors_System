namespace New_TJ_Tutors_System
{
    partial class tutoring_all
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tutoring_all));
            this.paneleft = new System.Windows.Forms.Panel();
            this.panel_searchresult = new System.Windows.Forms.Panel();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.panelop = new System.Windows.Forms.Panel();
            this.lbl_select = new System.Windows.Forms.Label();
            this.cbo_select = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panelsearch = new System.Windows.Forms.Panel();
            this.gbo_search = new System.Windows.Forms.GroupBox();
            this.txt_parent_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_address_search = new System.Windows.Forms.TextBox();
            this.txt_phone_search = new System.Windows.Forms.TextBox();
            this.txt_print_search = new System.Windows.Forms.TextBox();
            this.panelright = new System.Windows.Forms.Panel();
            this.panelinfo = new System.Windows.Forms.Panel();
            this.paneltitle = new System.Windows.Forms.Panel();
            this.panel_tutor = new System.Windows.Forms.Panel();
            this.panel_buss = new System.Windows.Forms.Panel();
            this.btn_buss = new System.Windows.Forms.Button();
            this.btn_tutor_info = new System.Windows.Forms.Button();
            this.paneltutor = new System.Windows.Forms.Panel();
            this.paneleft.SuspendLayout();
            this.panel_searchresult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.panelop.SuspendLayout();
            this.panelsearch.SuspendLayout();
            this.gbo_search.SuspendLayout();
            this.panelright.SuspendLayout();
            this.paneltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneleft
            // 
            this.paneleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(161)))), ((int)(((byte)(244)))));
            this.paneleft.Controls.Add(this.panel_searchresult);
            this.paneleft.Controls.Add(this.panelop);
            this.paneleft.Controls.Add(this.panelsearch);
            this.paneleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneleft.Location = new System.Drawing.Point(0, 0);
            this.paneleft.Name = "paneleft";
            this.paneleft.Size = new System.Drawing.Size(591, 785);
            this.paneleft.TabIndex = 0;
            // 
            // panel_searchresult
            // 
            this.panel_searchresult.Controls.Add(this.dgv_search);
            this.panel_searchresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_searchresult.Location = new System.Drawing.Point(0, 169);
            this.panel_searchresult.Name = "panel_searchresult";
            this.panel_searchresult.Size = new System.Drawing.Size(591, 616);
            this.panel_searchresult.TabIndex = 12;
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
            "管理费未清家教",
            "待接家教",
            "未派出家教"});
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
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
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
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
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
            this.gbo_search.Controls.Add(this.txt_parent_search);
            this.gbo_search.Controls.Add(this.btn_search);
            this.gbo_search.Controls.Add(this.txt_address_search);
            this.gbo_search.Controls.Add(this.txt_phone_search);
            this.gbo_search.Controls.Add(this.txt_print_search);
            this.gbo_search.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbo_search.ForeColor = System.Drawing.Color.White;
            this.gbo_search.Location = new System.Drawing.Point(12, 5);
            this.gbo_search.Name = "gbo_search";
            this.gbo_search.Size = new System.Drawing.Size(483, 111);
            this.gbo_search.TabIndex = 5;
            this.gbo_search.TabStop = false;
            this.gbo_search.Text = "搜索";
            // 
            // txt_parent_search
            // 
            this.txt_parent_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(99)))), ((int)(((byte)(199)))));
            this.txt_parent_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_parent_search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_parent_search.ForeColor = System.Drawing.Color.Gray;
            this.txt_parent_search.Location = new System.Drawing.Point(25, 35);
            this.txt_parent_search.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.txt_parent_search.Name = "txt_parent_search";
            this.txt_parent_search.Size = new System.Drawing.Size(179, 27);
            this.txt_parent_search.TabIndex = 0;
            this.txt_parent_search.Enter += new System.EventHandler(this.txt_parent_search_Enter);
            this.txt_parent_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_parent_search_KeyPress);
            this.txt_parent_search.Leave += new System.EventHandler(this.txt_parent_num_Leave);
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
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_address_search
            // 
            this.txt_address_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(184)))), ((int)(((byte)(211)))));
            this.txt_address_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_address_search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_address_search.ForeColor = System.Drawing.Color.SeaShell;
            this.txt_address_search.Location = new System.Drawing.Point(25, 62);
            this.txt_address_search.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.txt_address_search.Name = "txt_address_search";
            this.txt_address_search.Size = new System.Drawing.Size(179, 27);
            this.txt_address_search.TabIndex = 2;
            this.txt_address_search.Enter += new System.EventHandler(this.txt_adress_Enter);
            this.txt_address_search.Leave += new System.EventHandler(this.txt_adress_Leave);
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
            this.txt_phone_search.Enter += new System.EventHandler(this.txt_phone_Enter);
            this.txt_phone_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            this.txt_phone_search.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // txt_print_search
            // 
            this.txt_print_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(184)))), ((int)(((byte)(211)))));
            this.txt_print_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_print_search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_print_search.ForeColor = System.Drawing.Color.SeaShell;
            this.txt_print_search.Location = new System.Drawing.Point(204, 35);
            this.txt_print_search.Margin = new System.Windows.Forms.Padding(0, 20, 100, 0);
            this.txt_print_search.Name = "txt_print_search";
            this.txt_print_search.Size = new System.Drawing.Size(179, 27);
            this.txt_print_search.TabIndex = 1;
            this.txt_print_search.Enter += new System.EventHandler(this.txt_print_num_Enter);
            this.txt_print_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_print_num_KeyPress);
            this.txt_print_search.Leave += new System.EventHandler(this.txt_print_num_Leave);
            // 
            // panelright
            // 
            this.panelright.Controls.Add(this.panelinfo);
            this.panelright.Controls.Add(this.paneltitle);
            this.panelright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelright.Location = new System.Drawing.Point(591, 0);
            this.panelright.Name = "panelright";
            this.panelright.Size = new System.Drawing.Size(579, 785);
            this.panelright.TabIndex = 1;
            // 
            // panelinfo
            // 
            this.panelinfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelinfo.Location = new System.Drawing.Point(0, 36);
            this.panelinfo.Name = "panelinfo";
            this.panelinfo.Size = new System.Drawing.Size(579, 749);
            this.panelinfo.TabIndex = 2;
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.paneltitle.Controls.Add(this.panel_tutor);
            this.paneltitle.Controls.Add(this.panel_buss);
            this.paneltitle.Controls.Add(this.btn_buss);
            this.paneltitle.Controls.Add(this.btn_tutor_info);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(579, 36);
            this.paneltitle.TabIndex = 1;
            // 
            // panel_tutor
            // 
            this.panel_tutor.BackColor = System.Drawing.Color.White;
            this.panel_tutor.Location = new System.Drawing.Point(0, 33);
            this.panel_tutor.Name = "panel_tutor";
            this.panel_tutor.Size = new System.Drawing.Size(128, 3);
            this.panel_tutor.TabIndex = 1;
            // 
            // panel_buss
            // 
            this.panel_buss.BackColor = System.Drawing.Color.White;
            this.panel_buss.Location = new System.Drawing.Point(128, 33);
            this.panel_buss.Name = "panel_buss";
            this.panel_buss.Size = new System.Drawing.Size(128, 3);
            this.panel_buss.TabIndex = 2;
            // 
            // btn_buss
            // 
            this.btn_buss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_buss.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_buss.FlatAppearance.BorderSize = 0;
            this.btn_buss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buss.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_buss.ForeColor = System.Drawing.Color.White;
            this.btn_buss.Location = new System.Drawing.Point(128, 0);
            this.btn_buss.Name = "btn_buss";
            this.btn_buss.Size = new System.Drawing.Size(128, 36);
            this.btn_buss.TabIndex = 1;
            this.btn_buss.Text = "业务详情";
            this.btn_buss.UseVisualStyleBackColor = false;
            this.btn_buss.Click += new System.EventHandler(this.btn_buss_Click_1);
            // 
            // btn_tutor_info
            // 
            this.btn_tutor_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.btn_tutor_info.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_tutor_info.FlatAppearance.BorderSize = 0;
            this.btn_tutor_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tutor_info.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_tutor_info.ForeColor = System.Drawing.Color.White;
            this.btn_tutor_info.Location = new System.Drawing.Point(0, 0);
            this.btn_tutor_info.Name = "btn_tutor_info";
            this.btn_tutor_info.Size = new System.Drawing.Size(128, 36);
            this.btn_tutor_info.TabIndex = 0;
            this.btn_tutor_info.Text = "家教信息";
            this.btn_tutor_info.UseVisualStyleBackColor = false;
            this.btn_tutor_info.Click += new System.EventHandler(this.btn_tutor_info_Click_1);
            // 
            // paneltutor
            // 
            this.paneltutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(161)))), ((int)(((byte)(244)))));
            this.paneltutor.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneltutor.Location = new System.Drawing.Point(0, 0);
            this.paneltutor.Name = "paneltutor";
            this.paneltutor.Size = new System.Drawing.Size(591, 785);
            this.paneltutor.TabIndex = 1;
            // 
            // tutoring_all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 785);
            this.Controls.Add(this.paneltutor);
            this.Controls.Add(this.paneleft);
            this.Controls.Add(this.panelright);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tutoring_all";
            this.Text = "tutoring_info";
            this.Load += new System.EventHandler(this.tutoring_info_Load);
            this.paneleft.ResumeLayout(false);
            this.panel_searchresult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.panelop.ResumeLayout(false);
            this.panelop.PerformLayout();
            this.panelsearch.ResumeLayout(false);
            this.gbo_search.ResumeLayout(false);
            this.gbo_search.PerformLayout();
            this.panelright.ResumeLayout(false);
            this.paneltitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneleft;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_phone_search;
        private System.Windows.Forms.TextBox txt_address_search;
        private System.Windows.Forms.TextBox txt_print_search;
        private System.Windows.Forms.TextBox txt_parent_search;
        private System.Windows.Forms.Panel panelright;
        private System.Windows.Forms.Panel panelop;
        private System.Windows.Forms.Label lbl_select;
        private System.Windows.Forms.ComboBox cbo_select;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel_searchresult;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.GroupBox gbo_search;
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Panel panel_buss;
        private System.Windows.Forms.Panel panel_tutor;
        private System.Windows.Forms.Button btn_buss;
        private System.Windows.Forms.Button btn_tutor_info;
        private System.Windows.Forms.Panel panelinfo;
        private System.Windows.Forms.Panel paneltutor;
    }
}