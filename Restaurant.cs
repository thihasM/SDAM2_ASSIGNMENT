using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return Name;
        }
        private void LoadRestaurants()
        {
            List<Restaurant> restaurants = new List<Restaurant>();

            using (MySqlConnection conn = new MySqlConnection("your_connection_string"))
            {
                conn.Open();
                string query = "SELECT id, name, address FROM restaurant"; // match your table & column names
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Restaurant r = new Restaurant
                        {
                            RestaurantId = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Address = reader.GetString("address")
                        };
                        restaurants.Add(r);
                    }
                }
            }
        }
    }
}
