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
    public partial class RestaurantPage : Form
    {
        private Restaurant _restaurant;
        private List<MenuItem> cart = new List<MenuItem>();
        public RestaurantPage(Restaurant restaurant)
        {
            InitializeComponent();
            _restaurant = restaurant;
            lblName.Text = _restaurant.Name;
            lblAddress.Text = _restaurant.Address;

            LoadMenuItems();
        }
        private void LoadMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, item_name, price FROM restaurant_menu WHERE restaurant_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _restaurant.RestaurantId);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        menuItems.Add(new MenuItem
                        {
                            Id = reader.GetInt32("id"),
                            ItemName = reader.GetString("item_name"),
                            Price = reader.GetDecimal("price")
                        });
                    }
                }
                conn.Close();
            }

            if (menuItems.Count == 0)
            {
                menu_items.DataSource = null;
                MessageBox.Show("There are no menu items available for this restaurant.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                menu_items.DataSource = menuItems;
                menu_items.DisplayMember = "ItemName";
            }
        }

        private void RestaurantPage_Load(object sender, EventArgs e)
        {
            lblName.Text = _restaurant.Name;
            lblAddress.Text = _restaurant.Address;
        }

        private void gobck_btn_Click(object sender, EventArgs e)
        {
            Customerinterface customerInterface = new Customerinterface();
            customerInterface.Show();
            this.Close();
        }

        private void cus_profile_btn_Click(object sender, EventArgs e)
        {
            CustomerProfile customerProfile = new CustomerProfile();
            customerProfile.Show();
            this.Close();
        }

        private void plc_odr_btn_Click(object sender, EventArgs e)
        {

        }

        private void menu_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu_items.SelectedItem is MenuItem selectedItem)
            {
                cart.Add(selectedItem);
                MessageBox.Show($"{selectedItem.ItemName} added to cart.");
            }
        }
        
    }
}
