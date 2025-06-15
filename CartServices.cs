using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public static class CartServices
    {
        public static void SaveCartToDatabase(int customerId) 
        {
            using (var db = new DatabaseHelper()) 
            {
                using (var conn = db.GetConnection()) 
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction()) 
                    {
                        try 
                        {
                            int restaurantId = Cart.CurrentRestaurantId;
                            int cartId;
                            string insertCartQuery = @"
                        INSERT INTO Cart (customer_id, restaurant_id, status, created_at)
                        VALUES (@customer_id, @restaurant_id, 'Active', NOW());
                        SELECT LAST_INSERT_ID();";

                            using (var cmd = new MySqlCommand(insertCartQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@customer_id", customerId);
                                cmd.Parameters.AddWithValue("@restaurant_id", restaurantId);

                                cartId = Convert.ToInt32(cmd.ExecuteScalar());
                            }
                            foreach (var item in Cart.Items)
                            {
                                string insertItemQuery = @"
                            INSERT INTO CartItem (cart_id, item_name, price, quantity)
                            VALUES (@cart_id, @item_name, @price, @quantity);";

                                using (var cmd = new MySqlCommand(insertItemQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@cart_id", cartId);
                                    cmd.Parameters.AddWithValue("@item_name", item.ItemName);
                                    cmd.Parameters.AddWithValue("@price", item.Price);
                                    cmd.Parameters.AddWithValue("@quantity", item.Quantity);

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            Cart.ClearCart();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception("Failed to save cart: " + ex.Message);
                        }
                    }
                }
            }
        }
        public static int PlaceOrder(int customerId, string deliveryLocation)
        {
            // Validate inputs
            int cusId = UserManager.GetCurrentCustomerId(); 
            if (cusId <= 0)
            {
                Console.WriteLine("Invalid customer ID. Cannot place order.");
                return cusId;
            }

            if (string.IsNullOrWhiteSpace(deliveryLocation))
            {
                throw new ArgumentException("Delivery location cannot be empty", nameof(deliveryLocation));
            }

            if (Cart.Items.Count == 0)
            {
                throw new InvalidOperationException("Cannot place an empty order");
            }

            // Validate customer exists
            if (!CustomerExists(customerId))
            {
                throw new Exception($"Customer with ID {customerId} does not exist in the database");
            }

            // Validate restaurant exists
            if (!RestaurantExists(Cart.CurrentRestaurantId))
            {
                throw new Exception($"Restaurant with ID {Cart.CurrentRestaurantId} does not exist");
            }

            using (var db = new DatabaseHelper())
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Create cart record
                        int cartId = CreateCartRecord(conn, transaction, customerId, Cart.CurrentRestaurantId);

                        // Create order record
                        int orderId = CreateOrderRecord(conn, transaction, customerId, cartId, deliveryLocation);

                        // Add all cart items
                        AddCartItems(conn, transaction, cartId);

                        transaction.Commit();
                        Cart.ClearCart();
                        return orderId;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Failed to place order. Please try again.", ex);
                    }
                }
            }
        }

        private static bool CustomerExists(int customerId)
        {
            using (var db = new DatabaseHelper())
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM consumers WHERE cus_id = @customer_id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_id", customerId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        private static bool RestaurantExists(int restaurantId)
        {
            using (var db = new DatabaseHelper())
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM restaurants WHERE res_id = @restaurant_id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@restaurant_id", restaurantId);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }
        private static int CreateCartRecord(MySqlConnection conn, MySqlTransaction transaction, int customerId, int restaurantId)
        {
            string insertCartQuery = @"
                INSERT INTO Cart (customer_id, restaurant_id, status, created_at)
                VALUES (@customer_id, @restaurant_id, 'Active', NOW());
                SELECT LAST_INSERT_ID();";
            using (var cmd = new MySqlCommand(insertCartQuery, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@customer_id", customerId);
                cmd.Parameters.AddWithValue("@restaurant_id", restaurantId);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private static int CreateOrderRecord(MySqlConnection conn, MySqlTransaction transaction, int customerId, int cartId, string deliveryLocation)
        {
            string query = @"
        INSERT INTO orders (customer_id, cart_id, delivery_location, status)
        VALUES (@customer_id, @cart_id, @location, 'Pending');
        SELECT LAST_INSERT_ID();";

            using (var cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@customer_id", customerId);
                cmd.Parameters.AddWithValue("@cart_id", cartId);
                cmd.Parameters.AddWithValue("@location", deliveryLocation);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        private static void AddCartItems(MySqlConnection conn, MySqlTransaction transaction, int cartId)
        {
            foreach (var item in Cart.Items)
            {
                // Get menu_id for the item
                int menuId = GetMenuId(conn, transaction, item.ItemName, item.RestaurantId);

                // Insert cart item
                string query = @"
            INSERT INTO cart_item (cart_id, menu_id, quantity)
            VALUES (@cart_id, @menu_id, @quantity)";

                using (var cmd = new MySqlCommand(query, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@cart_id", cartId);
                    cmd.Parameters.AddWithValue("@menu_id", menuId);
                    cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private static int GetMenuId(MySqlConnection conn, MySqlTransaction transaction, string itemName, int restaurantId)
        {
            string query = @"
        SELECT menu_id FROM restaurant_menu 
        WHERE restaurant_id = @restaurant_id AND item_name = @item_name
        LIMIT 1";

            using (var cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@restaurant_id", restaurantId);
                cmd.Parameters.AddWithValue("@item_name", itemName);
                var result = cmd.ExecuteScalar();

                if (result == null)
                {
                    throw new Exception($"Menu item '{itemName}' not found for restaurant {restaurantId}");
                }

                return Convert.ToInt32(result);
            }
        }
    }
}
