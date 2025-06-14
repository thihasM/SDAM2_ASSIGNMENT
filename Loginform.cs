using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public partial class Loginform : Form
    {
        

        public Loginform()
        {
            InitializeComponent();
        }

        private void login_bck_btn_Click(object sender, EventArgs e)
        {
            Handiyen handiyen = new Handiyen();
            handiyen.Show();
            this.Hide();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = log_usen_txtb.Text.Trim();
            string password = log_pass_txtb.Text.Trim();

            User authenticatedUser = ValidateLogin(username, password);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }
            if (authenticatedUser != null)
            {
                if (authenticatedUser.AccountType == "Restaurant")
                {
                    Restaurant restaurant = GetRestaurantByUserId(authenticatedUser.UserId);
                    if (restaurant != null)
                    {
                        authenticatedUser.RestaurantId = restaurant.RestaurantId;
                    }
                    else
                    {
                        MessageBox.Show("Restaurant profile not found");
                        return;
                    }
                }

                // cur user set
                UserManager.SetCurrentUser(authenticatedUser);

                // Redir
                if (authenticatedUser.AccountType == "Restaurant")
                {
                    Restaurantinterface restaurantInterface = new Restaurantinterface();
                    restaurantInterface.Show();
                }
                else
                {
                    Customerinterface customerInterface = new Customerinterface();
                    customerInterface.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private User ValidateLogin(string username, string password)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty");
                return null;
            }

            try
            {
                using (var db = new DatabaseHelper())
                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT id, username, name, account_type, password 
                           FROM users 
                           WHERE username = @username";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (password == reader.GetString("password"))
                                {
                                    return new User
                                    {
                                        UserId = reader.GetInt32("id"),
                                        Username = reader.GetString("username"),
                                        Name = reader.GetString("name"),
                                        AccountType = reader.GetString("account_type")
                                    };
                                }
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}");
                return null;
            }
        }
        private Restaurant GetRestaurantByUserId(int userId)
        {
            try
            {
                using (var db = new DatabaseHelper())
                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT res_id, name, address, email, phone, username 
                            FROM restaurants 
                            WHERE user_id = @user_id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", userId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Restaurant
                                {
                                    RestaurantId = reader.GetInt32("res_id"),
                                    UserId = userId,
                                    Name = reader.GetString("name"),
                                    Address = reader.GetString("address"),
                                    Email = reader.IsDBNull("email") ? null : reader.GetString("email"),
                                    Phone = reader.IsDBNull("phone") ? null : reader.GetString("phone"),
                                    Username = reader.IsDBNull("username") ? null : reader.GetString("username")
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching restaurant: {ex.Message}");
                return null;
            }
        }
    }
}