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
    public partial class cartpage : Form
    {
        private int _userId;
        public cartpage(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void cartpage_Load(object sender, EventArgs e)
        {

        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(_userId);
            payment.Show();
            this.Close();
        }

        private void user_back_btn_Click(object sender, EventArgs e)
        {
            Customerinterface customerInterface = new Customerinterface();
            customerInterface.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cart_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
