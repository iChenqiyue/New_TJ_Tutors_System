using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_TJ_Tutors_System
{
    public partial class tutor_all : Form
    {
        public tutor_all()
        {
            InitializeComponent();
        }
        //打开子窗口
        private Form activeform = null;
        private void openchidform(Form childform, Panel childpanel)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childpanel.Controls.Add(childform);
            childpanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        //


        private void button3_Click(object sender, EventArgs e)
        {
            if (paneltutoring.Visible == false)
                paneltutoring.Visible = true;
            else
                paneltutoring.Visible = false;
        }

        private void tutor_all_Load(object sender, EventArgs e)
        {
            paneltutoring.Visible = false;
            openchidform(new tutor_search(), panelleft);
        }
    }
}
