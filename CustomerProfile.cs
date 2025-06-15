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
        private int _userId;
        public CustomerProfile(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfileCus editProfileCus = new EditProfileCus(_userId);
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
            trackoder trackOrder = new trackoder(_userId);
            trackOrder.Show();
            this.Close();
        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {

        }

        private void cus_delete_account_btn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.",
                                 "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var user = UserManager.GetCurrentUser();
                if (user == null)
                {
                    MessageBox.Show("You are not logged in.");
                    return;
                }

                using (var db = new DatabaseHelper())
                {
                    bool success = db.DeleteUser(user.UserId, user.AccountType);
                    if (success)
                    {
                        MessageBox.Show("Your account has been deleted.");
                        UserManager.ClearCurrentUser();
                        new Handiyen().Show();
                        this.Close();
                    }
                }
            }

        }

        private void cus_pro_go_back_btn_Click(object sender, EventArgs e)
        {
            Customerinterface customerInterface = new Customerinterface();
            customerInterface.Show();
            this.Close();
        }
    }
}
