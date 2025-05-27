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
    public partial class Signupselector : Form
    {
        public Signupselector()
        {
            InitializeComponent();
        }

        private void signup_bck_btn_Click(object sender, EventArgs e)
        {
            Handiyen handiyen = new Handiyen();
            handiyen.Show();
            this.Close();
        }

        private void sign_res_btn_Click(object sender, EventArgs e)
        {
            Signupresform signupresform = new Signupresform();
            signupresform.Show();
            this.Close();
        }

        private void sign_con_btn_Click(object sender, EventArgs e)
        {
            Signupconform signupconform = new Signupconform();
            signupconform.Show();
            this.Close();
        }
    }
}
