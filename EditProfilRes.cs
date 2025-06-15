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
    public partial class EditProfilRes : Form
    {
        private int _userId;
        public EditProfilRes(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userId = UserManager.GetCurrentRestaurantId();
            using (DatabaseHelper db = new DatabaseHelper())
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                List<string> updates = new List<string>();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (!string.IsNullOrWhiteSpace(res_phone_number_edit_textbox.Text))
                {
                    updates.Add("phone = @phone");
                    cmd.Parameters.AddWithValue("@phone", res_phone_number_edit_textbox.Text);
                }
                if (!string.IsNullOrWhiteSpace(res_email.Text))
                {
                    updates.Add("email = @email");
                    cmd.Parameters.AddWithValue("@email", res_email.Text);
                }
                if (updates.Count == 0)
                {
                    MessageBox.Show("Please fill at least one field to update.");
                    return;
                }
                if (!string.IsNullOrWhiteSpace(res_address.Text))
                {
                    updates.Add("address = @address");
                    cmd.Parameters.AddWithValue("@address", res_address.Text);
                }
                if (updates.Count == 0)
                {
                    MessageBox.Show("Please fill at least one field to update.");
                    return;
                }

                int customerId = UserManager.GetCurrentRestaurantId();

                cmd.CommandText = $"UPDATE consumers SET {string.Join(", ", updates)} WHERE cus_id = @id";
                cmd.Parameters.AddWithValue("@id", customerId);

                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsAffected > 0 ? "Profile updated successfully!" : "No changes made.");
            }
        }
        private void EditProfilRes_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResturantProfile resturantProfile = new ResturantProfile(_userId);
            resturantProfile.Show();
            this.Close();
        }
    }
}
