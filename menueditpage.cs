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
    public partial class menueditpage : Form
    {
        private Restaurant _restaurant;
        public menueditpage(Restaurant restaurant)
        {
            InitializeComponent();
            _restaurant = restaurant;
            LoadMenuItems();

            menu_edit_lb.SelectedIndexChanged += menu_edit_lb_SelectedIndexChanged;
        }

        public menueditpage()
        {
            InitializeComponent();
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            ResturantProfile resturantProfile = new ResturantProfile();
            resturantProfile.Show();
            this.Close();
        }

        private void menu_delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to delete the entire menu for this restaurant?",
               "Confirm Delete",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                DeleteMenuForRestaurant(_restaurant.RestaurantId);
                LoadMenuItems();
                MessageBox.Show("Menu deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LoadMenuItems()
        {
            try
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

                menu_edit_lb.DataSource = null;

                if (menuItems.Count == 0)
                {
                    MessageBox.Show("There are no menu items currently available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    menu_edit_lb.DataSource = menuItems;
                    menu_edit_lb.DisplayMember = "ItemName";
                    menu_edit_lb.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menueditpage_Load(object sender, EventArgs e)
        {
            
        }

        private void menu_edit_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu_edit_lb.SelectedItem is MenuItem selectedItem)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{selectedItem.ItemName}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteMenuItem(selectedItem.Id);
                    LoadMenuItems();
                    MessageBox.Show("Item deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void DeleteMenuItem(int itemId)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM restaurant_menu WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", itemId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteMenuForRestaurant(int restaurantId)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM restaurant_menu WHERE restaurant_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", restaurantId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting menu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void add_item_btn_Click(object sender, EventArgs e)
        {
            string itemName = Itm_name_input_txt.Text.Trim();
            string priceText = Itm_price_input_txt.Text.Trim();

            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(priceText))
            {
                MessageBox.Show("Please enter both item name and price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Invalid price format. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO restaurant_menu (restaurant_id, item_name, price) VALUES (@restId, @itemName, @price)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@restId", _restaurant.RestaurantId);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems(); // Refresh ListBox
                Itm_name_input_txt.Clear();
                Itm_price_input_txt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Itm_name_input_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
