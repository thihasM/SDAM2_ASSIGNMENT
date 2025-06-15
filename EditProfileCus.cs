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
    public partial class EditProfileCus : Form
    {
        private int _userId;
        public EditProfileCus(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void user_back_btn_Click(object sender, EventArgs e)
        {
            CustomerProfile profile = new CustomerProfile(_userId);
            profile.Show();
            this.Close();
        }

        private void EditProfileCus_Load(object sender, EventArgs e)
        {

        }

        private void user_confirm_edit_btn_Click(object sender, EventArgs e)
        {
            var userId = UserManager.GetCurrentCustomerId();
            using (DatabaseHelper db = new DatabaseHelper())
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();

                List<string> updates = new List<string>();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (!string.IsNullOrWhiteSpace(user_name_edit_textbox.Text))
                {
                    updates.Add("name = @name");
                    cmd.Parameters.AddWithValue("@name", user_name_edit_textbox.Text);
                }
                if (!string.IsNullOrWhiteSpace(user_phone__number_edit_textbox.Text))
                {
                    updates.Add("phone = @phone");
                    cmd.Parameters.AddWithValue("@phone", user_phone__number_edit_textbox.Text);
                }
                if (!string.IsNullOrWhiteSpace(user_email_edit_textbox.Text))
                {
                    updates.Add("email = @email");
                    cmd.Parameters.AddWithValue("@email", user_email_edit_textbox.Text);
                }
                if (updates.Count == 0)
                {
                    MessageBox.Show("Please fill at least one field to update.");
                    return;
                }

                int customerId = UserManager.GetCurrentCustomerId();

                cmd.CommandText = $"UPDATE consumers SET {string.Join(", ", updates)} WHERE cus_id = @id";
                cmd.Parameters.AddWithValue("@id", customerId);

                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsAffected > 0 ? "Profile updated successfully!" : "No changes made.");
            }
        }
    }
}
