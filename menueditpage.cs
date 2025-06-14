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

namespace LOGIN_SDAM_ASSIGNMENT
{
    public partial class menueditpage : Form
    {
        private int _userId;
        private int restaurantId;
        private DatabaseHelper db = new DatabaseHelper();
        private MenuItem selectedMenuItem;
        public menueditpage(int userId)
        {
            InitializeComponent();
            _userId = userId;

            // Get restaurant by user ID
            Restaurant restaurant = GetRestaurantByUserId(_userId);

            if (restaurant != null)
            {
                restaurantId = restaurant.RestaurantId;
                lblRestaurantName.Text = $"Restaurant: {restaurantId}";
                LoadMenuItems();
            }
            else
            {
                MessageBox.Show("Restaurant not found!");
                this.Close();
            }
        }

        public menueditpage()
        {
            InitializeComponent();
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            ResturantProfile resturantProfile = new ResturantProfile(_userId);
            resturantProfile.Show();
            this.Close();
        }
        private void ClearInputs()
        {
            Itm_name_input_txt.Text = "";
            Itm_price_input_txt.Text = "";
            selectedMenuItem = null;
        }

        private void menu_delete_btn_Click(object sender, EventArgs e)
        {
            if (selectedMenuItem != null)
            {
                var confirmResult = MessageBox.Show($"Delete '{selectedMenuItem.ItemName}'?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteMenuItem(selectedMenuItem.Id);
                    LoadMenuItems();
                    ClearInputs();
                    menu_delete_btn.Enabled = false;
                    upd_itm_btn.Enabled = false;
                }
            }

        }
        private void DeleteMenuItem(int menuId)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM restaurant_menu WHERE menu_id = @menu_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@menu_id", menuId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadMenuItems()
        {
            menu_edit_lb.Items.Clear();
            List<MenuItem> menuItems = GetMenuItems();

            if (menuItems.Count == 0)
            {
                menu_edit_lb.Items.Add("No items to display");
                menu_delete_btn.Enabled = false;
                upd_itm_btn.Enabled = false;
            }
            else
            {
                foreach (var item in menuItems)
                {
                    menu_edit_lb.Items.Add($"{item.ItemName} - ${item.Price}");
                }
            }
        }
        private List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT menu_id, item_name, price " +
                               "FROM restaurant_menu WHERE restaurant_id = @restaurant_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@restaurant_id", restaurantId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            menuItems.Add(new MenuItem
                            {
                                Id = reader.GetInt32("menu_id"),
                                RestaurantId = restaurantId,
                                ItemName = reader.GetString("item_name"),
                                Price = reader.GetDecimal("price")
                            });
                        }
                    }
                }
            }
            return menuItems;
        }

        private void menueditpage_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void menu_edit_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (menu_edit_lb.SelectedIndex >= 0 &&
                !menu_edit_lb.GetItemText(menu_edit_lb.SelectedItem).Contains("No items"))
            {
                selectedMenuItem = GetMenuItems()[menu_edit_lb.SelectedIndex];
                Itm_name_input_txt.Text = selectedMenuItem.ItemName;
                Itm_price_input_txt.Text = selectedMenuItem.Price.ToString();
                menu_delete_btn.Enabled = true;
                upd_itm_btn.Enabled = true;
            }
        }


        private void add_item_btn_Click(object sender, EventArgs e)
        {
        }

        private void Itm_name_input_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                AddMenuItem(Itm_name_input_txt.Text, decimal.Parse(Itm_price_input_txt.Text));
                LoadMenuItems();
                ClearInputs();
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(Itm_name_input_txt.Text))
            {
                MessageBox.Show("Item name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(Itm_price_input_txt.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AddMenuItem(string itemName, decimal price)
        {

            int currentRestaurantId = restaurantId;

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                // 1. First verify restaurant exists
                string checkQuery = "SELECT COUNT(*) FROM restaurants WHERE res_id = @res_id";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@res_id", currentRestaurantId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("Restaurant not registered! Please register the restaurant first.");
                        return;
                    }
                }

                // 2. Now insert the menu item
                string insertQuery = @"INSERT INTO restaurant_menu (restaurant_id, item_name, price)
                             VALUES (@restaurant_id, @item_name, @price)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@restaurant_id", currentRestaurantId);
                    cmd.Parameters.AddWithValue("@item_name", itemName);
                    cmd.Parameters.AddWithValue("@price", price);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add item");
                    }
                }
            }
        }

        private void upd_itm_btn_Click(object sender, EventArgs e)
        {
            if (selectedMenuItem != null && ValidateInput())
            {
                UpdateMenuItem(selectedMenuItem.Id, Itm_name_input_txt.Text, decimal.Parse(Itm_price_input_txt.Text));
                LoadMenuItems();
                ClearInputs();
                upd_itm_btn.Enabled = false;
                menu_delete_btn.Enabled = false;
            }
        }
        private void UpdateMenuItem(int menuId, string itemName, decimal price)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE restaurant_menu SET item_name = @item_name, price = @price " +
                               "WHERE menu_id = @menu_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@item_name", itemName);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@menu_id", menuId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private Restaurant GetRestaurantByUserId(int userId)
        {
            DatabaseHelper db = new DatabaseHelper();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT res_id, name, address, email, phone, username " +
                              "FROM restaurants WHERE user_id = @user_id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

