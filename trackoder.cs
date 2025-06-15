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
    public partial class trackoder : Form
    {
        private int _userId;
        private int? _orderId;
        public trackoder(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackoder_Load(object sender, EventArgs e)
        {
            if (_orderId != null)
            {
                lblWelcome.Text = $"Order Number: {_orderId}!";
            }
            else
            {
                lblWelcome.Text = "Welcome!";
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Customerinterface customerinterface = new Customerinterface();
            customerinterface.Show();
            this.Close();
        }
    }
}
