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
        public static int SaveCartToDatabase(int customerId, string deliveryLocation)
        {
            int orderId = 0;
            using (var db = new DatabaseHelper())
            using (var conn = db.GetConnection())
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string orderQuery = @"INSERT INTO orders (customer_id, restaurant_id, delivery_location)
                                      VALUES (@cust_id, @res_id, @location); SELECT LAST_INSERT_ID();";
                        using (var cmd = new MySqlCommand(orderQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@cust_id", customerId);
                            cmd.Parameters.AddWithValue("@res_id", Cart.CurrentRestaurantId);
                            cmd.Parameters.AddWithValue("@location", deliveryLocation);
                            orderId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        foreach (var item in Cart.Items)
                        {
                            string itemQuery = @"INSERT INTO cartitem (cart_id, item_name, price, quantity)
                                         VALUES (@order_id, @item_name, @price, @quantity)";
                            using (var cmd = new MySqlCommand(itemQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@order_id", orderId);
                                cmd.Parameters.AddWithValue("@item_name", item.ItemName);
                                cmd.Parameters.AddWithValue("@price", item.Price);
                                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        Cart.ClearCart();
                        return orderId;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
