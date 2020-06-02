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
    public partial class database : Form
    {
        public database()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            paneldatabase.Visible = true;
            paneltoexcel.Visible = false;
        }

        private void btn_forms_Click(object sender, EventArgs e)
        {
            paneldatabase.Visible = false;
            paneltoexcel.Visible = true;
        }
    }
}
