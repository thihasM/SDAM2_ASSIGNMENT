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
        public Customerinterface()
        {
            InitializeComponent();
        }

        private void Customerinterface_Load(object sender, EventArgs e)
        {
            customer_intf_lb.DataSource = GetAllRestaurants();
            customer_intf_lb.DisplayMember = "Name";
            // Removed: customer_intf_lb = true;
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
            if (!isListBoxLoaded) return;

            if (customer_intf_lb.SelectedItem is Restaurant selectedRestaurant)
            {
                RestaurantPage page = new RestaurantPage(selectedRestaurant);
                page.Show();
            }
        }
    }
}
