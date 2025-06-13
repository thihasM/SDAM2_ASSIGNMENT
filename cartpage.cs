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
        public cartpage()
        {
            InitializeComponent();

        }

        private void cartpage_Load(object sender, EventArgs e)
        {

        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
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
    }
}
