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
    public partial class CustomerProfile : Form
    {
        public CustomerProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfileCus editProfileCus = new EditProfileCus();
            editProfileCus.Show();
            this.Close();
        }

        private void cus_log_out_btn_Click(object sender, EventArgs e)
        {
            Handiyen handiyen = new Handiyen();
            handiyen.Show();
            this.Close();
        }

        private void Trck_ord_btn_Click(object sender, EventArgs e)
        {
            trackoder trackOrder = new trackoder();
            trackOrder.Show();
            this.Close();
        }
    }
}
