using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public partial class Signupresform : Form
    {
        private int _userId;

        public Signupresform(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signup_res_bck_btn_Click(object sender, EventArgs e)
        {
            Signupselector signupselector = new Signupselector();
            signupselector.Show();
            this.Close();
        }

        private void signup_res_btn_Click(object sender, EventArgs e)
        {
            //input collection:
            string name = sign_res_name_txtb.Text.Trim();
            string address = sign_res_add_txtb.Text.Trim();
            string username = sign_res_uname_txtb.Text.Trim();
            string email = sign_res_email_txtb.Text.Trim();
            string phone = sign_res_pnum_txtb.Text.Trim();
            string password = sign_res_pass_txtb.Text.Trim();
            string confirmPassword = sign_res_conpass_txtb.Text.Trim();
            string accountType = "Restaurant";

            // Regex patterns:
            bool nameValid = Regex.IsMatch(name, @"^[a-zA-Z ]+$");
            bool usernameValid = Regex.IsMatch(username, @"^[a-zA-Z0-9]+$");
            bool phoneValid = Regex.IsMatch(phone, @"^\d{10}$");

            //input validators:

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (!nameValid)
            {
                MessageBox.Show("Name must contain only letters and spaces.");
                return;
            }
            if (!usernameValid)
            {
                MessageBox.Show("Username must contain only letters and numbers.");
                return;
            }
            if (!phoneValid)
            {
                MessageBox.Show("Phone number must be exactly 10 digits.");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Pushing data into users table
                    string insertUserQuery = @"
                        INSERT INTO users (username, password, name, account_type)
                        VALUES (@username, @password, @name, @account_type)";

                    MySqlCommand cmdUser = new MySqlCommand(insertUserQuery, conn, transaction);
                    cmdUser.Parameters.AddWithValue("@username", username);
                    cmdUser.Parameters.AddWithValue("@password", password);
                    cmdUser.Parameters.AddWithValue("@name", name);
                    cmdUser.Parameters.AddWithValue("@account_type", accountType);
                    cmdUser.ExecuteNonQuery();

                    long userId = cmdUser.LastInsertedId;

                    // Pushing data into restaurants table AND GETTING RES_ID
                    string insertRestaurantQuery = @"
                        INSERT INTO restaurants (user_id, name, address, email, phone, username)
                        VALUES (@user_id, @name, @address, @email, @phone, @username);
                        SELECT LAST_INSERT_ID();";

                    MySqlCommand cmdRest = new MySqlCommand(insertRestaurantQuery, conn, transaction);
                    cmdRest.Parameters.AddWithValue("@user_id", userId);
                    cmdRest.Parameters.AddWithValue("@name", name);
                    cmdRest.Parameters.AddWithValue("@address", address);
                    cmdRest.Parameters.AddWithValue("@email", email);
                    cmdRest.Parameters.AddWithValue("@phone", phone);
                    cmdRest.Parameters.AddWithValue("@username", username);

                    transaction.Commit();
                    MessageBox.Show("Restaurant registration successful!");
                    Restaurantinterface restaurantInterface = new Restaurantinterface();
                    restaurantInterface.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred during registration: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Signupresform_Load(object sender, EventArgs e)
        {

        }
    }
}

