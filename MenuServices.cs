using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class MenuServices
    {
        private DatabaseHelper _db;

        public MenuServices(DatabaseHelper db)
        {
            _db = db;
        }
        public void AddMenuItem(MenuItem item)
        {
            using (var conn = _db.GetConnection())
            {
                string query = "INSERT INTO restaurant_menu (restaurant_id, item_name, price) VALUES (@rid, @name, @price)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rid", item.RestaurantId);
                cmd.Parameters.AddWithValue("@name", item.ItemName);
                cmd.Parameters.AddWithValue("@price", item.Price);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<MenuItem> GetMenuByRestaurant(int restaurantId)
        {
            List<MenuItem> items = new List<MenuItem>();

            using (var conn = _db.GetConnection())
            {
                string query = "SELECT menu_id, restaurant_id, item_name, price FROM restaurant_menu WHERE restaurant_id = @rid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rid", restaurantId);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //items.Add(new MenuItem
                        //{
                        //    MenuId = reader.GetInt32("menu_id"),
                        //    RestaurantId = reader.GetInt32("restaurant_id"),
                        //    ItemName = reader.GetString("item_name"),
                        //    Price = reader.GetDecimal("price")
                        //});
                    }
                }
            }

            return items;
        }

    }
}
