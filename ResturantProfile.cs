using MySql.Data.MySqlClient;
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
    public partial class ResturantProfile : Form
    {
        private int _userId;
        public ResturantProfile(int userId)
        {
            InitializeComponent();
            _userId = userId;
            LoadRestaurantData();
        }
        private void LoadRestaurantData()
        {
            using (var db = new DatabaseHelper())
            {
                var restaurant = db.GetRestaurantByUserId(_userId);
                if (restaurant != null)
                {
                    
                    lblRestaurantName.Text = restaurant.Name;
                }
            }
        }
        private void ResturantProfile_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void res_edit_food_menu_btn_Click(object sender, EventArgs e)
        {
            menueditpage menuEditPage = new menueditpage(_userId);
            menuEditPage.Show();
            this.Close();
        }

        private void res_back_btn_Click(object sender, EventArgs e)
        {
            Restaurantinterface restaurantInterface = new Restaurantinterface();
            restaurantInterface.Show();
            this.Close();
        }

        private void res_log_out_btn_Click(object sender, EventArgs e)
        {
            Handiyen handiyen = new Handiyen();
            handiyen.Show();
            this.Close();
        }

        private void res_delete_account_btn_Click(object sender, EventArgs e)
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

        private void res_edit_btn_Click(object sender, EventArgs e)
        {
            EditProfilRes editProfilRes = new EditProfilRes(_userId);
            editProfilRes.Show();
            this.Close();
        }
    }
}
