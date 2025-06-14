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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public partial class RestaurantPage : Form
    {
        private bool isMenuInitialized = false;
        private int _userId;
        private Restaurant _restaurant;
        private List<MenuItem> cart = new List<MenuItem>();
        public RestaurantPage(Restaurant restaurant, int userId)
        {
            InitializeComponent();
            _restaurant = restaurant;
            _userId = userId;

            lblName.Text = _restaurant.Name;
            lblAddress.Text = _restaurant.Address;

            LoadMenuItems();
        }
        private List<Restaurant> GetAllRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                // Use correct column names from your database schema
                string query = "SELECT res_id, name, address FROM restaurants";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        restaurants.Add(new Restaurant
                        {
                            // Map to correct database columns
                            RestaurantId = reader.GetInt32("res_id"),
                            Name = reader.GetString("name"),
                            Address = reader.GetString("address")
                        });
                    }
                }
            }
            return restaurants;
        }
        private void LoadMenuItems()
        {
            isMenuInitialized = false;

            var items = new List<MenuItem>();

            using (var db = new DatabaseHelper())
            using (var conn = db.GetConnection())
            {
                conn.Open();
                var sql = @"SELECT menu_id, item_name, price
                    FROM restaurant_menu
                    WHERE restaurant_id = @id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _restaurant.RestaurantId);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            items.Add(new MenuItem
                            {
                                Id = rdr.GetInt32("menu_id"),
                                RestaurantId = _restaurant.RestaurantId,
                                ItemName = rdr.GetString("item_name"),
                                Price = rdr.GetDecimal("price")
                            });
                        }
                    }
                }
            }

            menu_items.DataSource = items;
            menu_items.DisplayMember = "DisplayText";

            isMenuInitialized = true;
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
            ReviewsCus reviewsCus = new ReviewsCus();
            reviewsCus.Show();
            this.Close();
        }

        private void plc_odr_btn_Click(object sender, EventArgs e)
        {
            new cartpage(_userId).Show();
            Close();
        }

        private void menu_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isMenuInitialized) return;

            if (menu_items.SelectedItem is MenuItem selectedItem)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Enter quantity for {selectedItem.ItemName}:", "Quantity", "1");

                if (int.TryParse(input, out int quantity) && quantity > 0)
                {
                    Cart.AddItem(
                        selectedItem.ItemName,
                        selectedItem.Price,
                        _restaurant.RestaurantId,
                        quantity
                    );

                    MessageBox.Show($"{quantity} x {selectedItem.ItemName} added to cart.");
                }
                else
                {
                    MessageBox.Show("Invalid quantity.");
                }
                menu_items.ClearSelected();
            }
        }

    }
}
