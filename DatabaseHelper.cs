using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public class DatabaseHelper
    {
        private string connectionString = "Server=localhost;Database=sdam_2;Uid=root;Pwd=;";
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
        public void TestConnection()
        {
            DatabaseHelper db = new DatabaseHelper();
            MySqlConnection conn = db.GetConnection();

            try
            {
                conn.Open();
                MessageBox.Show("Connection successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
