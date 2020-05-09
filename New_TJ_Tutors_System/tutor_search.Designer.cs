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
            this.panelsearch = new System.Windows.Forms.Panel();
            this.gbo_search = new System.Windows.Forms.GroupBox();
            this.txt_num_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_stunum_search = new System.Windows.Forms.TextBox();
            this.txt_phone_search = new System.Windows.Forms.TextBox();
            this.txt_name_search = new System.Windows.Forms.TextBox();
            this.paneltop = new System.Windows.Forms.Panel();
            this.button_close = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panelleft.SuspendLayout();
            this.panelsearchresult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.panelsearch.SuspendLayout();
            this.gbo_search.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(161)))), ((int)(((byte)(244)))));
            this.panelleft.Controls.Add(this.panelsearchresult);
            this.panelleft.Controls.Add(this.panelsearch);
            this.panelleft.Controls.Add(this.paneltop);
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
            this.panelsearchresult.Location = new System.Drawing.Point(0, 165);
            this.panelsearchresult.Name = "panelsearchresult";
            this.panelsearchresult.Size = new System.Drawing.Size(591, 620);
            this.panelsearchresult.TabIndex = 12;
            // 
            // dgv_search
            // 
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_search.Location = new System.Drawing.Point(0, 0);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RowTemplate.Height = 27;
            this.dgv_search.Size = new System.Drawing.Size(591, 620);
            this.dgv_search.TabIndex = 0;
            this.dgv_search.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_search_CellMouseClick);
            this.dgv_search.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_CellMouseEnter);
            this.dgv_search.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_CellMouseLeave);
            // 
            // panelsearch
            // 
            this.panelsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(144)))), ((int)(((byte)(251)))));
            this.panelsearch.Controls.Add(this.gbo_search);
            this.panelsearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsearch.Location = new System.Drawing.Point(0, 36);
            this.panelsearch.Name = "panelsearch";
            this.panelsearch.Size = new System.Drawing.Size(591, 129);
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
            this.gbo_search.Location = new System.Drawing.Point(49, 4);
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
            this.txt_num_search.Enter += new System.EventHandler(this.txt_num_search_Enter);
            this.txt_num_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_num_search_KeyPress);
            this.txt_num_search.Leave += new System.EventHandler(this.txt_num_search_Leave);
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
            this.txt_stunum_search.Enter += new System.EventHandler(this.txt_stunum_search_Enter);
            this.txt_stunum_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stunum_search_KeyPress);
            this.txt_stunum_search.Leave += new System.EventHandler(this.txt_stunum_search_Leave);
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
            this.txt_phone_search.Enter += new System.EventHandler(this.txt_phone_search_Enter);
            this.txt_phone_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_search_KeyPress);
            this.txt_phone_search.Leave += new System.EventHandler(this.txt_phone_search_Leave);
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
            this.txt_name_search.Enter += new System.EventHandler(this.txt_name_search_Enter);
            this.txt_name_search.Leave += new System.EventHandler(this.txt_name_search_Leave);
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(114)))), ((int)(((byte)(219)))));
            this.paneltop.Controls.Add(this.labeltitle);
            this.paneltop.Controls.Add(this.button_close);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(591, 36);
            this.paneltop.TabIndex = 1;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            this.paneltop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseMove);
            this.paneltop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseUp);
            // 
            // button_close
            // 
            this.button_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(536, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(55, 36);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(12, 4);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(116, 27);
            this.labeltitle.TabIndex = 3;
            this.labeltitle.Text = "选 择 教 员 ";
            this.labeltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labeltitle_MouseDown);
            this.labeltitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labeltitle_MouseMove);
            this.labeltitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labeltitle_MouseUp);
            // 
            // tutor_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 785);
            this.Controls.Add(this.panelleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tutor_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deal";
            this.Load += new System.EventHandler(this.tutor_search_Load);
            this.panelleft.ResumeLayout(false);
            this.panelsearchresult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.panelsearch.ResumeLayout(false);
            this.gbo_search.ResumeLayout(false);
            this.gbo_search.PerformLayout();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelsearchresult;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Panel panelsearch;
        private System.Windows.Forms.GroupBox gbo_search;
        private System.Windows.Forms.TextBox txt_num_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_stunum_search;
        private System.Windows.Forms.TextBox txt_phone_search;
        private System.Windows.Forms.TextBox txt_name_search;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label labeltitle;
    }
}