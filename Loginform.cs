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
            string username = log_usen_txtb.Text;
            string password = log_pass_txtb.Text;

            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password = @password";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["id"]);
                            string accountType = reader["account_type"].ToString().ToLower();

                            // Set current user
                            var loggedInUser = new User(userId, username, accountType);
                            UserManager.SetCurrentUser(loggedInUser);

                            if (accountType == "customer")
                            {
                                Customerinterface customerInterface = new Customerinterface();
                                customerInterface.Show();
                            }
                            else if (accountType == "restaurant")
                            {
                                Restaurantinterface restaurantInterface = new Restaurantinterface();
                                restaurantInterface.Show();
                            }

                            this.Hide(); 
                        }
                        else
                        {
                            MessageBox.Show("Invalid login.");
                        }

                    }
                }
            }

        }
    }
}
