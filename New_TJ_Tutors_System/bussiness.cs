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
    

    public partial class bussiness : Form
    {
        public string tutor_state1, remarks1;

        public bussiness()
        {
            InitializeComponent();
        }

        private void btn_bus_Click(object sender, EventArgs e)
        {
            //为字段赋值
            tutor_state1 = cbo_tutor_state.SelectedItem.ToString();
            remarks1 = txt_remarks.Text.Trim();
        }
    }
}
