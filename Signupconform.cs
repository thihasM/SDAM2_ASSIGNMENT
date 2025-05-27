using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public partial class Signupconform : Form
    {
        public Signupconform()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void signup_res_btn_Click(object sender, EventArgs e)
        {

        }

        private void signup_con_btn_Click(object sender, EventArgs e)
        {

        }

        private void signup_con_bck_btn_Click(object sender, EventArgs e)
        {
            Signupselector signupselector = new Signupselector();
            signupselector.Show();
            this.Close();   
        }
    }
}
