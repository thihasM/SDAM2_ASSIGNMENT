using System.Drawing.Drawing2D;

namespace LOGIN_SDAM_ASSIGNMENT
{
    public partial class Handiyen : Form
    {
        public Handiyen()
        {
            InitializeComponent();

        }

        private void Sign_up_btn_Click(object sender, EventArgs e)
        {
            Signupselector signupSelector = new Signupselector();
            signupSelector.Show();
            this.Hide();
        }

        private void Log_in_btn_Click(object sender, EventArgs e)
        {
            Loginform loginForm = new Loginform();
            loginForm.Show();
            this.Hide();
        }

        private void testConnectionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                using (MySql.Data.MySqlClient.MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("✅ Connection successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Connection failed:\n" + ex.Message);
            }
        }

        private void Handiyen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
