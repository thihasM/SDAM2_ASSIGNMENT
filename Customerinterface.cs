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
    public partial class Customerinterface : Form
    {
        private bool isListBoxLoaded = false;
        private int _userId;
        public Customerinterface()
        {
            InitializeComponent();
            var currentUser = UserManager.GetCurrentUser();
            if (currentUser != null)
            {
                _userId = currentUser.UserId;
            }
            else
            {
                MessageBox.Show("No user is logged in.");
                this.Close();
            }
        }

        private void Customerinterface_Load(object sender, EventArgs e)
        {
            var restaurants = GetAllRestaurants();

            if (restaurants.Count == 0)
            {
                MessageBox.Show("There are no restaurants currently available.",
                                "Notice",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                customer_intf_lb.DataSource = null;
                return;
            }

            customer_intf_lb.DataSource = restaurants;
            customer_intf_lb.DisplayMember = "Name";

            isListBoxLoaded = true;

            var currentUser = UserManager.GetCurrentUser();
            if (currentUser != null)
            {
                lblWelcome.Text = $"Welcome, {currentUser.Username}!";
            }
            else
            {
                lblWelcome.Text = "Welcome!";
            }
        }
        private List<Restaurant> GetAllRestaurants()
        {
            var list = new List<Restaurant>();

            using (var db = new DatabaseHelper())
            using (var conn = db.GetConnection())
            {
                conn.Open();

                const string sql = "SELECT res_id, name, address FROM restaurants";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new Restaurant
                        {
                            RestaurantId = rdr.GetInt32("res_id"),
                            Name = rdr.GetString("name"),
                            Address = rdr.GetString("address")
                        });
                    }
                }
            }
            return list;
        }

        private void customer_intf_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isListBoxLoaded) return;          

            if (customer_intf_lb.SelectedItem is Restaurant r)
            {
                new RestaurantPage(r, _userId).Show();
                Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            new CustomerProfile(_userId).Show();
            Close();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            new cartpage(_userId).Show();
            Close();
        }
    }
}
