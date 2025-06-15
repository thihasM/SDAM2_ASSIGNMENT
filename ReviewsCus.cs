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
    public partial class ReviewsCus : Form
    {
        public ReviewsCus()
        {
            InitializeComponent();
        }

        private void user_back_btn_Click(object sender, EventArgs e)
        {
            Customerinterface customerInterface = new Customerinterface();
            customerInterface.Show();
            this.Close();
        }

        private void ReviewsCus_Load(object sender, EventArgs e)
        {

        }
    }
}
