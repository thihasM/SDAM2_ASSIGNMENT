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
        public ResturantProfile()
        {
            InitializeComponent();
        }

        private void ResturantProfile_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void res_edit_food_menu_btn_Click(object sender, EventArgs e)
        {
            menueditpage menuEditPage = new menueditpage();
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
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete your profile? This action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
                return;

            //int userId = loggedInUser.Id; // Replace with your actual user object
            //string role = loggedInUser.Role; // "restaurant" or "consumer"

            DatabaseHelper db = new DatabaseHelper();
            using (MySqlConnection conn = new MySqlConnection("your_connection_string"))
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                MySqlTransaction transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transaction;

                //try
                //{
                //    if (role == "restaurant")
                //    {
                //        // Delete from menu first
                //        cmd.CommandText = "DELETE FROM restaurant_menu WHERE user_id = @user_id";
                //        cmd.Parameters.AddWithValue("@uid", userId);
                //        cmd.ExecuteNonQuery();

                //        // Delete from restaurant
                //        cmd.CommandText = "DELETE FROM restaurant WHERE id = @user_id";
                //        cmd.ExecuteNonQuery();
                //    }
                //    else if (role == "consumer")
                //    {
                //        cmd.CommandText = "DELETE FROM consumers WHERE id = @user_id";
                //        cmd.ExecuteNonQuery();
                //    }

                //    // Delete from users table
                //    cmd.CommandText = "DELETE FROM users WHERE id = @user_id";
                //    cmd.ExecuteNonQuery();

                //    transaction.Commit();
                //    MessageBox.Show("Your profile has been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    // Optionally, return to login form or close app
                //    Application.Restart(); // or go back to login form
                //}
                //catch (Exception ex)
                //{
                //    transaction.Rollback();
                //    MessageBox.Show("Error deleting profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }



        }

        private void res_edit_btn_Click(object sender, EventArgs e)
        {
            EditProfilRes editProfilRes = new EditProfilRes();
            editProfilRes.Show();
            this.Close();
        }
    }
}
