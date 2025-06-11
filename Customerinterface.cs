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
        public Customerinterface()
        {
            InitializeComponent();
        }

        private void Customerinterface_Load(object sender, EventArgs e)
        {
            List<Restaurant> restaurants = GetAllRestaurants();

            if (restaurants.Count == 0)
            {
                MessageBox.Show("There are no restaurants currently available.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                customer_intf_lb.DataSource = null;
            }
            else
            {
                customer_intf_lb.DataSource = restaurants;
                customer_intf_lb.DisplayMember = "Name";
                isListBoxLoaded = true;
            }
        }
        private List<Restaurant> GetAllRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, name, address FROM restaurants";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        restaurants.Add(new Restaurant
                        {
                            RestaurantId = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Address = reader.GetString("address")
                        });
                    }
                }
                conn.Close();
            }
            return restaurants;
        }

        private void customer_intf_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isListBoxLoaded && customer_intf_lb.SelectedItem is Restaurant selectedRestaurant)
            {
                RestaurantPage page = new RestaurantPage(selectedRestaurant);
                page.Show();
            }
        }
    }
}
