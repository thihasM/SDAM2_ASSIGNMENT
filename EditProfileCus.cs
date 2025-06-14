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
    public partial class EditProfileCus : Form
    {
        private int _userId;
        public EditProfileCus(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void user_back_btn_Click(object sender, EventArgs e)
        {
            CustomerProfile profile = new CustomerProfile(_userId);
            profile.Show();
            this.Close();
        }

        private void EditProfileCus_Load(object sender, EventArgs e)
        {

        }
    }
}
