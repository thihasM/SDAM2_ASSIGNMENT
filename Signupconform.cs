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
using System.Transactions;
using System.Windows.Forms;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public partial class Signupconform : Form
    {
        public Signupconform()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void signup_res_btn_Click(object sender, EventArgs e)
        {

        }

        private void signup_con_btn_Click(object sender, EventArgs e)
        {
            ///input collection:
            string name = sign_con_name_txtb.Text.Trim();
            string username = sign_con_uname_txtb.Text.Trim();
            string dob = sign_con_bday_txtb.Value.ToString("yyyy-MM-dd");
            string email = sign_con_email_txtb.Text.Trim();
            string phone = sign_con_pnum_txtb.Text.Trim();
            string password = sign_con_pass_txtb.Text.Trim();
            string confirmPassword = sign_con_conpass_txtb.Text.Trim();
            string accountType = "Customer";

            // Regex patterns:
            bool nameValid = Regex.IsMatch(name, @"^[a-zA-Z ]+$");
            bool usernameValid = Regex.IsMatch(username, @"^[a-zA-Z0-9]+$");
            bool phoneValid = Regex.IsMatch(phone, @"^\d{10}$");

            //input validators:
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(dob) || string.IsNullOrWhiteSpace(email) ||
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
                MessageBox.Show("Username must contain only letters and numbers (no spaces or special characters).");
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

                // pushing data into users table in database:
                string insertUserQuery = @"
                    INSERT INTO users 
                        (username, password, name, account_type) 
                    VALUES 
                        (@username, @password, @name, @account_type);";

                MySqlCommand cmd = new MySqlCommand(insertUserQuery, conn, transaction);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@account_type", accountType); // make sure this is a string
                cmd.ExecuteNonQuery();

                long userId = cmd.LastInsertedId;

                // pushing data into consumers table in database:
                string insertConsumerQuery = @"
                    INSERT INTO consumers 
                        (user_id, name, email, phone) 
                    VALUES 
                        (@user_id, @name, @email, @phone);";

                MySqlCommand cmd2 = new MySqlCommand(insertConsumerQuery, conn, transaction);
                cmd2.Parameters.AddWithValue("@user_id", userId);
                cmd2.Parameters.AddWithValue("@username", username);
                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.Parameters.AddWithValue("@email", email);
                cmd2.Parameters.AddWithValue("@phone", phone);
                cmd2.Parameters.AddWithValue("@dob", dob);
                cmd2.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Signup successful! enjoy shoping.");
                conn.Close();
            }

        }

        private void signup_con_bck_btn_Click(object sender, EventArgs e)
        {
            Signupselector signupselector = new Signupselector();
            signupselector.Show();
            this.Close();   
        }
    }
}
