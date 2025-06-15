using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class DatabaseHelper : IDisposable
    {
        private readonly string connectionString = "Server=localhost;Database=sdam_2;Uid=root;Pwd=;";
        private MySqlConnection _connection;
        private bool _disposed = false;

        public MySqlConnection GetConnection()
        {
            // Return new connection each time (better for thread safety)
            return new MySqlConnection(connectionString);
        }

        public void TestConnection()
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
                // No need for finally/Close - using statement handles it
            }
        }

        public Restaurant GetRestaurantByUserId(int userId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT res_id, user_id, name, address, email, phone, username 
                               FROM restaurants 
                               WHERE user_id = @user_id";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Restaurant
                            {
                                RestaurantId = reader.GetInt32("res_id"),
                                UserId = reader.GetInt32("user_id"),
                                Name = reader.GetString("name"),
                                Address = reader.GetString("address"),
                                Email = reader.IsDBNull(reader.GetOrdinal("email")) ?
                                        null : reader.GetString("email"),
                                Phone = reader.IsDBNull(reader.GetOrdinal("phone")) ?
                                        null : reader.GetString("phone"),
                                Username = reader.IsDBNull(reader.GetOrdinal("username")) ?
                                          null : reader.GetString("username")
                            };
                        }
                    }
                }
            }
            return null;
        }

        // IDisposable implementation
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_connection != null)
                    {
                        if (_connection.State == System.Data.ConnectionState.Open)
                        {
                            _connection.Close();
                        }
                        _connection.Dispose();
                    }
                }
                _disposed = true;
            }
        }

        ~DatabaseHelper()
        {
            Dispose(false);
        }
        public Customer? GetCustomerByUserId(int userId)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT cus_id, user_id, name FROM consumers WHERE user_id = @user_id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Customer
                            {
                                CustomerId = reader.GetInt32("cus_id"),
                                UserId = reader.GetInt32("user_id"),
                                Name = reader.GetString("name")
                            };
                        }
                    }
                }
            }
            return null;
        }
        public bool DeleteUser(int userId, string accountType)
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string roleTable = accountType == "Restaurant" ? "restaurants" : "consumers";
                        string roleDeleteQuery = $"DELETE FROM {roleTable} WHERE user_id = @userId";
                        using (var roleCmd = new MySqlCommand(roleDeleteQuery, conn, transaction))
                        {
                            roleCmd.Parameters.AddWithValue("@userId", userId);
                            roleCmd.ExecuteNonQuery();
                        }
                        string userDeleteQuery = "DELETE FROM users WHERE id = @userId";
                        using (var userCmd = new MySqlCommand(userDeleteQuery, conn, transaction))
                        {
                            userCmd.Parameters.AddWithValue("@userId", userId);
                            userCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to delete profile: {ex.Message}");
                        return false;
                    }
                }
            }
        }
    }

}
