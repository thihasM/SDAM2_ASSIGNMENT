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
    public partial class Payment : Form
    {
        private int _userId;
        public Payment(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_home_btn_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void placeorder_btn_Click(object sender, EventArgs e)
        {
            trackoder trackOrder = new trackoder(_userId);
            trackOrder.Show();
            this.Close();
        }
    }
}
